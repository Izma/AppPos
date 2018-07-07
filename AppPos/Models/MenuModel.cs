using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppPos.Models
{
    public class MenuModel
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int Order { get; set; }
        public string Status { get; set; }
        public string Url { get; set; }
        public int UserId { get; set; }
    }
}