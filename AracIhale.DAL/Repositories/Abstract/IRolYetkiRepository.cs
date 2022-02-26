using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

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
