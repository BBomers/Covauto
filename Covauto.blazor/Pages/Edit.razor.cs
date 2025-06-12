using System;
using System.Collections.Generic;
using System.Linq;
using CovautoAPI.Domain.Entities;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Covauto.blazor.Pages
{
    public partial class Edit : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject] 
        private HttpClient HttpClient { get; set; }
        [Inject] 
        private NavigationManager NavigationManager { get; set; }
        [Inject] 
        private IJSRuntime JS { get; set; }

        private ReserveringData rit = new ReserveringData();

        protected override async Task OnInitializedAsync()
        {
            // Haal de reservering op via API GET
            rit = await HttpClient.GetFromJsonAsync<ReserveringData>($"api/ReserveringData/{Id}");

        }

        private async Task HandleSubmit()
        {
            Console.WriteLine("Rit succesvol verzonden!");

            var response = await HttpClient.PutAsJsonAsync($"api/ReserveringData/{Id}", rit);

            if (response.IsSuccessStatusCode)
            {

                NavigationManager.NavigateTo($"/Reserveringen/View/{rit.ReserveringID}?success={Id}");
                await JS.InvokeVoidAsync("showSweetAlert", "Succes!", "De rit is aangepast.", "success");
            }
            else
            {
                Console.WriteLine("Fout bij opslaan van reservering.");
                await JS.InvokeVoidAsync("showSweetAlert", "Error!", "Fout bij opslaan van reserveringData.", "error");

            }
        }

        private async Task VerwijderRit(int id)
        {
            bool confirmed = await JS.InvokeAsync<bool>("confirm", "Weet je zeker dat je deze rit wilt verwijderen?");
            if (!confirmed)
                return;

            var response = await HttpClient.DeleteAsync($"api/ReserveringData/{id}");
            if (response.IsSuccessStatusCode)
            {
                // Optioneel: toon een succesbericht, refresh lijst, etc.
                await JS.InvokeVoidAsync("showSweetAlert", "Succes!", "Rit succesvol verwijderd.", "success");
                // Bijvoorbeeld herladen of navigeren:
                NavigationManager.NavigateTo("/Reserveringen");
            }
            else
            {
                await JS.InvokeVoidAsync("showSweetAlert", "Error!", "Fout bij verwijderen van de rit.", "error");
            }
        }
    }
}