namespace AppCoreApi_00.DataModels
{
    public class ReservationTypeMain
    {
        public ReservationTypeMain() { 
        }

        
        public string PNR;
        public DateTime Date { get; set; }
        public List<CustomerType> Customers { get; set; }
        public Tickets Ticket { get; set; }
    }
}