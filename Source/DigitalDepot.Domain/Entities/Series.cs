using DigitalDepot.Domain.Entities.Base;

namespace DigitalDepot.Domain.Entities
{
    public class Series
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
