//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorks.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class vPersonDemographic
    {
        public int BusinessEntityID { get; set; }
        public Nullable<decimal> TotalPurchaseYTD { get; set; }
        public Nullable<System.DateTime> DateFirstPurchase { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string YearlyIncome { get; set; }
        public string Gender { get; set; }
        public Nullable<int> TotalChildren { get; set; }
        public Nullable<int> NumberChildrenAtHome { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public Nullable<bool> HomeOwnerFlag { get; set; }
        public Nullable<int> NumberCarsOwned { get; set; }
    }
}