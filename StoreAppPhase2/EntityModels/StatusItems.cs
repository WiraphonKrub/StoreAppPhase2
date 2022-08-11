using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StoreAppPhase2.Entities;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.Entities;

public class StatusItems
{

    [Key]
    public int StatusItemID { get; set; }
    [MaxLength(50)]
    public string? StatusItemName { get; set; }


    public ICollection<SaleInvoices> saleInvoices { get; set; }
           = new List<SaleInvoices>();
}
