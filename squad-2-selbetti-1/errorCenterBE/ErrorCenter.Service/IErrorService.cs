using errorCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorCenter.Service
{
    public interface IErrorService
    {
        IList<LogInfo> FindAllLogs();

        IList<LogInfo> FindByFilter(ErrorFilter filter);

        LogInfo FindById(int id);

        LogInfo Save(LogInfo log);

        Boolean Delete(int id);

        Boolean Delete(LogInfo log);
    }
}
