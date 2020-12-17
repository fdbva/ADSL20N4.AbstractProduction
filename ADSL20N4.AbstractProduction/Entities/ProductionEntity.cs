using System;

namespace ADSL20N4.AbstractProduction.Entities
{
    public abstract class ProductionEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }
    }
}
