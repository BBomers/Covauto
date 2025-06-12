using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CovautoAPI.Domain.Entities;

namespace Covauto.blazor.Pages
{
    public partial class Add : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }

        [Inject]
        private HttpClient HttpClient { get; set; }
        [Inject] 
        private NavigationManager NavigationManager { get; set; }


        [Inject]
        private IJSRuntime JS { get; set; }

        private ElementReference startStraatRef;
        private ElementReference startPostcodeRef;
        private ElementReference startStadRef;
        private ElementReference toStraatRef;
        private ElementReference toPostcodeRef;
        private ElementReference toStadRef;
        private ElementReference afstandRef;

        private async Task HandleSubmit(EventArgs e)
        {
            var startStraat = await JS.InvokeAsync<string>("getElementValue", startStraatRef);
            var startPostcode = await JS.InvokeAsync<string>("getElementValue", startPostcodeRef);
            var startStad = await JS.InvokeAsync<string>("getElementValue", startStadRef);
            var toStraat = await JS.InvokeAsync<string>("getElementValue", toStraatRef);
            var toPostcode = await JS.InvokeAsync<string>("getElementValue", toPostcodeRef);
            var toStad = await JS.InvokeAsync<string>("getElementValue", toStadRef);
            var afstandString = await JS.InvokeAsync<string>("getElementValue", afstandRef);

            int.TryParse(afstandString, out int afstand);

            var rit = new ReserveringData
            {
                ReserveringID = int.Parse(Id),
                StartStraat = startStraat,
                StartPostcode = startPostcode,
                StartStad = startStad,
                ToStraat = toStraat,
                ToPostcode = toPostcode,
                ToStad = toStad,
                Afstand = afstand
            };

            Console.WriteLine("Rit succesvol verzonden!");

            var response = await HttpClient.PostAsJsonAsync("api/ReserveringData", rit);

            if (response.IsSuccessStatusCode)
            {
                // Bijvoorbeeld: API returned alleen het nieuwe ID als int
                var newId = await response.Content.ReadFromJsonAsync<int>();

                NavigationManager.NavigateTo($"/Reserveringen/View/{Id}?success={newId}");
                await JS.InvokeVoidAsync("showSweetAlert", "Succes!", "De rit is aangepast.", "success");
            }
            else
            {
                Console.WriteLine("Fout bij opslaan van reservering.");
                await JS.InvokeVoidAsync("showSweetAlert", "Error!", "Fout bij opslaan van reservering.", "error");

            }
        }
    }
}
