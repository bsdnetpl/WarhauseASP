using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhauseASP.Shared
{
    public class FileAuthKey
    {
        public int id { set; get; }
        public Guid FileKeyAuth {set; get;}
        public Guid UserId { set; get; }
        public DateTime dateTime { set; get; }
        public int countDownload { set; get; }
    }
}
