

using CovautoAPI.Domain.Entities;
using CovautoAPI.Shared.DTOs.Collega;
using CovautoAPI.Shared.DTOs.LeenAuto;
using CovautoAPI.Shared.DTOs.Reserveringen;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace Covauto.blazor.Pages
{

    public partial class Reserveringen : ComponentBase
    {


        [Inject]
        private HttpClient HttpClient { get; set; }

        //[Inject]
        //private NavigationManager NavigationManager { get; set; }

        private IEnumerable<ReserveringListItem> reserveringen = [];
        private IEnumerable<CollegaListItem> collegaLijst = [];
        private IEnumerable<LeenAutoListItem> leenAutoLijst = [];
        protected override async Task OnInitializedAsync()
        {
            reserveringen = await HttpClient.GetFromJsonAsync<IEnumerable<ReserveringListItem>>("api/Reservering");
            collegaLijst = await HttpClient.GetFromJsonAsync<IEnumerable<CollegaListItem>>("api/Collega");
            leenAutoLijst = await HttpClient.GetFromJsonAsync<IEnumerable<LeenAutoListItem>>("api/LeenAuto");


        }

        /*private void ReserveringenAanmaken()
        {
            NavigationManager.NavigateTo("reserveringen/Reserveer");
        }

        private void ReserveringenBewerken(int id)
        {
            NavigationManager.NavigateTo($"reserveringen/bekijk/{id}");
        }*/
    }
}
