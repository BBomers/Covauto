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

        protected override async Task OnInitializedAsync()
        {
            leenautos = await HttpClient.GetFromJsonAsync<IEnumerable<LeenAutoListItem>>("/api/leenautos");
            collegas = await HttpClient.GetFromJsonAsync<IEnumerable<CollegaListItem>>("/api/collegas");
        }
        
        private async Task Submit()
        {
            var result = await HttpClient.PostAsJsonAsync<CreateReservering>("/api/reserveringen", reservering);
            if (result.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/reserveringen");
                // Succesmelding tonen
            }
            else
            {
                // Foutmelding tonen
            }
        }
    }
}
