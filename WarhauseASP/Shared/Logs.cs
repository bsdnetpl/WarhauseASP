using System.ComponentModel.DataAnnotations;

namespace WarhauseASP.Shared
{
    public class Logs
    {
        [Key]
        public int Id { set; get; }
        public DateTime CreatedOn { set; get; }
        public string? Level { set; get; }
        public string? Message { set; get; }
        public string? StackTrace { set; get; }
        public string? Exception { set; get; }
        public string? Logger { set; get; }
        public string? Url { set; get; }
    }
}
