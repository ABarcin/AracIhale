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
    public class AracOzellikRepository : Repository<AracOzellik>, IAracOzellikRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracOzellikRepository(AracIhaleEntities context) : base(context)
        {

        }

        public void AracOzellikEkle(List<AracOzellikVM> aracOzellikVMs)
        {
            List<AracOzellik> eklenecekAracOzellikler = new AracOzellikMapping().ListAracOzellikVMToListAracOzellik(aracOzellikVMs);
            this.AddRange(eklenecekAracOzellikler);
        }

        public List<AracOzellikVM> AracOzellikleriniGetir(int id)
        {
            // AracOzellik tablosunda araca ait olan tüm özellikleri getiriyor.
            return new AracOzellikMapping().ListAracOzellikToListAracOzellikVM(GetAll(x => x.AracID == id).ToList());
        }

        public void AracOzellikGuncelle(List<AracOzellikVM> aracOzellikVMs)
        {
            List<AracOzellik> guncellenecekAracOzellikler = new AracOzellikMapping().ListAracOzellikVMToListAracOzellik(aracOzellikVMs);
            foreach (AracOzellik aracOzellik in guncellenecekAracOzellikler)
            {
                this.UpdateWithId(aracOzellik.AracOzellikID, aracOzellik);
            }
        }
    }
}
