using System;
using StoreAppPhase2.Entities;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.Services
{
	public interface IDataReposity
	{

        IEnumerable<EmployeesData> GetEmployees();

        //Salling
        IEnumerable<SaleInvoices> GetSellingEMDatas();

        IEnumerable<SaleInvoices> GetSellingEMData(int SellingEMID);

        IEnumerable<SaleInvoices> DeleteSellingEMData(int SellingEMID);

        public bool PutSellingEMData(SaleInvoices saleInvoice);

        public bool PostSellingEMData(SaleInvoices saleInvoice);
    }
}

