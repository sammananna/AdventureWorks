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
    
    public partial class vWorkOrderRouting
    {
        public Nullable<long> ID { get; set; }
        public int WorkOrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductNumber { get; set; }
        public string ProductName { get; set; }
        public short OperationSequence { get; set; }
        public short LocationID { get; set; }
        public string Name { get; set; }
        public System.DateTime ScheduledStartDate { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public System.DateTime ScheduledEndDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public Nullable<decimal> ActualResourceHrs { get; set; }
        public decimal PlannedCost { get; set; }
        public Nullable<decimal> ActualCost { get; set; }
        public int OrderQty { get; set; }
        public short ScrappedQty { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<short> ScrapReasonID { get; set; }
        public string ScrapReason { get; set; }
    }
}
