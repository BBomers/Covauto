using CovautoAPI.Applicatie.Interfaces;
using CovautoAPI.Domain.Klasse;
using CovautoAPI.Shared.DTOs.LeenAuto;
using CovautoAPI.Shared.DTOs.Reserveringen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Applicatie.Repositories
{
    public class LeenAutoRepository : ILeenAutoRepository
    {

        private readonly CovautoContext covautoContext;
        public LeenAutoRepository(CovautoContext covautoContext)
        {
            this.covautoContext = covautoContext;
        }

        public IEnumerable<FullLeenAutoListItem> getAll()
        {
            var data = covautoContext.LeenAuto
                .Select(w => new FullLeenAutoListItem
                {
                    Id = w.Id,
                    Kenteken = w.Kenteken,
                    KilometerStand = w.KilometerStand,
                    Reserveringen = covautoContext.Reservingen
                        .Select(r => new ReserveringListItem
                        {
                            Id = r.Id,
                            ReserveerDatum = r.ReserveerDatum,
                            BoekDatumVanaf = r.BoekDatumVanaf,
                            BoekDatumTot = r.BoekDatumTot

                        })
                        .ToList()
                })
                .ToList();


            return data;
        }

    }
}
