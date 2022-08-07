using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StoreAppPhase2.Entities;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.Entities;
public class Employees
{
    [Key]
    public int IdEm { get; set; }
    [MaxLength(50)]
    public string FirstNameEm { get; set; }
    [MaxLength(50)]
    public string LastNameEm { get; set; }

    public Decimal SalaryEm { get; set; }
   
    [MaxLength(100)]
    public string AddressEm { get; set; }
    [MaxLength(15)]
    public int RangeWorkingEm { get; set; }

    public ICollection<SellingEM> SellingEMs { get; set; }
           = new List<SellingEM>();
}
