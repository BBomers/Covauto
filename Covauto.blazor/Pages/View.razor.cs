
using CovautoAPI.Domain.Entities;
using CovautoAPI.Shared.DTOs.Collega;
using CovautoAPI.Shared.DTOs.LeenAuto;
using CovautoAPI.Shared.DTOs.ReserveringData;
using CovautoAPI.Shared.DTOs.Reserveringen;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace Covauto.blazor.Pages
{
    public partial class View : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        private HttpClient HttpClient { get; set; }
        [Inject] 
        private IJSRuntime JS { get; set; }
        [Inject]
        private NavigationManager NavigationManager { get; set; }


        private IEnumerable<ReserveringDataListItem> Ritten = [];

        private ReserveringListItem reservering;
        private LeenAutoListItem leenauto;
        private CollegaListItem collega;
        private int geschatteAfstand = 0;
        private bool _hasRun = false;

        protected override async Task OnInitializedAsync()
        {
            Ritten = await HttpClient.GetFromJsonAsync<IEnumerable<ReserveringDataListItem>>($"api/ReserveringData/ByReserveringID/{Id}");
            reservering = await HttpClient.GetFromJsonAsync<ReserveringListItem>($"api/Reservering/{Id}");
            leenauto = await HttpClient.GetFromJsonAsync<LeenAutoListItem>($"api/LeenAuto/{reservering.LeenAutoID}");
            collega = await HttpClient.GetFromJsonAsync<CollegaListItem>($"api/Collega/{reservering.CollegaID}");
            geschatteAfstand += reservering.KilometerStandBegin ?? leenauto.KilometerStand;
            foreach (var rit in Ritten)
            {
                geschatteAfstand += rit.Afstand;
            }



            StateHasChanged();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!_hasRun && reservering != null)
            {
                _hasRun = true;
                runBeginStand();
            }
        }
        private async Task runBeginStand()
        {

            if (reservering.KilometerStandBegin == null)
            {
                var result = await JS.InvokeAsync<string>("InputStand", "Start uw rit", "Voer de kilometerstand in van uw voertuig.", "question", leenauto.KilometerStand);

                if (result == null)
                {
                    return;
                }
                if (!string.IsNullOrWhiteSpace(result) && int.TryParse(result, out int inputKm))
                {
                    int huidigeKm = leenauto.KilometerStand;

                    if (inputKm >= huidigeKm)
                    {
                        reservering.KilometerStandBegin = inputKm;
                        await JS.InvokeVoidAsync("Swal.fire", "Opgeslagen!", $"Beginstand ingesteld op {inputKm} km", "success");
                        StateHasChanged();
                        var response = await HttpClient.PutAsJsonAsync($"api/Reservering/{Id}", reservering);

                    }
                    else
                    {
                        await JS.InvokeVoidAsync("showSweetAlert", "Error!", "De doorgegeven kilometerstand is lager dan de officiële kilometerstand.", "error");

                    }
                }
                else
                {
                    await JS.InvokeVoidAsync("showSweetAlert", "Error!", "Voer een geldige kilometerstand in.", "error");
                }

            }

        }

        private async Task runEindeStand()
        {

            if (reservering.KilometerStandEind == null)
            {
                var result = await JS.InvokeAsync<string>("InputStand", "Beëindig uw rit", "Voer de kilometerstand in van uw voertuig.", "question", geschatteAfstand);

                if (result == null)
                {
                    return;
                }
                if (!string.IsNullOrWhiteSpace(result) && int.TryParse(result, out int inputKm))
                {
                    int huidigeKm = reservering.KilometerStandBegin ?? 0;

                    if (inputKm >= huidigeKm)
                    {
                        reservering.KilometerStandEind = inputKm;
                        leenauto.KilometerStand = inputKm;
                        await JS.InvokeVoidAsync("Swal.fire", "Opgeslagen!", $"Eindstand ingesteld op {inputKm} km. De rit is afgesloten.", "success");
                        StateHasChanged();
                        await HttpClient.PutAsJsonAsync($"api/Reservering/{Id}", reservering);
                        await HttpClient.PutAsJsonAsync($"api/LeenAuto/{reservering.LeenAutoID}", leenauto);
                        NavigationManager.NavigateTo("/Reserveringen");

                    }
                    else
                    {
                        await JS.InvokeVoidAsync("showSweetAlert", "Error!", "De doorgegeven kilometerstand is lager dan de beginstand.", "error");

                    }
                }
                else
                {
                    await JS.InvokeVoidAsync("showSweetAlert", "Error!", "Voer een geldige kilometerstand in.", "error");
                }

            }

        }
        
        private async Task VerwijderRerservering(int id)
        {
            bool confirmed = await JS.InvokeAsync<bool>("confirm", "Weet je zeker dat je deze rit wilt verwijderen?");
            if (!confirmed)
                return;

            var response = await HttpClient.DeleteAsync($"api/ReserveringData/{id}");
            if (response.IsSuccessStatusCode)
            {
                await JS.InvokeVoidAsync("showSweetAlert", "Succes!", "Rit succesvol verwijderd.", "success");
                NavigationManager.NavigateTo("/Reserveringen");
            }
            else
            {
                await JS.InvokeVoidAsync("showSweetAlert", "Error!", "Fout bij verwijderen van reservering.", "error");
            }
        }

    }
}
