using AppCoreApi_00.DataModels;

namespace AppCoreApi_00.Actions
{
    public class CustomerActionMethods
    {
        public CustomerActionMethods()
        {
        }

        public ReservationTypeMain GetCustomerDetails()
        {
            List<DataModels.CustomerType> returnList = new List<DataModels.CustomerType>();

            returnList.Add(new DataModels.CustomerType(){
                Age = 4,
                CustomerFirstName = "First Name",
                CustomerLastName = "Last Name"
            });

            returnList.Add(new DataModels.CustomerType()
            {
                Age = 4,
                CustomerFirstName = "First Name",
                CustomerLastName = "Last Name"
            });
            returnList.Add(new DataModels.CustomerType()
            {
                Age = 4,
                CustomerFirstName = "First Name",
                CustomerLastName = "Last Name"
            });


            ReservationTypeMain reservationData = new ReservationTypeMain();
            reservationData.Customers = returnList;
            reservationData.PNR = "ER45CD";
            reservationData.Date = new DateTime().Date;
            reservationData.Ticket = new Tickets()
            {
                TicketNumber="14332321"
            };


            return reservationData;
        }



    }
}