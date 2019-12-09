using Codenation.ErrorCenter.Models;
using Codenation.ErrorCenter.Models.DTOs;
using Codenation.ErrorCenter.Models.Models;
using System;
using System.Collections.Generic;

namespace Codenation.ErrorCenter.Services
{
    public class LogService : ILogService
    {
        private ErrorCenterContext context;

        public LogService(ErrorCenterContext context)
        {
            this.context = context;
        }

        public static List<Log> _listLogs = new List<Log> {
                new Log {
                   Id = 1,
                   Description= "Failed to load resource",
                   Origin = "172.16.3.88",
                   Level = "error",
                   Data = "Bug na central de erro",
                   Environment = "produção",
                   Frequency = 1000,
                   Date = "28/11/2015 as 10:11",
                   IsArchived = true
                },
                new Log {
                   Id = 2,
                   Description= "Deu erro porque fiz errado",
                   Origin = "172.16.1.208",
                   Level = "warning",
                   Data = "Bug na central de erro",
                   Environment = "desenvolvimento",
                   Frequency = 1000,
                   Date = "23/07/2019 as 16:45",
                   IsArchived = false
                },
                new Log {
                   Id = 3,
                   Description= "Failed to load resource",
                   Origin = "172.16.2.39",
                   Level = "error",
                   Data = "Bug na central de erro",
                   Environment = "produção",
                   Frequency = 1000,
                   Date = "02/01/2015 as 14:30",
                   IsArchived = false

                },
                new Log {
                   Id = 4,
                   Description= "Deu erro porque fiz errado",
                   Origin = "172.16.2.300",
                   Level = "error",
                   Data = "Bug na central de erro",
                   Environment = "desenvolvimento",
                   Frequency = 1000,
                   Date = "25/10/2019 as 12:12",
                   IsArchived = false
                },
                new Log {
                   Id = 5,
                   Description= "Deu erro porque fiz errado",
                   Origin = "172.16.1.46",
                   Level = "error",
                   Data = "Bug na central de erro",
                   Environment = "produção",
                   Frequency = 1000,
                   Date = "01/02/2019 as 23:15",
                   IsArchived = false
                },
                new Log {
                   Id = 6,
                   Description= "Deu erro porque fiz errado",
                   Origin = "172.16.2.300",
                   Level = "error",
                   Data = "Bug na central de erro",
                   Environment = "desenvolvimento",
                   Frequency = 1000,
                   Date = "25/10/2019 as 12:12",
                   IsArchived = false
                },
                new Log {
                   Id = 7,
                   Description= "Deu erro porque fiz errado",
                   Origin = "172.16.1.46",
                   Level = "error",
                   Data = "Bug na central de erro",
                   Environment = "produção",
                   Frequency = 1000,
                   Date = "01/01/2019 as 23:15",
                   IsArchived = false
                }
        };

        public IList<Log> FindAllLogs()
        {
            return _listLogs;
        }

        public IList<Log> FindByFilter(ErrorFilterDTO filter)
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

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
