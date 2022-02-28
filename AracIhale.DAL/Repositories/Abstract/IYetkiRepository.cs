using AracIhale.CORE.VM;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IYetkiRepository : IRepository<Yetki>
    {
        List<YetkiVM> TumYetkiler();
    }
}
