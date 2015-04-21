using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Galaxie_MVC_Angular
{


    [MetadataType(typeof(ItemValidation))]
    public partial class tblItem { }

    public class ItemValidation
    {
        [Required(ErrorMessage = "Name is required")]
        public string ItemUPC { get; set; }


    }

}