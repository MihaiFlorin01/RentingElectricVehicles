using System.ComponentModel.DataAnnotations.Schema;

namespace ElectricVehiclesBackend.Domain.Entities
{
    public class VehicleType : BaseEntity
    {
        public string? Description { get; set; }

        public decimal PricePerMinute { get; set; }

        [ForeignKey("VehicleId")]
        public Vehicle? Vehicle { get; set; }
    }
}
