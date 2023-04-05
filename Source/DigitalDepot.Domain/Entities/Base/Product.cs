using DigitalDepot.Domain.Common;

namespace DigitalDepot.Domain.Entities.Base
{
    public class Product : BaseAduitableEntity 
    {
        public string? Name { get; set; }

        public string? Brand { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int WarrantyInMonths { get; set; }
    }
}
