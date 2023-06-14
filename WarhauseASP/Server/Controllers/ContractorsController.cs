using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult DeleteContractor(Guid IdContractor)
        {
            var del = _connectionDB.contractors.Find(IdContractor);
            if (del != null)
            {
                _connectionDB.contractors.Remove(del);
                _connectionDB.SaveChanges();
                return Ok($"Contractor was been deleted ! {del.Name}");
            }
            return NotFound();
        }
        [HttpPut("EditContractor")]
        public ActionResult EditContractor(Contractors contractors)
        {
            if (contractors is not null)
            {
                Contractors EditContra = new Contractors();
                EditContra.Name = contractors.Name;
                EditContra.Street = contractors.Street;
                EditContra.Recipient = contractors.Recipient;
                EditContra.Phone = contractors.Phone;
                EditContra.City = contractors.City;
                EditContra.Country = contractors.Country;
                EditContra.NIP = contractors.NIP;
                EditContra.Representative = contractors.Representative;
                _connectionDB.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
