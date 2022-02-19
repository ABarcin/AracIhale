using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class LogMapping
    {
        public Log LogVMToLog(LogVM vm)
        {
            return new Log()
            {
                LogID = vm.LogID,
                LogDetay = vm.LogDetay,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public LogVM LogToLogVM(Log model)
        {
            return new LogVM()
            {
                LogID = model.LogID,
                LogDetay = model.LogDetay,
                IsActive = model.IsActive,
                CreatedBy = model.CreatedBy,
                CreatedDate = model.CreatedDate,
                ModifiedBy = model.ModifiedBy,
                ModifiedDate = model.ModifiedDate
            };
        }

        public List<LogVM> ListLogToListLogVM(List<Log> list)
        {
            List<LogVM> listListVM = new List<LogVM>();
            foreach (Log item in list)
            {
                listListVM.Add(LogToLogVM(item));
            }
            return listListVM;
        }

        public List<Log> ListLogVMToListLog(List<LogVM> listVM)
        {
            List<Log> listList = new List<Log>();
            foreach (LogVM item in listVM)
            {
                listList.Add(LogVMToLog(item));
            }
            return listList;
        }
    }
}
