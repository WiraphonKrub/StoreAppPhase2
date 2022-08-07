using System;
using StoreAppPhase2.Entities;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.Services
{
	public interface IDataReposity
	{

        IEnumerable<Employees> GetEmployees();

        //Salling
        IEnumerable<SellingEM> GetSellingEMDatas();

        IEnumerable<SellingEM> GetSellingEMData(int SellingEMID);

        IEnumerable<SellingEM> DeleteSellingEMData(int SellingEMID);

        public bool PutSellingEMData(int sellingEMID, int invoiceID, int IdEM, string statusSellingEM);

        public bool PostSellingEMData(int invoiceID, int IdEM, string statusSellingEM);
    }
}

