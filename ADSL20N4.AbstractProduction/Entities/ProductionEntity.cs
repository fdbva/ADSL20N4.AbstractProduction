using System;
using System.Collections.Generic;

namespace ADSL20N4.AbstractProduction.Entities
{
    public abstract class ProductionEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }

        public List<CharacterEntity> Characters { get; set; } = new List<CharacterEntity>();
        public List<RatingEntity> Ratings { get; set; } = new List<RatingEntity>();
    }
}
