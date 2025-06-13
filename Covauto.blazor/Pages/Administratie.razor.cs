using System;
using System.Collections.Generic;
using System.Linq;
using CovautoAPI.Shared.DTOs.Collega;
using CovautoAPI.Shared.DTOs.LeenAuto;
using CovautoAPI.Shared.DTOs.Reserveringen;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using CovautoAPI.Domain.Entities;
using static System.Net.Mime.MediaTypeNames;
using ClosedXML.Excel;
using Microsoft.JSInterop;

namespace Covauto.blazor.Pages
{
    public partial class Administratie : ComponentBase
    {
        [Inject]
        private IJSRuntime JS { get; set; }

        [Inject]
        private HttpClient HttpClient { get; set; }


        private IEnumerable<ReserveringListItem> reserveringen = [];
        private List<ReserveringMonth> reserveringenmonth = [];

        protected override async Task OnInitializedAsync()
        {
            reserveringen = await HttpClient.GetFromJsonAsync<IEnumerable<ReserveringListItem>>("api/Reservering");

            foreach (var Reservering in reserveringen)
            {
                DateTime date = Reservering.BoekDatumTot;
                bool cancel = false;
                if (reserveringenmonth != null)
                {
                    foreach (var var in reserveringenmonth)
                    {
                        if (var.Month == date.Month && var.Year == date.Year)
                        {
                            cancel = true;

                        }
                    }
                }
                if (cancel == false)
                {
                    ReserveringMonth month = new ReserveringMonth();
                    month.Year = date.Year;
                    month.Month = date.Month;
                    reserveringenmonth.Add(month);
                }

            }
        }

        private async Task download(int month, int year)
        {

            List<ReserveringListItem> reserveringenmonthchoosen = [];

            foreach (var Reservering in reserveringen)
            {
                DateTime date = Reservering.BoekDatumTot;
                if (date.Month == month && date.Year == year)
                {
                    reserveringenmonthchoosen.Add(Reservering);
                }
            }

            var excelBytes = ExportToExcel(reserveringenmonthchoosen);
            var base64 = Convert.ToBase64String(excelBytes);

            await JS.InvokeVoidAsync("downloadFile", $"reserveringen_{month}_{year}.xlsx", base64);
        }



        public byte[] ExportToExcel(List<ReserveringListItem> reserveringen)
        {
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Reserveringen");

            worksheet.Cell(1, 1).Value = "Id";
            worksheet.Cell(1, 2).Value = "LeenAutoID";
            worksheet.Cell(1, 3).Value = "CollegaID";
            worksheet.Cell(1, 4).Value = "ReserveerDatum";
            worksheet.Cell(1, 5).Value = "BoekDatumVanaf";
            worksheet.Cell(1, 6).Value = "BoekDatumTot";
            worksheet.Cell(1, 7).Value = "KilometerStandBegin";
            worksheet.Cell(1, 8).Value = "KilometerStandEind";

            for (int i = 0; i < reserveringen.Count; i++)
            {
                var r = reserveringen[i];
                int row = i + 2;
                worksheet.Cell(row, 1).Value = r.Id;
                worksheet.Cell(row, 2).Value = r.LeenAutoID;
                worksheet.Cell(row, 3).Value = r.CollegaID;
                worksheet.Cell(row, 4).Value = r.ReserveerDatum.ToString("yyyy-MM-dd HH:mm");
                worksheet.Cell(row, 5).Value = r.BoekDatumVanaf.ToString("yyyy-MM-dd");
                worksheet.Cell(row, 6).Value = r.BoekDatumTot.ToString("yyyy-MM-dd");
                worksheet.Cell(row, 7).Value = r.KilometerStandBegin ?? 0;
                worksheet.Cell(row, 8).Value = r.KilometerStandEind ?? 0;
            }

            worksheet.Columns().AdjustToContents();

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            return stream.ToArray();
        }


    }
}
