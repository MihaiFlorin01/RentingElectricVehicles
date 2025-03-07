using System.ComponentModel.DataAnnotations.Schema;

namespace ElectricVehiclesBackend.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public DateTime RegisterDate { get; set; }

        public int VehicleTypeId { get; set; }

        [ForeignKey("VehicleTypeId")]
        public VehicleType? VehicleType { get; set; }

        public ICollection<Rental>? Rentals { get; set; }
    }
}
