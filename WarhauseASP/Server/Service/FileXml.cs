using WarhauseASP.Server.Controllers;
using WarhauseASP.Server.DB;
using WarhauseASP.Shared;

namespace WarhauseASP.Server.Service
{

    public class FileXml : IFileXml
    {
        private readonly ConnectionDB _connectionDB;

        public FileXml(ConnectionDB connectionDB)
        {
            _connectionDB = connectionDB;
        }

        public void AddPrivilageToAccesGetFile(Guid idUser, int count)
        {
            FileAuthKey fileAuthKey = new FileAuthKey();
            if(idUser == null)
            {

            }

            fileAuthKey.UserId = idUser;
            fileAuthKey.FileKeyAuth = Guid.NewGuid();
            fileAuthKey.countDownload = count;
            _connectionDB.Add(fileAuthKey);
            _connectionDB.SaveChanges();
        }

        public void GetFileXmlBig(string Link, Guid idUser, Guid AuthKey, string filename)
        {
            System.Net.WebClient net = new System.Net.WebClient();
         
            throw new NotImplementedException();
        }
    }
}
