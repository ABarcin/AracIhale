using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IAracRepository : IRepository<Arac>
    {
        #region Cagatay
        List<Arac> GetAraclarWithRelationship();
        Arac GetAracWithRelationshipByID(int id);
        List<AracCDListVM> GetAracByIhaleID(int id);
        #endregion

        List<AracListVM> AracListele(string marka, string model, string kTip, string statu);
        
    }
}
