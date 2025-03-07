using System.ComponentModel.DataAnnotations.Schema;

namespace ElectricVehiclesBackend.Domain.Entities
{
    public class Invoice
    {
        public decimal GrossAmount { get; set; }

        public decimal VAT {  get; set; }

        public decimal NetAmount { get; set; }

        public bool Paid { get; set; }

        [ForeignKey("RentalId")]
        public Rental? Rental { get; set; }
    }
}
