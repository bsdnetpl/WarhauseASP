using AutoMapper;
using Microsoft.AspNetCore.Identity;
using WarehouseASP.Server.DB;
using WarhauseASP.Server.Controllers;
using WarhauseASP.Server.DB;
using WarhauseASP.Shared;

namespace WarhauseASP.Server.Service
{
    public class WarhauseService : IWarhauseService
    {
        private readonly IMapper _mapper;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly ConnectionDB _connectionDB;
        private readonly ConnectionMysql _dbContextMy;
        private readonly ILogger<State> _logger;

        public WarhauseService(IMapper mapper, IPasswordHasher<User> passwordHasher , ConnectionDB connectionDB, ConnectionMysql dbContextMy, ILogger<State>? logger)
        {
            _mapper = mapper;
            _passwordHasher = passwordHasher;
            _connectionDB = connectionDB;
            _dbContextMy = dbContextMy;
            _logger = logger;
        }

        public void DeleteProduct(Guid guid)
        {
            var delProd = _connectionDB.States.Find(guid);
            _connectionDB.States.Remove(delProd);
            _connectionDB.SaveChanges();
        }

        public State EditState(StateDto stateDto, Guid guid)
        {
            var result = _connectionDB.States.Find(guid);


            //result = _mapper.Map<State>(stateDto);
            result.Id = guid;
            result.GTU = stateDto.GTU;
            result.Name = stateDto.Name;
            result.EAN = stateDto.EAN;
            result.TaxVat = stateDto.TaxVat;
            result.DifferendVatTax = stateDto.DifferendVatTax;
            result.CodProduct = stateDto.CodProduct;
            result.PurchasePriceNetto = stateDto.PurchasePriceNetto;
            result.Description = stateDto.Description;
            result.CourseUsd = stateDto.CourseUsd;
            result.CourseEuro = stateDto.CourseEuro;
            result.Profit = stateDto.Profit;
            result.Daty_Bay = stateDto.Daty_Bay;
            result.Quantity = stateDto.Quantity;

            _connectionDB.SaveChanges();
            return result;
        }

        public List<Logs>? GetLogs(int getline)
        {
            if (getline == 0)
            {
                getline = 150;
            }

            _logger.LogError(new Exception(), "This is an error message");
            var logs = _connectionDB.Logs.OrderByDescending(x => x.CreatedOn).Take(getline).ToList();
            if (logs is null)
            {
                return logs;
            }
            return logs;
        }

        public Sell Sell(Guid guid, double Quantity)
        {
            Sell sell = new Sell();
            var result = _connectionDB.States.Find(guid);
            sell.Name = result.Name;
            sell.EAN = result.EAN;
            sell.Profit = result.Profit;
            sell.Quantity = Quantity;
            sell.SellePriceBrutto = result.SellePriceBrutto;
            sell.GTU = result.GTU;
            sell.dateTimeSell = DateTime.Now;
            sell.PurchasePriceNetto = result.PurchasePriceNetto;
            sell.Id = Guid.NewGuid();
            _connectionDB.Sells.Add(sell);
            result.Quantity = result.Quantity - Quantity;
            _connectionDB.SaveChanges();
            return sell;
        }

        public List<stan>? SetState()
        {
            State state;
            var MyState = _dbContextMy.stan.ToList();
            int nr = 0;
            foreach (var unit in MyState)
            {
                nr++;
                state = _mapper.Map<State>(unit);
                state.Id = Guid.NewGuid();
                state.EAN = Convert.ToString(nr);
                _connectionDB.States.Add(state);
                _connectionDB.SaveChanges();
            }

            return MyState;
        }
    }
}
