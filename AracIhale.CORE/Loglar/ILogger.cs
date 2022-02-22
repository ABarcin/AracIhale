using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Loglar
{
    public interface ILogger<TEntity> where TEntity : class
    {
        /// <summary>
        /// Log alma metodu
        /// </summary>
        /// <param name="etkilenenTablo">Islem yapilacak tablo</param>
        /// <param name="islem">Islem turu</param>
        void LogAl(TEntity etkilenenTablo, EnumCRUD islem);
    }
}
