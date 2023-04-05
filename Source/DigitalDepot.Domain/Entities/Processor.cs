using DigitalDepot.Domain.Entities.Base;

namespace DigitalDepot.Domain.Entities
{
    public class Processor : Product
    {
        public int Cores { get; set; }

        public int Threads { get; set; }

        public string? Socket { get; set; }
        
        public int Cache { get; set; }

        public double Frequency { get; set; }

        public string? GraphicsModel { get; set; }

        public virtual Series Series { get; set; }
    }
}
