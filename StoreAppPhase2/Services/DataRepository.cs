using System;
using StoreAppPhase2.Entities;
using StoreAppPhase2.DbContexts;
using StoreAppPhase2.Services;
using StoreAppPhase2.EntityModels;
using Microsoft.VisualBasic;
using System.Linq;

namespace StoreAppPhase2.Services
{
    public class DataRepository : IDataReposity
    {

        private readonly DataContext _context;
        public DataRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        //-----------------Start Employees Interface
        public IEnumerable<EmployeesData> GetEmployees()
        {
            return _context.EmployeesDatas.ToList();
        }


        public bool PostEmployeeData(EmployeesData[] employeesDatas)
        {

            var EmployeesDataList = new List<EmployeesData>();
            var addEmployeesData = new EmployeesData();
            try
            {
                for (int i = 0; i < employeesDatas.Count(); i++)
                {


                    addEmployeesData = new EmployeesData
                    {
                        //SaleEMID = SaleEMID,          
                        //IdEM = saleInvoices.IdEM,
                        //BookingID = bookingServices.BookingID,
                        FirstNameEm = employeesDatas[i].FirstNameEm,
                        LastNameEm = employeesDatas[i].LastNameEm,
                            AddressEm = employeesDatas[i].AddressEm,
                         RangeWorkingEm = employeesDatas[i].RangeWorkingEm,
                         SalaryEm = employeesDatas[i].SalaryEm
                    };


                    EmployeesDataList.Add(addEmployeesData);
                }


                _context.EmployeesDatas.AddRange(EmployeesDataList);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
        }

        //-----------------End Employees Interface



        //-----------------Start Status Interface

        //Start Get Status
        public IEnumerable<StatusItems> GetStatusItems()
        {
            return _context.StatusItems.ToList();
        }
        //End Get Status

        //Start Delete Status
        public IEnumerable<StatusItems> DeleteStatusData(StatusItems[] statusItems)
        {
            // Create new entities from Entities
            using (_context)
            {
                // Delete status
                for (int i = 0; i < statusItems.Count(); i++)
                {
                    var del = _context.StatusItems.Where(o => o.StatusItemID == statusItems[i].StatusItemID).ToList();

                    if (del.Count() > 0)
                    {
                        // Loop Delete
                        foreach (var item in del)
                        {
                            _context.StatusItems.Remove(item);
                        }
                        _context.SaveChanges();
                    }
                    else
                    { return del; }
                }
                return null;
            }
        }
        public bool PostStatusData(StatusItems[] statusItems)
        {
             
            var statusItemsList = new List<StatusItems>();
            var addStatus = new StatusItems();
            try
            {
                for (int i = 0;i < statusItems.Count();i++ ) {


                    addStatus = new StatusItems
                    {
                        //SaleEMID = SaleEMID,          
                        //IdEM = saleInvoices.IdEM,
                        //BookingID = bookingServices.BookingID,
                        StatusItemName = statusItems[i].StatusItemName
                    };


                    statusItemsList.Add(addStatus);
                } 

               
                _context.StatusItems.AddRange(statusItemsList);
                _context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
        }

        public bool PostStatusForsaleData(StatusForSale statusForSale)
        {

            var StatusForSaleList = new List<StatusForSale>();

            try
            {
                var addStatusForSale = new StatusForSale
                {
                    //SaleEMID = SaleEMID,          
                    //IdEM = saleInvoices.IdEM,
                    //BookingID = bookingServices.BookingID,
                    StatusSaleName = statusForSale.StatusSaleName
                };
                StatusForSaleList.Add(addStatusForSale);
                _context.statusForSales.AddRange(StatusForSaleList);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
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

