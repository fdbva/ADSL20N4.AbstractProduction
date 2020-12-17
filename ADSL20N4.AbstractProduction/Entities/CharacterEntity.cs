namespace ADSL20N4.AbstractProduction.Entities
{
    public class CharacterEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ProductionId { get; set; }
        public ProductionEntity Production { get; set; }

        public int ActorId { get; set; }
        public ActorEntity Actor { get; set; }
    }
}
