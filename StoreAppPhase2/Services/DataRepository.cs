using System;
using StoreAppPhase2.Entities;
using StoreAppPhase2.DbContexts;
using StoreAppPhase2.Services;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.Services
{
    public class DataRepository : IDataReposity
    {

        private readonly DataContext _context;
        public DataRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public EmployeesData GetEmployee(int employeeId, int officeId)
        {
            throw new NotImplementedException();
        }



//-----------------Start Employees Interface
        public IEnumerable<EmployeesData> GetEmployees()
        {
            return _context.EmployeesDatas.ToList();
        }
//-----------------End Employees Interface


//-----------------Start Selling Interface

        //Start Get Selling All
        public IEnumerable<SaleInvoice> GetSellingEMDatas()
        {
            return _context.SaleInvoices.ToList();
        }
        //End Get Selling All
    
        //Start Get Selling
        public IEnumerable<SaleInvoice> GetSellingEMData(int SaleInvoiceID)
        {
            return _context.SaleInvoices.Where(x=>x.SaleInvoiceID == SaleInvoiceID);
        }
        //End Get Selling

        //Start Post Selling 
        public bool PostSellingEMData(int InvoiceNo, int IdEM, string? StatusItemID)
        {

            var SellingEMList = new List<SaleInvoice>();

            try {

                var SellingEMs = new SaleInvoice
                {
                    //SellingEMID = SellingEMID,
                    InvoiceNo  = InvoiceNo,
                    IdEM = IdEM,
                    StatusItemID = StatusItemID
                };

            SellingEMList.Add(SellingEMs);

            _context.SaleInvoices.AddRange(SellingEMList);

            _context.SaveChanges();

            return true;

            }
            catch(Exception ex) {

                ex.Message.ToString();
               
             return false;

            }

        }
        //End Post Selling All


        //Start Delete Selling
        public IEnumerable<SaleInvoice> DeleteSellingEMData(int Id)
        {
            // Create new entities from Entities
            using (_context)
            {
                // Delete SellingEM
                var del = _context.SaleInvoices.Where(o => o.SaleInvoiceID == Id).ToList();

                if (del.Count() > 0)
                {
                    // Loop Delete
                    foreach (var item in del)
                    {
                        _context.SaleInvoices.Remove(item);
                    }
                    _context.SaveChanges();
                }
                else
                { return del;}
                return del;
            }
        }
        //End Delete Selling

        //Start Update Selling
        public bool PutSellingEMData(int SaleInvoiceID, int invoiceID, int IdEM, string? statusSellingEM)
        {

            // Create new entities from Entities
            using (_context)
            {
                // Update Statement
                var update = _context.SaleInvoices.Where(o => o.SaleInvoiceID == SaleInvoiceID).ToList();
                if (update.Count() > 0)
                {
                    // Loop update
                    update.ForEach(o => o.InvoiceNo = invoiceID);
                    update.ForEach(o => o.IdEM = IdEM);
                    update.ForEach(o => o.StatusItemID = statusSellingEM);
                    _context.SaveChanges();
                }
                else
                {
                    return false;
                }

                return true;
            }
        }
        //End Update Selling

//-----------------End Selling Interface




    }
}

