
using CovautoAPI.Shared.DTOs.ReserveringData;
using CovautoAPI.Shared.DTOs.Reserveringen;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace Covauto.blazor.Pages
{
    public partial class View : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        [Inject]
        private HttpClient HttpClient { get; set; }


        private IEnumerable<ReserveringDataListItem> Ritten = [];
        protected override async Task OnInitializedAsync()
        {
            Ritten = await HttpClient.GetFromJsonAsync<IEnumerable<ReserveringDataListItem>>($"api/ReserveringData/ByReserveringID/{Id}");

        }

    }
}
