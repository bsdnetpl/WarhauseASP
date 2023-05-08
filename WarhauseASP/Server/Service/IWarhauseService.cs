using WarhauseASP.Shared;

namespace WarhauseASP.Server.Controllers
{
    public interface IWarhauseService
    {
        List<Logs>? GetLogs(int getline);
        Sell Sell(Guid guid, double Quantity);
        State EditState(StateDto stateDto, Guid guid);
        void DeleteProduct(Guid guid);
        List<stan>? SetState();
    }
}
