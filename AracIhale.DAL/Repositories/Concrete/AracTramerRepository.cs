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
    public class AracTramerRepository : Repository<AracTramer>, IAracTramerRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracTramerRepository(AracIhaleEntities context) : base(context)
        {

        }

        public int EklenenAracTramerIDGetir()
        {
            return this.GetAll().OrderByDescending(x => x.AracTramerID).First().AracTramerID;
        }

        public void AracTramerEkle(AracTramerVM aracTramerVM)
        {
            AracTramer eklenecekAracTramer = new AracTramerMapping().AracTramerVMToAracTramer(aracTramerVM);
            this.Add(eklenecekAracTramer);
        }

        public void AracTramerGuncelle(AracTramerVM aracTramerVM)
        {
            AracTramer guncellenecekAracTramer = new AracTramerMapping().AracTramerVMToAracTramer(aracTramerVM);
            this.UpdateWithId(aracTramerVM.AracTramerID,guncellenecekAracTramer);
        }

        public AracTramerVM AracTramerVMGetir(int aracID)
        {
            AracTramerVM aracTramerVM = new AracTramerMapping()
                .AracTramerToAracTramerVM(this.GetAll(x => x.AracID == aracID).OrderByDescending(y => y.AracTramerID).FirstOrDefault());

            return aracTramerVM;
        }

    }
}
