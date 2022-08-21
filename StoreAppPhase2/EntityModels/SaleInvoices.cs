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
  

        [ForeignKey("StatusSaleID")]
        public StatusForSale? statusForSale { get; set; }
        public int StatusSaleID { get; set; }

        [ForeignKey("BookingID")]
        public BookingServices? bookingServices { get; set; }
        public int BookingID { get; set; }

    }
}

