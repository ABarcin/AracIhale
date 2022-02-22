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
    public class AracFiyatRepository : Repository<AracFiyat>, IAracFiyatRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracFiyatRepository(AracIhaleEntities context) : base(context)
        {

        }

        public void AracFiyatEkle(AracFiyatVM aracFiyatVM)
        {
            AracFiyat eklenecekAracFiyat = new AracFiyatMapping().AracFiyatVMToAracFiyat(aracFiyatVM);
            this.Add(eklenecekAracFiyat);
        }

        public AracFiyatVM AracinGuncelFiyatiniGetir(int id)
        {
            // AracFiyat tablosunda araca ait en son girilen fiyatı getiriyor.
            return new AracFiyatMapping().AracFiyatToAracFiyatVM(GetAll(x=>x.AracID == id).LastOrDefault());
        }
    }
}
