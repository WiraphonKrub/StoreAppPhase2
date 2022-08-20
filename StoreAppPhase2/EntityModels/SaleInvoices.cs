using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StoreAppPhase2.Entities;

namespace StoreAppPhase2.EntityModels
{
    public class SaleInvoices
    {
        [Key]
        public int SaleInvoiceID { get; set; }
        public int InvoiceNo { get; set; }

        [ForeignKey("StatusItemID")]
        public StatusItems? statusItems { get; set; }
        public int StatusItemID { get; set; }

        [ForeignKey("IdEM")]
        public EmployeesData? employeesData { get; set; }
        public int IdEM { get; set; }


        public ICollection<BookingServices> BookingServices { get; set; }
           = new List<BookingServices>();
    }
}

