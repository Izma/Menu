using Dapper;
using Menu.Util;
using System.Data.SqlClient;
using System.Linq;
using Menu.Models;

namespace Menu.Data
{
    public class DataBase : IDataBase
    {
        public IQueryable<MenuModel> GetMenu()
        {
            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var result = connection.Query<MenuModel>(sql: "SELECT * FROM [dbo].[Menu]", param: null, commandType: System.Data.CommandType.Text);
                return result.AsQueryable();
            }
        }
    }
}
