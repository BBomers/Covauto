using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using CovautoAPI.Shared.DTOs.LeenAuto;
using CovautoAPI.Shared.DTOs.Reserveringen;


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

        protected override async Task OnInitializedAsync()
        {
            leenautos = await HttpClient.GetFromJsonAsync<IEnumerable<LeenAutoListItem>>("/api/leenautos");
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
