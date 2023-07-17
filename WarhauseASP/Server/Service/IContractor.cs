using Microsoft.AspNetCore.Mvc;
using WarhauseASP.Shared;

namespace WarhauseASP.Server.Service
{
    public interface IContractor
    {
        Contractors? EditContractor(Contractors contractors);
        string DeleteContractor(Guid IdContractor);
        Contractors GetId([FromRoute] Guid guid);
        List<Contractors> GetAllContrectors();
    }
}
