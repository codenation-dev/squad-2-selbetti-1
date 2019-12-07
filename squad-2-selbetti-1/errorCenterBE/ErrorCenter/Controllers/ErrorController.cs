﻿using errorCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace errorCenter.Controllers
{
    public class ErrorController : ApiController
    
        {

        public static List<LogInfo> _listLogs = new List<LogInfo> {
                new LogInfo {
                   id = 1,
                   description= "Failed to load resource",
                   origin = "172.16.3.88",
                   level = "error",
                   log = "Bug na central de erro",
                   environment = "produção",
                   frequency = 1000,
                   date = "28/11/2015 as 10:11",
                   isArchived = true
                },
                new LogInfo {
                  id = 2,
                   description= "Deu erro porque fiz errado",
                   origin = "172.16.1.208",
                   level = "warning",
                   log = "Bug na central de erro",
                   environment = "desenvolvimento",
                   frequency = 1000,
                   date = "23/07/2019 as 16:45",
                   isArchived = false
                },
                new LogInfo {
                   id = 3,
                   description= "Failed to load resource",
                   origin = "172.16.2.39",
                   level = "error",
                   log = "Bug na central de erro",
                   environment = "produção",
                   frequency = 1000,
                   date = "02/01/2015 as 14:30",
                   isArchived = false

                },
                new LogInfo {
                  id = 4,
                   description= "Deu erro porque fiz errado",
                   origin = "172.16.2.300",
                   level = "error",
                   log = "Bug na central de erro",
                   environment = "desenvolvimento",
                   frequency = 1000,
                   date = "25/10/2019 as 12:12",
                   isArchived = false
                },
                new LogInfo {
                   id = 5,
                   description= "Deu erro porque fiz errado",
                   origin = "172.16.1.46",
                   level = "error",
                   log = "Bug na central de erro",
                   environment = "produção",
                   frequency = 1000,
                   date = "01/02/2019 as 23:15",
                   isArchived = false
                },
                new LogInfo {
                  id = 6,
                   description= "Deu erro porque fiz errado",
                   origin = "172.16.2.300",
                   level = "error",
                   log = "Bug na central de erro",
                   environment = "desenvolvimento",
                   frequency = 1000,
                   date = "25/10/2019 as 12:12",
                   isArchived = false
                },
                new LogInfo {
                   id = 7,
                   description= "Deu erro porque fiz errado",
                   origin = "172.16.1.46",
                   level = "error",
                   log = "Bug na central de erro",
                   environment = "produção",
                   frequency = 1000,
                   date = "01/01/2019 as 23:15",
                   isArchived = false
                }
        };

        [HttpGet]
        [Route("api")]
        public IEnumerable<LogInfo> Get()
        {
            return _listLogs;
        }

        [HttpGet]
        [Route("api/{id}")]
        public LogInfo Get(int id)
        {
            return _listLogs.FirstOrDefault(a => a.id == id);
        }

        [HttpPost]
        [Route("api")]
        public List<LogInfo> Post([FromBody]ErrorFilter filter)
        {
            //FAZER O FILTRO
            return _listLogs;
        }


        [HttpPut]
        [Route("api/{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        [Route("api/{id}")]
        public void Delete(int id)
        {
            _listLogs.RemoveAll(x => x.id == id);
        }
    }
}