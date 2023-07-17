using Microsoft.AspNetCore.Mvc;
using WarhauseASP.Server.DB;
using WarhauseASP.Shared;

namespace WarhauseASP.Server.Service
{
    public class Contractor : IContractor
    {
        private readonly ConnectionDB _connectionDB;

        public Contractor(ConnectionDB connectionDB)
        {
            _connectionDB = connectionDB;
        }

        public string DeleteContractor(Guid IdContractor)
        {
            var del = _connectionDB.contractors.Find(IdContractor);
            if (del != null)
            {
                _connectionDB.contractors.Remove(del);
                _connectionDB.SaveChanges();
                return($"Contractor was been deleted ! {del.Name}");
            }
            return ("No user deleted !");
        }


        public Contractors? EditContractor(Contractors contractors)
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
                return EditContra;
        }

        public List<Contractors> GetAllContrectors()
        {
            var con = _connectionDB.contractors.ToList();
            if (con == null)
            {
                return con;
            }
            return con;
        }

        public Contractors GetId([FromRoute] Guid guid)
        {
            var con = _connectionDB.contractors.FirstOrDefault(r => r.Id == guid);
            if (con == null)
            {
                return con;
            }
            return con;
        }
    }
}
