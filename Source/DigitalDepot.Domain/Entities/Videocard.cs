using DigitalDepot.Domain.Entities.Base;
using DigitalDepot.Domain.Enums;

namespace DigitalDepot.Domain.Entities
{
    public class Videocard : Product
    {
        public string? MemoryInterface { get; set; }

        public VideocardMemoryType MemoryType { get; set; }

        public int Memory { get; set; }

        public string? PowerConnectors { get; set; }

        public virtual Series Series { get; set; }
    }
}
