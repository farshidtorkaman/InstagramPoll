using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramPoll.Models
{
    public class ReportViewModel
    {
        public int CommentsCount { get; set; }
        public int LikesCount { get; set; }
        public string MediaId { get; set; }
    }
}
