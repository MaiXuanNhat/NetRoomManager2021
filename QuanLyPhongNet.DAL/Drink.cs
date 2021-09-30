//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyPhongNet.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drink
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drink()
        {
            this.OrderDrinks = new HashSet<OrderDrink>();
        }
    
        public int DrinkID { get; set; }
        public string DrinkName { get; set; }
        public string CategoryName { get; set; }
        public Nullable<double> PriceUnit { get; set; }
        public string UnitLot { get; set; }
        public Nullable<int> InventoryNumber { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDrink> OrderDrinks { get; set; }
    }
}
