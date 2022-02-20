using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IIlanRepository : IRepository<Ilan>
    {
        IlanVM GetIlanVMByAracID(int id);
    }
}
