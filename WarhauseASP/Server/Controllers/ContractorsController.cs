using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarhauseASP.Server.DB;
using WarhauseASP.Shared;

namespace WarhauseASP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractorsController : ControllerBase
    {
        private readonly ConnectionDB _connectionDB;
       
        public ContractorsController(ConnectionDB connectionDB)
        {
            _connectionDB = connectionDB;
        }
        [HttpGet("GetAllContractors")]
        public ActionResult<IEnumerable<Contractors>>GetAllContrectors() 
        {
          var con =  _connectionDB.contractors.ToList();
            return Ok(con);
        }
        [HttpGet("id")]
        public ActionResult<Contractors> GetId([FromRoute] Guid guid) 
        {
            var con = _connectionDB.contractors.FirstOrDefault(r => r.Id == guid);
            if (con == null) 
            {
              return NotFound();
            }
            return Ok(con);
        }
    }
}
