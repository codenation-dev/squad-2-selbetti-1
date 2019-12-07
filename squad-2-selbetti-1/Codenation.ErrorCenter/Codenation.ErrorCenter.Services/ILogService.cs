using Codenation.ErrorCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codenation.ErrorCenter.Services
{
    public interface ILogService
    {
        IList<Log> FindAllLogs();

        IList<Log> FindByFilter(ErrorFilter filter);

        Log FindById(int id);

        Log Save(Log log);

        Boolean Delete(int id);

        Boolean Delete(Log log);
    }
}
