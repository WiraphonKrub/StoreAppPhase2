using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StoreAppPhase2.Entities;

namespace StoreAppPhase2.EntityModels
{
    public class SaleInvoice
    {
        [Key]
        public int SaleInvoiceID { get; set; }
        public int InvoiceNo { get; set; }

        [ForeignKey("StatusItemID")]
        public StatusItem? statusItem { get; set; }
        public string? StatusItemID { get; set; }

        [ForeignKey("IdEM")]
        public EmployeesData? employeesData { get; set; }
        public int IdEM { get; set; }

    }
}

