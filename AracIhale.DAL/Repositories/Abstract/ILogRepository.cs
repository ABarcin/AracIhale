using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface ILogRepository : IRepository<Log>
    {
        void AddLog(string sayfaAd,string islem);
    }
}
