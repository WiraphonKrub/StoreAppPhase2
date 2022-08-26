using System;
using StoreAppPhase2.Entities;
using StoreAppPhase2.DbContexts;
using StoreAppPhase2.Services;
using StoreAppPhase2.EntityModels;
using Microsoft.VisualBasic;

namespace StoreAppPhase2.Services
{
    public class DataRepository : IDataReposity
    {

        private readonly DataContext _context;
        public DataRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        //public EmployeesData GetEmployee(int employeeId, int officeId)
        //{
        //    throw new NotImplementedException();
        //}
        //-----------------Start Employees Interface
        public IEnumerable<EmployeesData> GetEmployees()
        {
            return _context.EmployeesDatas.ToList();
        }
        //-----------------End Employees Interface



        //-----------------Start Status Interface

        public bool PostStatusData(StatusItems statusItems)
        {

            var statusItemsList = new List<StatusItems>();

            try
            {
                var addStatus = new StatusItems
                {
                    //SaleEMID = SaleEMID,          
                    //IdEM = saleInvoices.IdEM,
                    //BookingID = bookingServices.BookingID,
                    StatusItemName = statusItems.StatusItemName
                };
                statusItemsList.Add(addStatus);
                _context.StatusItems.AddRange(statusItemsList);
                _context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
        }

        //-----------------End Status Interface



        //-----------------Start Booking Interface
        //Start Post Booking 
        public bool PostBookingEMData(BookingServices bookingServices)
        {

            var BookingEMList = new List<BookingServices>();

            try
            {

                var BookingEMs = new BookingServices
                {
                    //SaleEMID = SaleEMID,          
                    //IdEM = saleInvoices.IdEM,
                    //BookingID = bookingServices.BookingID,
                    BookerName = bookingServices.BookerName,
                    BookingDate = bookingServices.BookingDate,
                    BookingPrices = bookingServices.BookingPrices,
                    DueDate = bookingServices.DueDate,
                    IdEM =  bookingServices.IdEM,
                    StatusItemID = bookingServices.StatusItemID

                };

                BookingEMList.Add(BookingEMs);

                _context.bookingServices.AddRange(BookingEMList);

                _context.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {

                ex.Message.ToString();

                return false;

            }

        }
        //End Post Booking All

        //-----------------End Booking Interface


        //-----------------Start Sale Interface
        //Start Get Sale All
        public IEnumerable<SaleInvoices> GetSaleInvoicesEMDatas()
        {
            return _context.SaleInvoices.ToList();
        }
        //End Get Sale All
    
        //Start Get Sale
        public IEnumerable<SaleInvoices> GetSaleInvoicesEMData(SaleInvoices saleInvoices)
        {
            return _context.SaleInvoices.Where(x=>x.SaleInvoiceID == saleInvoices.SaleInvoiceID);
        }
        //End Get Sale

        //Start Post Sale 
        public bool PostSaleInvoicesEMData(SaleInvoices saleInvoices)
        {

            var SallingEMList = new List<SaleInvoices>();

            try {

                var SallingEMs = new SaleInvoices
                {
                    //SaleEMID = SaleEMID,          
                    //IdEM = saleInvoices.IdEM,
                    StatusSaleID = saleInvoices.StatusSaleID,
                    BookingID = saleInvoices.BookingID

                };

            SallingEMList.Add(SallingEMs);

            _context.SaleInvoices.AddRange(SallingEMList);

            _context.SaveChanges();

            return true;

            }
            catch(Exception ex) {

                ex.Message.ToString();
               
             return false;

            }

        }
        //End Post Sale All


        //Start Delete Sale
        public IEnumerable<SaleInvoices> DeleteSaleInvoicesEMData(SaleInvoices saleInvoices)
        {
            // Create new entities from Entities
            using (_context)
            {
                // Delete SaleEM
                var del = _context.SaleInvoices.Where(o => o.SaleInvoiceID == saleInvoices.SaleInvoiceID).ToList();

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
        //End Delete Sale

        //Start Update Sale
        public bool PutSaleInvoicesEMData(SaleInvoices saleInvoice)
        {

            // Create new entities from Entities
            using (_context)
            {
                // Update Statement
                var update = _context.SaleInvoices.Where(o => o.SaleInvoiceID == saleInvoice.SaleInvoiceID).ToList();
                if (update.Count() > 0)
                {
                    // Loop update
                   
                    //update.ForEach(o => o.BookingID = saleInvoice.BookingID);
                    update.ForEach(o => o.StatusSaleID = saleInvoice.StatusSaleID);
                    _context.SaveChanges();
                }
                else
                {
                    return false;
                }

                return true;
            }
        }
        //End Update Sale

//-----------------End Sale Interface




    }
}

