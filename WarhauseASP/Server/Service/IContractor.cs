using Microsoft.AspNetCore.Mvc;
using WarhauseASP.Shared;

namespace WarhauseASP.Server.Service
{
    public interface IContractor
    {
        ActionResult EditContractor(Contractors contractors);
        ActionResult DeleteContractor(Guid IdContractor);
        Contractors GetId([FromRoute] Guid guid);
        List<Contractors> GetAllContrectors();
    }
}
