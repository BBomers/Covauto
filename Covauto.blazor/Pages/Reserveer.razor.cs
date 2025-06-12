using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using CovautoAPI.Shared.DTOs.LeenAuto;
using CovautoAPI.Shared.DTOs.Reserveringen;
using CovautoAPI.Shared.DTOs.Collega;
using System.Globalization;


namespace Covauto.blazor.Pages
{
    public partial class Reserveer : ComponentBase
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private CreateReservering reservering = new CreateReservering();
        private IEnumerable<LeenAutoListItem> leenautos = [];
        private IEnumerable<CollegaListItem> collegas = [];
        private IEnumerable<ReserveringListItem> reserveringen = [];
        
        private string? foutmelding = null;

        protected override async Task OnInitializedAsync()
        {
            reservering.BoekDatumVanaf = DateTime.Now;
            reservering.BoekDatumTot = DateTime.Now.AddHours(1);

            leenautos = await HttpClient.GetFromJsonAsync<IEnumerable<LeenAutoListItem>>("/api/LeenAuto");
            collegas = await HttpClient.GetFromJsonAsync<IEnumerable<CollegaListItem>>("/api/Collega");
            reserveringen = await HttpClient.GetFromJsonAsync<IEnumerable<ReserveringListItem>>("/api/Reservering");

            if (leenautos.Any())
            {
                reservering.LeenAutoID = leenautos.First().Id; 
            }

            if (collegas.Any())
            {
                reservering.CollegaID = collegas.First().Id; 
            }
        }

        private async Task Submit()
        {
            foutmelding = null;

            var nieuweStart = reservering.BoekDatumVanaf;
            var nieuweEinde = reservering.BoekDatumTot;

            if (nieuweEinde <= nieuweStart)
            {
                foutmelding = "De eindtijd moet later zijn dan de starttijd.";
                return;
            }

            var selectedAutoReservations = reserveringen
                .Where(r => r.LeenAutoID == reservering.LeenAutoID)
                .ToList();

            foreach (var bestaande in selectedAutoReservations)
            {
                var bestaandeStart = bestaande.BoekDatumVanaf.AddMinutes(-30);
                var bestaandeEinde = bestaande.BoekDatumTot.AddMinutes(30);

                bool overlap = nieuweStart < bestaandeEinde && nieuweEinde > bestaandeStart;

                if (overlap)
                {
                    foutmelding = "Er moet minstens 30 minuten zitten tussen twee reserveringen voor dezelfde auto.";
                    return;
                }
            }

            var result = await HttpClient.PostAsJsonAsync("/api/Reservering", reservering);
            if (result.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/Reserveringen");
                Console.WriteLine("Reservering verzonden");
            }
            else
            {
                foutmelding = "Er is een fout opgetreden bij het verzenden van de reservering.";
                Console.WriteLine("Er is iets mis");
            }
        }

    }
}
