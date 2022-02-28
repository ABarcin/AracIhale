using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface ILogErrorRepository : IRepository<LogError>
    {
        void AddLog(string sayfaAd,string islem ,string exception);
    }
}
