using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week15_MVCProjectTestSite_04182016.Models
{
    public class ChildTop
    {
        private string item;
        private string nickname;
        private string season;

        [Key]
        public string TopID { get; set; }

        public string Item { get; set; }
        public string Nickname { get; set; }
        public string Season { get; set; }

    }
}