namespace ServiceStation.Web.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int EmployeeId { get; set; }
        public int VehicleServiceId { get; set; }
       public TransactionStatus Status { get; set; }=TransactionStatus.New;
        public bool IsDeleted { get; set; } = false;
    }
}
