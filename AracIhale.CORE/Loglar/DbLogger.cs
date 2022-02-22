using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Loglar
{
    /// <summary>
    /// Veritabani loglama sinifi
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class DbLogger<TEntity> : ILogger<TEntity> where TEntity : class
    {
        public void LogAl(TEntity etkilenenTablo, EnumCRUD islem)
        {
            
        }
    }
}
