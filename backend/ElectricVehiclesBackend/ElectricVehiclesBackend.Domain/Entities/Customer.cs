namespace ElectricVehiclesBackend.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string? Name { get; set; }

        public string? BillingAddress { get; set; }

        public ICollection<Rental>? Rentals { get; set; }
    }
}
