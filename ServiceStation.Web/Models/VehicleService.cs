namespace ServiceStation.Web.Models
{
    public class VehicleService
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public Double Cost { get; set; }
        
        public Double IsDeleted { get; set; }

    }
}
