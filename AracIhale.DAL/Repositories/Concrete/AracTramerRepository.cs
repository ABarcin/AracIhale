using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Linq;

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

        public int AracTramerEkle(AracTramerVM aracTramerVM)
        {
            AracTramer eklenecekAracTramer = new AracTramerMapping().AracTramerVMToAracTramer(aracTramerVM);
            this.Add(eklenecekAracTramer);
            ThisContext.SaveChanges();

            return eklenecekAracTramer.AracTramerID;
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

        /// <summary>
        /// Arac ID'sine gore AracTramerVM getiren metod.
        /// </summary>
        /// <param name="id">Arac ID</param>
        public AracTramerVM GetAracTramerVMByAracID(int id)
        {
            AracTramerRepository aracTramerRepository = new AracTramerRepository(ThisContext);


            return new AracTramerMapping()
                .AracTramerToAracTramerVM(aracTramerRepository
                .GetAll(x => x.AracID == id)
                .FirstOrDefault());
        }

    }
}
