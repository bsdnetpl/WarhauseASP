using WarhauseASP.Shared;

namespace WarhauseASP.Server.Service
{
    public interface IRole
    {
        int AddRole(Guid UserId, string role);
    }
}
