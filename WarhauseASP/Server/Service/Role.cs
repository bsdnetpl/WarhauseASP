using WarhauseASP.Server.DB;
using WarhauseASP.Shared;

namespace WarhauseASP.Server.Service
{
    public class Role : IRole
    {
        private readonly ConnectionDB _connection;

        public Role(ConnectionDB connection)
        {
            _connection = connection;
        }
        public int AddRole(Guid UserId, string role)
        {
     

            var UR = _connection.roles.Find(UserId);
            if (UR == null)
            {
                Shared.Role roles = new Shared.Role();
                roles.UserId = UserId;
                roles.RoleId = role;
                _connection.roles.AddAsync(roles);
                _connection.SaveChangesAsync();
                return 1;

            }
            return 0;
        }
    }
}
