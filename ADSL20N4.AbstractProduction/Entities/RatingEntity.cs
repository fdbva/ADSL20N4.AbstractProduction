namespace ADSL20N4.AbstractProduction.Entities
{
    public class RatingEntity
    {
        public int Id { get; set; }
        public int ProductionId { get; set; }
        public ProductionEntity Production { get; set; }
        public string Source { get; set; }
        public int Stars { get; set; }
    }
}
