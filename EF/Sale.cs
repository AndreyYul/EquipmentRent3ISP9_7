//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EquipmentRent3ISP9_7.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int IdSale { get; set; }
        public int IdClient { get; set; }
        public int IdProduct { get; set; }
        public int IdEmployee { get; set; }
        public System.DateTime SaleDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Product Product { get; set; }
    }
}
