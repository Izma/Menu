using System.Collections.Generic;

namespace Menu.Models
{
    public class MenuNestedModel
    {
        public int MenuId { get; set; }
        public string Description { get; set; }
        public List<MenuModel> ChildMenu { get; set; }
    }
}
