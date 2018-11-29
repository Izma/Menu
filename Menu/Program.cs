using Menu.Data;
using Menu.Models;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataBase db = new DataBase();
            var menuList = from menu in db.GetMenu()
                         where menu.SubMenuId == null
                         select new MenuNestedModel
                         {
                             MenuId = menu.MenuId,
                             Description = menu.Description,
                             ChildMenu = (from child in db.GetMenu()
                                          where child.SubMenuId == menu.MenuId
                                          select child).ToList()
                         };
            Console.Write(JsonConvert.SerializeObject(menuList, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            Console.ReadKey();
            // Here, you can to apply a forEach and question, if length ChildMenu is different of 0, do something...!
            // foreach (MenuNestedModel item in menuList)
            // {
            //    if (item.ChildMenu.Count > 0)
            //    {
            //        // do something...!
            //    }
            // }
        }
    }
}
