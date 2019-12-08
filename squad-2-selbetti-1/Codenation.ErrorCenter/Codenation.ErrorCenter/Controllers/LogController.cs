using AutoMapper;
using Codenation.ErrorCenter.Models.DTOs;
using Codenation.ErrorCenter.Models.Models;
using Codenation.ErrorCenter.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Codenation.ErrorCenter.Controllers
{
    [Route("api/[controller]")]
    public class LogController : ControllerBase
    {
        private ILogService service;
        private readonly IMapper mapper;

        public LogController(ILogService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LogDTO>> Get()
        {
            return Ok(service.FindAllLogs().Select(x => mapper.Map<LogDTO>(x)));
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<LogDTO> Get(int id)
        {
            return Ok(mapper.Map<LogDTO>(service.FindById(id)));
        }

        [HttpPost]
        public ActionResult<List<LogDTO>> FindByFilter([FromBody]ErrorFilterDTO filter)
        {
            if (filter == null)
                return NoContent();

            return Ok(service.FindByFilter(filter).Select(x => mapper.Map<LogDTO>(x)));
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<LogDTO> Put([FromBody]LogDTO log)
        {
            if (log == null)
                return NoContent();

            return Ok(mapper.Map<LogDTO>(service.Save(mapper.Map<Log>(log))));
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool sucess = service.Delete(id);
            if (!sucess)
                return BadRequest();

            return Ok(sucess);
        }
    }
}
