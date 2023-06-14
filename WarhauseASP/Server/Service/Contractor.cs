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

        public ActionResult DeleteContractor(Guid IdContractor)
        {
            throw new NotImplementedException();
        }


        public ActionResult EditContractor(Contractors contractors)
        {
            throw new NotImplementedException();
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
