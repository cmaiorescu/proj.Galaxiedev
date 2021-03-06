//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Galaxie_MVC_Angular
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblItem
    {
        public tblItem()
        {
            this.tblItemCost = new HashSet<tblItemCost>();
            this.tblItemDetail = new HashSet<tblItemDetail>();
            this.tblItemPrice = new HashSet<tblItemPrice>();
            this.tblItemPriceDetail = new HashSet<tblItemPriceDetail>();
        }
    
        public int ItemID { get; set; }
        public string ItemUPC { get; set; }
        public bool UPCMandatory { get; set; }
        public int UPCOrder { get; set; }
        public string ItemSKU { get; set; }
        public bool SKUMandatory { get; set; }
        public int SKUOrder { get; set; }
        public string ItemEAN { get; set; }
        public bool EANMandatory { get; set; }
        public int EANOrder { get; set; }
        public string ItemISBN { get; set; }
        public bool ISBNMandatory { get; set; }
        public int ISBNOrder { get; set; }
        public string ItemSN { get; set; }
        public bool SNMandatory { get; set; }
        public int SNOrder { get; set; }
        public string ItemDescription { get; set; }
        public string SdpCode { get; set; }
        public byte[] ItemImage { get; set; }
        public Nullable<double> ItemWeight { get; set; }
        public Nullable<double> ItemLength { get; set; }
        public Nullable<System.DateTime> ItemDateAdd { get; set; }
        public Nullable<System.DateTime> ItemDateChg { get; set; }
    
        public virtual ICollection<tblItemCost> tblItemCost { get; set; }
        public virtual ICollection<tblItemDetail> tblItemDetail { get; set; }
        public virtual ICollection<tblItemPrice> tblItemPrice { get; set; }
        public virtual ICollection<tblItemPriceDetail> tblItemPriceDetail { get; set; }
        public virtual tblSdp tblSdp { get; set; }
    }
}
