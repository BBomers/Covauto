using System;
using System.Collections.Generic;
using System.Linq;
using CovautoAPI.Shared.DTOs.Collega;
using CovautoAPI.Shared.DTOs.LeenAuto;
using CovautoAPI.Shared.DTOs.ReserveringData;
using CovautoAPI.Shared.DTOs.Reserveringen;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Covauto.blazor.Pages
{
    public partial class Dashboard : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        private HttpClient HttpClient { get; set; }
        [Inject]
        private IJSRuntime JS { get; set; }
        [Inject]
        private NavigationManager NavigationManager { get; set; }


        private IEnumerable<ReserveringDataListItem> reserveringen = [];
        private IEnumerable<LeenAutoListItem> leenautos = [];
        private IEnumerable<CollegaListItem> collega = [];
        

        protected override async Task OnInitializedAsync()
        {
            reserveringen = await HttpClient.GetFromJsonAsync<IEnumerable<ReserveringDataListItem>>($"api/Reservering");
            leenautos = await HttpClient.GetFromJsonAsync<IEnumerable<LeenAutoListItem>>($"api/LeenAuto");
            collega = await HttpClient.GetFromJsonAsync<IEnumerable<CollegaListItem>>($"api/Collega");

            

        }
    }
}
