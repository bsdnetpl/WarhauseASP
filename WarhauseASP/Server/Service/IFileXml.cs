namespace WarhauseASP.Server.Controllers
{
    public interface IFileXml
    {
        void GetFileXmlBig(string Link, Guid idUser, Guid AuthKey, string filename);
        void AddPrivilageToAccesGetFile(Guid idUser, int count);

    }
}
