using AracIhale.CORE.Login;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class LoginRepository
    {
        public List<SayfaYetkiYonetimi> HerSayfaIcınYetkiVMDoldur(RolVM rolVM)
        {
            List<SayfaYetkiYonetimi> list = new List<SayfaYetkiYonetimi>();

            UnitOfWork.UnitOfWork unitOfWork = new UnitOfWork.UnitOfWork();

            List<SayfaVM> sayfaListesi = unitOfWork.SayfaRepository.TumSayfalar();

            List<YetkiVM> yetkiListesi = unitOfWork.YetkiRepository.TumYetkiler();

            foreach (var sayfaVM in sayfaListesi)
            {
                List<YetkiVM> sayfaYetkiListesi = new List<YetkiVM>();

                List<RolYetkiVM> rolYetkiListesi = unitOfWork.RolYetkiRepository.RolYetkiVMListesiGetir(rolVM, sayfaVM);

                foreach (var rolYetkiVM in rolYetkiListesi)
                {
                    foreach (var yetkiVM in yetkiListesi)
                    {
                        if (rolYetkiVM.YetkiID == yetkiVM.YetkiID)
                        {
                            sayfaYetkiListesi.Add(yetkiVM);
                        }
                    }
                }

                list.Add(new SayfaYetkiYonetimi
                {
                    Sayfa = sayfaVM,
                    YetkiListesi = sayfaYetkiListesi
                });

            }

            return list;
        }
    }
}
