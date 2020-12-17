using System.Collections.Generic;

namespace ADSL20N4.AbstractProduction.Entities
{
    public class ActorEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CharacterEntity> Characters { get; set; } = new List<CharacterEntity>();
    }
}
