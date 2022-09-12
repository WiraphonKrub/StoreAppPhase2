using System;
using StoreAppPhase2.Entities;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.Services
{
	public interface IDataReposity
	{

        

        //Sale
        IEnumerable<SaleInvoices> GetSaleInvoicesEMDatas();

        IEnumerable<SaleInvoices> GetSaleInvoicesEMData(SaleInvoices saleInvoice);

        IEnumerable<SaleInvoices> DeleteSaleInvoicesEMData(SaleInvoices saleInvoice);

        public bool PutSaleInvoicesEMData(SaleInvoices saleInvoice);

        public bool PostSaleInvoicesEMData(SaleInvoices saleInvoice);


        //Booking
        public bool PostBookingEMData(BookingServices bookingServices);

        //Employee
        IEnumerable<EmployeesData> GetEmployees();
        public bool PostEmployeeData(EmployeesData[] employeesDatas);

        //Status
        IEnumerable<StatusItems> GetStatusItems();
        public bool PostStatusData(StatusItems[] statusItems);
        public bool PostStatusForsaleData(StatusForSale statusForSale);
        IEnumerable<StatusItems> DeleteStatusData(StatusItems[] statusItems);

    }
}

