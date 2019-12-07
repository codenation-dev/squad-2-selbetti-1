using System;
using System.Collections.Generic;
using errorCenter.Models;

namespace ErrorCenter.Service
{
    public class ErroService : IErrorService
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LogInfo log)
        {
            throw new NotImplementedException();
        }

        public IList<LogInfo> FindAllLogs()
        {
            throw new NotImplementedException();
        }

        public IList<LogInfo> FindByFilter(ErrorFilter filter)
        {
            throw new NotImplementedException();
        }

        public LogInfo FindById(int id)
        {
            throw new NotImplementedException();
        }

        public LogInfo Save(LogInfo log)
        {
            throw new NotImplementedException();
        }
    }
}
