using System;
using StoreAppPhase2.Entities;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.Services
{
	public interface IDataReposity
	{

        IEnumerable<EmployeesData> GetEmployees();

        //Salling
        IEnumerable<SaleInvoice> GetSellingEMDatas();

        IEnumerable<SaleInvoice> GetSellingEMData(int SellingEMID);

        IEnumerable<SaleInvoice> DeleteSellingEMData(int SellingEMID);

        public bool PutSellingEMData(int sellingEMID, int invoiceID, int IdEM, string? statusSellingEM);

        public bool PostSellingEMData(int invoiceID, int IdEM, string? statusSellingEM);
    }
}

