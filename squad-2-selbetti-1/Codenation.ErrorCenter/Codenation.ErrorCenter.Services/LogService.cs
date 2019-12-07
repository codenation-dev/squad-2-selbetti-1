using Codenation.ErrorCenter.Models;
using System;
using System.Collections.Generic;

namespace Codenation.ErrorCenter.Services
{
    public class LogService : ILogService
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Log log)
        {
            throw new NotImplementedException();
        }

        public IList<Log> FindAllLogs()
        {
            throw new NotImplementedException();
        }

        public IList<Log> FindByFilter(ErrorFilter filter)
        {
            throw new NotImplementedException();
        }

        public Log FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Log Save(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
