using Codenation.ErrorCenter.Models;
using Codenation.ErrorCenter.Models.DTOs;
using Codenation.ErrorCenter.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return context.Logs.Select(x => x)
                .Distinct()
                .ToList();
        }

        public IList<Log> FindByFilter(ErrorFilterDTO filter)
        {
            List<Log> logs = context.Logs.Select(x => x)
                .Distinct()
                .ToList();

            logs = OrderLogs(logs, filter.order);
            return SearchByFilter(logs, filter);
        }

        public Log FindById(int id)
        {
            return context.Logs.Find(id);
        }

        public Log Save(Log log)
        {
            var state = EntityState.Added;
            context.Entry(log).State = state;
            context.SaveChanges();
            return log;
        }

        public bool Delete(int id)
        {
            var state = EntityState.Deleted;
            context.Entry(context.Logs.Find(id)).State = state;
            context.SaveChanges();
            return true;
        }

        private List<Log> OrderLogs(List<Log> logs, string orderBy)
        {
            if (orderBy == null)
                return logs;

            orderBy = orderBy.ToLower();

            if (orderBy.Equals("nivel") || orderBy.Equals("nível"))
                return logs.OrderBy(x => x.Level).ToList();

            if (orderBy.Equals("frequencia") || orderBy.Equals("frequência"))
                return logs.OrderBy(x => x.Frequency).ToList();

            return logs;
        }

        private List<Log> SearchByFilter(List<Log> logs, ErrorFilterDTO filter)
        {
            if (filter == null || filter.search == null)
                return logs;

            string filterBy = filter.search.ToLower();
            string filterContains = filter.searchValue;

            if (filterBy.Equals("descricao") || filterBy.Equals("descrição"))
                return logs.Where(x => x.Description.Contains(filterContains))
                    .ToList();

            if (filterBy.Equals("origem"))
                return logs.Where(x => x.Origin.Contains(filterContains))
                    .ToList();

            return logs;
        }

    }
}
