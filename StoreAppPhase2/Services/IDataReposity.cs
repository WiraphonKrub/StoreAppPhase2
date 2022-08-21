﻿using System;
using StoreAppPhase2.Entities;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.Services
{
	public interface IDataReposity
	{

        IEnumerable<EmployeesData> GetEmployees();

        //Salling
        IEnumerable<SaleInvoices> GetSaleInvoicesEMDatas();

        IEnumerable<SaleInvoices> GetSaleInvoicesEMData(SaleInvoices saleInvoice);

        IEnumerable<SaleInvoices> DeleteSaleInvoicesEMData(SaleInvoices saleInvoice);

        public bool PutSaleInvoicesEMData(SaleInvoices saleInvoice);

        public bool PostSaleInvoicesEMData(SaleInvoices saleInvoice);
    }
}

