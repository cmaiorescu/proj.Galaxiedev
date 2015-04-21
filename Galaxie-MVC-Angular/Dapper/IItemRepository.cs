using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Galaxie_MVC_Angular.Dapper
{
    public interface IItemRepository
    {
        IQueryable<tblItem> GetAllItems(string searchtext);
        IQueryable<tblItem> GetItemByPage(string searchtext, int page = 1, int pageSize = 10, string sortBy = "CustomerID", string sortDirection = "asc");

    }

}