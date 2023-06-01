using System;
using System.IO;
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
            if(string.IsNullOrEmpty(idUser.ToString()))
            {
                throw new IOException("No user in DB");
            }

            fileAuthKey.UserId = idUser;
            fileAuthKey.FileKeyAuth = Guid.NewGuid();
            fileAuthKey.countDownload = count;
            _connectionDB.Add(fileAuthKey);
            _connectionDB.SaveChanges();
        }

        public void GetFileXmlBig(string Link, Guid idUser, Guid AuthKey, string LocalDir) 
        {
            var userId = _connectionDB.fileAuthKeys.FirstOrDefault(p => p.UserId == idUser);
          if(userId == null)
            {
                throw new IOException("No user in DB");
            }
          var keyAuth = _connectionDB.fileAuthKeys.FirstOrDefault(p => p.FileKeyAuth == AuthKey);
            if(keyAuth == null)
            {
                throw new IOException("Wrong key !");
            }

            using ( System.Net.WebClient net = new System.Net.WebClient())
          {
                net.DownloadFile(Link, LocalDir);
           }
        }
    }
}
