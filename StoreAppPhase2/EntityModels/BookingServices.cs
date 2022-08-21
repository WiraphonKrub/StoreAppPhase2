using System;
using System.ComponentModel.DataAnnotations;
using StoreAppPhase2.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAppPhase2.EntityModels
{
    public class BookingServices
    {
        [Key]
        public int BookingID { get; set; }
        [MaxLength(50)]
        public string? BookerName { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BookingDate { get; set; }
     
        public int BookingPrices { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }

        [ForeignKey("IdEM")]
        public EmployeesData? employeesData { get; set; }
        public int IdEM { get; set; }

        [ForeignKey("StatusItemID")]
        public StatusItems? statusItems { get; set; }
        public int StatusItemID { get; set; }

        public ICollection<SaleInvoices> saleInvoices { get; set; }
          = new List<SaleInvoices>();

    }
}

