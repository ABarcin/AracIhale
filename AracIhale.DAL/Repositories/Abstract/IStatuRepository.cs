using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IStatuRepository : IRepository<Statu>
    {
        int HemenAlSatisStatuIDGetir();
    }
}
