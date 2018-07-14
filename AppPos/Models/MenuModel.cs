using System.Collections.Generic;

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
        public string Icon { get; set; }
        public List<MenuModel> MenuChild { get; set; }
    }
}