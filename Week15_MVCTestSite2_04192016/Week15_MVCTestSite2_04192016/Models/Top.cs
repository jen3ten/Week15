using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week15_MVCTestSite2_04192016.Models
{
    public class Top
    {

        private string item;
        private string nickname;
        private string season;

        [Key]
        public int TopID { get; set; }

        public string Item { get; set; }
        public string Nickname { get; set; }
        public string Season { get; set; }

    }
}