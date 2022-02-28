using AracIhale.CORE.VM;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IRolYetkiRepository : IRepository<RolYetki>
    {
        void RolYetkiEkle(RolVM rolVM, SayfaVM sayfaVM, YetkiVM yetkiVM);

        void RolYetkiSoftDelete(RolVM rolVM, SayfaVM sayfaVM);

        List<RolYetki> RolYetkiListesiGetir(RolVM rolVM, SayfaVM sayfaVM);

        List<RolYetkiVM> RolYetkiVMListesiGetir(RolVM rolVM, SayfaVM sayfaVM);
    }
}
