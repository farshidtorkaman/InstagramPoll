using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramPoll.Models
{
    public class CommentViewModel
    {
        public long PK { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
    }
}
