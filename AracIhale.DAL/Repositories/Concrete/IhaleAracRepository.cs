using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Mapping;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class IhaleAracRepository : Repository<IhaleArac>, IIhaleAracRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public IhaleAracRepository(AracIhaleEntities context) : base(context)
        {

        }
        public IhaleAracListVM IhaleAracFindByID(int id)
        {         
            var aracList = ThisContext.Arac.Include("ArabaModel").Include("OzellikBilgi").Include("Marka").Include("Statu").Include("AracStatu").Include("IhaleArac")
                .Where(x => x.IsActive == true && x.AracID == id)
                .Select(x => new IhaleAracListVM
                {
                    AracID = x.AracID,
                    IhaleAracID = x.IhaleArac.Where(y=>y.IsActive == true && y.AracID==x.AracID).Select(z=>z.IhaleAracID).DefaultIfEmpty(-1).FirstOrDefault(),
                    MarkaAd = x.Marka.Ad,
                    ModelAd = x.ArabaModel.Ad,
                    StatuID = x.AracStatu.Where(y => y.IsActive == true).FirstOrDefault().StatuID,
                    StatuAd = x.AracStatu.Where(y => y.IsActive == true).FirstOrDefault().Statu.StatuAd,       
                    Yil = x.Yil,
                    Km = x.Km,

                    GovdeAd = x.AracOzellik.Where(y => y.IsActive == true)
                                         .Where(y => y.OzellikBilgi.OzellikBilgiID == y.OzellikBilgiID)
                                         .Where(y => y.OzellikBilgi.OzellikID == 1)
                                         .FirstOrDefault().OzellikBilgi.OzellikDetay,

                    YakıtAd = x.AracOzellik.Where(y => y.IsActive == true)
                                            .Where(y => y.OzellikBilgi.OzellikBilgiID == y.OzellikBilgiID)
                                            .Where(y => y.OzellikBilgi.OzellikID == 2)
                                            .FirstOrDefault().OzellikBilgi.OzellikDetay,

                    VitesAd = x.AracOzellik.Where(y => y.IsActive == true)
                                            .Where(y => y.OzellikBilgi.OzellikBilgiID == y.OzellikBilgiID)
                                            .Where(y => y.OzellikBilgi.OzellikID == 3)
                                            .FirstOrDefault().OzellikBilgi.OzellikDetay,

                    Versiyon = x.AracOzellik.Where(y => y.IsActive == true)
                                            .Where(y => y.OzellikBilgi.OzellikBilgiID == y.OzellikBilgiID)
                                            .Where(y => y.OzellikBilgi.OzellikID == 4)
                                            .FirstOrDefault().OzellikBilgi.OzellikDetay,

                    RenkAd = x.AracOzellik.Where(y => y.IsActive == true)
                                            .Where(y => y.OzellikBilgi.OzellikBilgiID == y.OzellikBilgiID)
                                            .Where(y => y.OzellikBilgi.OzellikID == 5)
                                            .FirstOrDefault().OzellikBilgi.OzellikDetay,

                    DonanımAd = x.AracOzellik.Where(y => y.IsActive == true)
                                            .Where(y => y.OzellikBilgi.OzellikBilgiID == y.OzellikBilgiID)
                                            .Where(y => y.OzellikBilgi.OzellikID == 6)
                                            .FirstOrDefault().OzellikBilgi.OzellikDetay,

                });

            return aracList.First();
        }
    }
}
