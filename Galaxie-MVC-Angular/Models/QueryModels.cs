﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//test
namespace Galaxie_MVC_Angular.Models
{

    public class Products
    {
        public string UPC { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public Decimal Cost { get; set; }
    }

    public class PagedList
    {
        public IList Content { get; set; }

        public Int32 CurrentPage { get; set; }
        public Int32 PageSize { get; set; }
        public int TotalRecords { get; set; }

        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalRecords / PageSize); }
        }
    } 

}