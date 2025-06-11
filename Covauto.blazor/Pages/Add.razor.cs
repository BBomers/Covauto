using System;
using System.Collections.Generic;
using System.Linq;
using CovautoAPI.Domain.Entities;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using Microsoft.JSInterop;

namespace Covauto.blazor.Pages
{
    public partial class Add : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        [Inject]
        private HttpClient HttpClient { get; set; }

        private ElementReference startStraatRef;
        private ElementReference startPostcodeRef;
        private ElementReference startStadRef;
        private ElementReference toStraatRef;
        private ElementReference toPostcodeRef;
        private ElementReference toStadRef;
        private ElementReference afstandRef;

        private async Task HandleSubmit(EventArgs e)
        {
            // JavaScript interop nodig om waarden op te halen
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

                ReserveringID = Id,
                StartPostcode = startPostcode,
                StartStad = startStad,
                ToStraat = toStraat,
                ToPostcode = toPostcode,
                ToStad = toStad,
                Afstand = afstand
            };

            await HttpClient.PostAsJsonAsync("api/ReserveringData", rit);
            Console.WriteLine("Rit succesvol verzonden!");
        }

        [Inject]
        private IJSRuntime JS { get; set; }

    }
}
