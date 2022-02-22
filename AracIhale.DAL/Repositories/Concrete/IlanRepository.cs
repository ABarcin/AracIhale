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
    public class IlanRepository : Repository<Ilan>, IIlanRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public IlanRepository(AracIhaleEntities context) : base(context)
        {

        }

        public IlanVM IlanVMGetir(int aracID)
        {
            IlanVM ilanVM = new IlanMapping()
                .IlanToIlanVM(this.GetAll(x => x.AracID == aracID).OrderByDescending(y => y.IlanID).FirstOrDefault());

            return ilanVM;
        }

        public void IlanEkle(IlanVM ilanVM)
        {
            Ilan eklenecekIlan = new IlanMapping().IlanVMToIlan(ilanVM);
            this.Add(eklenecekIlan);
        }

        public void IlanGuncelle(IlanVM ilanVM)
        {
            Ilan guncellenecekIlan = new IlanMapping().IlanVMToIlan(ilanVM);
            this.UpdateWithId(ilanVM.IlanID, guncellenecekIlan);
        }
    }
}
