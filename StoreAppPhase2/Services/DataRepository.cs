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

        public Employees GetEmployee(int employeeId, int officeId)
        {
            throw new NotImplementedException();
        }



//-----------------Start Employees Interface
        public IEnumerable<Employees> GetEmployees()
        {
            return _context.Employees.ToList();
        }
//-----------------End Employees Interface


//-----------------Start Selling Interface

        //Start Get Selling All
        public IEnumerable<SellingEM> GetSellingEMDatas()
        {
            return _context.SellingEM.ToList();
        }
        //End Get Selling All
    
        //Start Get Selling
        public IEnumerable<SellingEM> GetSellingEMData(int SellingEMID)
        {
            return _context.SellingEM.Where(x=>x.SellingEMID == SellingEMID);
        }
        //End Get Selling

        //Start Post Selling 
        public bool PostSellingEMData(int invoiceID, int IdEM, string statusSellingEM)
        {

            var SellingEMList = new List<SellingEM>();

            try {

                var SellingEMs = new SellingEM
                {
                    //SellingEMID = SellingEMID,
                    InvoiceID = invoiceID,
                    IdEM = IdEM,
                    StatusSellingEM = statusSellingEM
                };

            SellingEMList.Add(SellingEMs);

            _context.SellingEM.AddRange(SellingEMList);

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
        public IEnumerable<SellingEM> DeleteSellingEMData(int Id)
        {
            // Create new entities from Entities
            using (_context)
            {
                // Delete SellingEM
                var del = _context.SellingEM.Where(o => o.SellingEMID == Id).ToList();

                if (del.Count() > 0)
                {
                    // Loop Delete
                    foreach (var item in del)
                    {
                        _context.SellingEM.Remove(item);
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
        public bool PutSellingEMData(int sellingEMID, int invoiceID, int IdEM, string statusSellingEM)
        {

            // Create new entities from Entities
            using (_context)
            {
                // Update Statement
                var update = _context.SellingEM.Where(o => o.SellingEMID == sellingEMID).ToList();
                if (update.Count() > 0)
                {
                    // Loop update
                    update.ForEach(o => o.InvoiceID = invoiceID);
                    update.ForEach(o => o.IdEM = IdEM);
                    update.ForEach(o => o.StatusSellingEM = statusSellingEM);
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

