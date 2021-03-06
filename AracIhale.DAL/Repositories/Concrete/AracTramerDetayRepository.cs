using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class AracTramerDetayRepository : Repository<AracTramerDetay>, IAracTramerDetayRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracTramerDetayRepository(AracIhaleEntities context) : base(context)
        {

        }

        public void AracTramerDetayEkle(AracTramerDetayVM aracTramerDetayVM)
        {
            AracTramerDetay aracTramerDetay = new AracTramerDetayMapping().AracTramerDetayVMToAracTramerDetay(aracTramerDetayVM);
            this.Add(aracTramerDetay);
        }

        public void AracTramerDetayGuncelle(AracTramerDetayVM aracTramerDetayVM)
        {
            AracTramerDetay guncellenecekAracTramer = new AracTramerDetayMapping().AracTramerDetayVMToAracTramerDetay(aracTramerDetayVM);
            this.UpdateWithId(aracTramerDetayVM.AracTramerDetayID,guncellenecekAracTramer);
        }

        public AracTramerDetayVM AracTramerDetayVMGetir(int aracTramerID, int aracParcaID)
        {
            AracTramerDetayVM aracTramerDetayVM = new AracTramerDetayMapping()
                .AracTramerDetayToAracTramerDetayVM(this
                .GetAll(x => x.AracTramerID == aracTramerID && x.AracParcaID == aracParcaID).OrderByDescending(y => y.AracTramerID).First());

            return aracTramerDetayVM;
        }

        public List<AracTramerDetayVM> AracTramerVMListesiniGetir(int aracTramerID)
        {
            return new AracTramerDetayMapping().ListAracTramerDetayToListAracTramerDetayVM(this.GetAll(x => x.AracTramerID == aracTramerID));
        }
    }
}
