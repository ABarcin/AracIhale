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
    public class RolYetkiRepository : Repository<RolYetki>, IRolYetkiRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public RolYetkiRepository(AracIhaleEntities context) : base(context)
        {

        }

        public void RolYetkiEkle(RolVM rolVM, SayfaVM sayfaVM, YetkiVM yetkiVM)
        {
            RolYetki eklenecek = new RolYetki
            {
                RolID = rolVM.RolID,
                YetkiID = yetkiVM.YetkiID,
                SayfaID = sayfaVM.SayfaID,
            };

            Add(eklenecek);
        }

        public void RolYetkiSoftDelete(RolVM rolVM, SayfaVM sayfaVM)
        {
            RolYetkiListesiGetir(rolVM, sayfaVM).ForEach(x => SoftRemove(x));
        }

        public List<RolYetki> RolYetkiListesiGetir(RolVM rolVM, SayfaVM sayfaVM)
        {
            return ThisContext.RolYetki.Where(x => x.RolID == rolVM.RolID && x.SayfaID == sayfaVM.SayfaID && x.IsActive == true).ToList();
        }

        public List<RolYetkiVM> RolYetkiVMListesiGetir(RolVM rolVM, SayfaVM sayfaVM)
        {
            return new RolYetkiMapping().ListRolYetkiToRolYetkiVM(RolYetkiListesiGetir(rolVM, sayfaVM));
        }

    }
}
