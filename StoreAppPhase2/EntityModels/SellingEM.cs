using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StoreAppPhase2.Entities;

namespace StoreAppPhase2.EntityModels
{
	public class SellingEM
    {
        [Key]
        public int SellingEMID { get; set; }
		public int InvoiceID { get; set; }
        public string? StatusSellingEM { get; set; }

        [ForeignKey("IdEM")]
        public Employees? employees { get; set; }
        public int IdEM { get; set; }

    }
}

