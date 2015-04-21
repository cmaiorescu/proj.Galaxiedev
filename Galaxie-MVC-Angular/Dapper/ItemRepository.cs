using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace Galaxie_MVC_Angular.Dapper
{

    public class ItemRepository : IItemRepository
    {
        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["GalaxieDev2EntitiesDapper"].ConnectionString);

        public IQueryable<tblItem> GetAllItems(string searchtext)
        {
            
            return this._db.Query<tblItem>("SELECT  *  FROM      tblItem  WHERE  (ItemUPC like '%"+searchtext+"%' or ItemDescription like '%"+searchtext+"%')").AsQueryable();
        }

        public IQueryable<tblItem> GetItemByPage(string searchtext, int page = 1, int pageSize = 10, string sortBy = "ItemUPC", string sortDirection = "asc")
        {
            return this._db.Query<tblItem>("SELECT  * FROM    ( SELECT    ROW_NUMBER() OVER ( ORDER BY " + sortBy + " " + sortDirection + "  ) AS RowNum, *  FROM      tblItem where (ItemUPC like '%" + searchtext + "%' or ItemDescription like '%" + searchtext + "%')) AS RowConstrainedResult WHERE   RowNum >= " + ((page - 1) * pageSize + 1) + "  AND RowNum <= " + page * pageSize + "  ORDER BY RowNum").AsQueryable();
        }

    }
}