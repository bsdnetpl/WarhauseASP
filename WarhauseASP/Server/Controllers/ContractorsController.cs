using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WarhauseASP.Server.DB;
using WarhauseASP.Server.Service;
using WarhauseASP.Shared;

namespace WarhauseASP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractorsController : ControllerBase
    {
        private readonly ConnectionDB _connectionDB;
        private readonly IContractor _contractor;

        public ContractorsController(ConnectionDB connectionDB, IContractor contractor)
        {
            _connectionDB = connectionDB;
            _contractor = contractor;
        }
        [HttpGet("GetAllContractors")]
        public List<Contractors> GetAllContrectors() 
        {
             return _contractor.GetAllContrectors();
        }
        [HttpGet("id")]
        public ActionResult<Contractors> GetId([FromRoute] Guid guid) 
        {
            return Ok(_contractor.GetId(guid));
        }
        [HttpDelete]
        public IActionResult DeleteContractor(Guid IdContractor)
        {
            if(IdContractor == null)
            {
                return BadRequest();
            }
            return Ok(_contractor.DeleteContractor(IdContractor));
        }
        [HttpPut("EditContractor")]
        public IActionResult EditContractor(Contractors contractors)
        {
            if(contractors == null)
            {
                return NotFound();
            }
           return Ok(_contractor.EditContractor(contractors));
        }
    }
}
