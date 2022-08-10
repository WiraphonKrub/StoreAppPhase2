using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StoreAppPhase2.Entities;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.Entities;

public class StatusItem
{ 

    [Key]
    public string? StatusItemID { get; set; }
    [MaxLength(50)]
    public string? StatusItemName { get; set; }
   

    public ICollection<SaleInvoice> saleInvoices { get; set; }
           = new List<SaleInvoice>();
}
