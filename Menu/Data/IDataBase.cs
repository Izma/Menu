using Menu.Models;
using System.Linq;

namespace Menu.Data
{
    public interface IDataBase
    {
        IQueryable<MenuModel> GetMenu();
    }
}
