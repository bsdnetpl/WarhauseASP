using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WarehouseASP.Server.DB;
using WarhauseASP.Server.DB;
using WarhauseASP.Shared;

namespace WarhauseASP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarhauseController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ConnectionDB _connectionDB;
        private readonly ConnectionMysql _dbContextMy;
        private readonly ILogger<State> _logger;
        private readonly IWarhauseService _userService;
        public WarhauseController(IMapper mapper, ConnectionDB connectionDB, ConnectionMysql dbContextMy, ILogger<State> logger, IWarhauseService userService)
        {
            _mapper = mapper;
            _connectionDB = connectionDB;
            _dbContextMy = dbContextMy;
            _logger = logger;
            _userService = userService;
        }
        [HttpPost("SetState")]
        public async Task<IActionResult> SetState()
        {
            var MyState = _userService.SetState();
            return Ok(MyState);
        }
        [HttpGet("State")]
        public async Task<IActionResult> GetState()
        {
            var state = _connectionDB.States.OrderBy(x => x.Name).ToList();
            return Ok(state);
        }
        [HttpGet("StateSeek")]
        public async Task<ActionResult<List<State>>> SeekStata(string name)
        {
            _logger.LogWarning($"Wyszukiwany produkt {name}");
            _logger.LogDebug("This is a debug message");
            _logger.LogInformation("This is an info message");
            _logger.LogWarning("This is a warning message ");
            _logger.LogError(new Exception(), "This is an error message");

            var seek = _connectionDB.States.Where(p => p.Name.Contains(name)).ToList();//Where(x => EF.Functions.Like(x.Name, "%"+name+"%")).ToList();
            return Ok(seek);
        }

        [HttpGet("StateSeekById")]
        public async Task<ActionResult<List<State>>> SeekStata(Guid id)
        {


            var seek = _connectionDB.States.Find(id);//Where(x => EF.Functions.Like(x.Name, "%"+name+"%")).ToList();
            return Ok(seek);
        }
        [HttpGet("Logs")]
        public IActionResult GetLogs(int getline)
        {
            var logs = _userService.GetLogs(getline);
            return Ok(logs);
        }
        [HttpDelete("DeletetProduct")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProduct(Guid guid)
        {
            _logger.LogDebug("This is a debug message");
            _logger.LogInformation("This is an info message");
            _logger.LogWarning("This is a warning message ");
            _logger.LogError(new Exception(), "This is an error message");

          
                var delProd = await _connectionDB.States.FindAsync(guid);

                if (delProd != null)
                {
                    _userService.DeleteProduct(guid);
                    return Ok($"Was been deleted {delProd.Name}");
                }
                return Ok($"No product in DB: {delProd.Name}");
         }

        [HttpPut("EdityState")]
        public IActionResult EditState(StateDto stateDto, Guid guid)
        {
            var result = _connectionDB.States.Find(guid);
            if (result == null)
            {
                return Ok("No product in DB");
            }
            if (stateDto == null)
            {
                return Ok("Put some date");
            }

            var editVal = _userService.EditState(stateDto, guid);
            return Ok(editVal);
        }
        [HttpPut("Sell")]
        public IActionResult Sell(Guid guid, double Quantity)
        {
            var result = _connectionDB.States.Find(guid);
            if (result == null)
            {
                return Ok("No product in DB");
            }
            if (result.Quantity < 0)
            {
                return Ok("No Quantiti product in DB");
            }
            var sell = _userService.Sell(guid, Quantity);
            return Ok(sell);
        }
        [HttpGet("Sell")]
        public IActionResult GetSell()
        {
            DateTime dateTime = DateTime.Now;
            var sell = _connectionDB.Sells.OrderBy(x => x.dateTimeSell == dateTime).ToList();
            return Ok(sell);
        }

    }
}
