using System;
using System.ComponentModel.DataAnnotations;

namespace StoreAppPhase2.EntityModels
{
	public class EmployeesData
	{
        [Key]
        public int IdEm { get; set; }
        [MaxLength(50)]
        public string? FirstNameEm { get; set; }
        [MaxLength(50)]
        public string? LastNameEm { get; set; }

        public Decimal SalaryEm { get; set; }

        [MaxLength(100)]
        public string? AddressEm { get; set; }
        [MaxLength(15)]
        public int RangeWorkingEm { get; set; }

        

        public ICollection<BookingServices> BookingServices { get; set; }
        = new List<BookingServices>();
    }
}

