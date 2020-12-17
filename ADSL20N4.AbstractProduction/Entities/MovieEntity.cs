namespace ADSL20N4.AbstractProduction.Entities
{
    public class MovieEntity : ProductionEntity
    {
        public int DurationInMinutes { get; set; }
        public double WorldwideBoxOfficeGross { get; set; }
    }
}
