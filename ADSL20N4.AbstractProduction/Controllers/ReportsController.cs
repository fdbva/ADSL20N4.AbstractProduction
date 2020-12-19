using System.Collections.Generic;
using System.Linq;
using ADSL20N4.AbstractProduction.Entities;
using ADSL20N4.AbstractProduction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ADSL20N4.AbstractProduction.Controllers
{
    public class ReportsController : Controller
    {
        private readonly EntertainmentDbContext _entertainmentDbContext;

        public ReportsController(
            EntertainmentDbContext entertainmentDbContext)
        {
            _entertainmentDbContext = entertainmentDbContext;
        }

        public IActionResult Top3HighestGrossingMovies()
        {
            var top3HighestGrossingMovies =
                _entertainmentDbContext
                    .Movies
                    .OrderByDescending(x => x.WorldwideBoxOfficeGross)
                    .Take(3);

            var reportDebugViewModel = new ReportDebugViewModel
            {
                Question = nameof(Top3HighestGrossingMovies),
                Json = JsonConvert.SerializeObject(top3HighestGrossingMovies, Formatting.Indented),
                Sql = top3HighestGrossingMovies.ToQueryString()
            };

            return View("ReportDebugView", reportDebugViewModel);
        }

        public IActionResult Top3HighestGrossingProductionOfTypeMovie()
        {
            var top3HighestGrossingProductionOfTypeMovie =
                _entertainmentDbContext
                    .Productions
                    .OfType<MovieEntity>()
                    .OrderByDescending(x => x.WorldwideBoxOfficeGross)
                    .Take(3);

            var reportDebugViewModel = new ReportDebugViewModel
            {
                Question = nameof(top3HighestGrossingProductionOfTypeMovie),
                Json = JsonConvert.SerializeObject(top3HighestGrossingProductionOfTypeMovie, Formatting.Indented),
                Sql = top3HighestGrossingProductionOfTypeMovie.ToQueryString()
            };

            return View("ReportDebugView", reportDebugViewModel);
        }

        public IActionResult Top3HighestRatedProductionDoubleAverage()
        {
            var top3HighestRatedProduction =
                _entertainmentDbContext
                    .Productions
                    .OrderByDescending(x => x.Ratings.Average(y => y.Stars))
                    .Select(x => new
                    {
                        Name = x.Name,
                        Stars = x.Ratings.Average(y => y.Stars),
                        Type = x.GetType().Name
                    })
                    .Take(3);

            var reportDebugViewModel = new ReportDebugViewModel
            {
                Question = nameof(Top3HighestRatedProductionDoubleAverage),
                Json = JsonConvert.SerializeObject(top3HighestRatedProduction, Formatting.Indented),
                Sql = top3HighestRatedProduction.ToQueryString()
            };

            return View("ReportDebugView", reportDebugViewModel);
        }

        public IActionResult Top3HighestRatedProduction()
        {
            var top3HighestRatedProduction =
                _entertainmentDbContext
                    .Productions
                    .Select(x => new
                    {
                        Name = x.Name,
                        Stars = x.Ratings.Average(y => y.Stars),
                        Type = x.GetType().Name
                    })
                    .OrderByDescending(x => x.Stars)
                    .Take(3);

            var reportDebugViewModel = new ReportDebugViewModel
            {
                Question = nameof(Top3HighestRatedProduction),
                Json = JsonConvert.SerializeObject(top3HighestRatedProduction, Formatting.Indented),
                Sql = top3HighestRatedProduction.ToQueryString()
            };

            return View("ReportDebugView", reportDebugViewModel);
        }

        public IActionResult SourcesOfRatingByType()
        {
            var sourcesOfRatingByType =
                _entertainmentDbContext
                    .Ratings
                    .GroupBy(x => x.Source)
                    .Select(x => new
                    {
                        Source = x.Key,
                        Count = x.Count()
                    })
                    .OrderByDescending(x => x.Count)
                    .Take(5);

            var reportDebugViewModel = new ReportDebugViewModel
            {
                Question = nameof(SourcesOfRatingByType),
                Json = JsonConvert.SerializeObject(sourcesOfRatingByType, Formatting.Indented),
                Sql = sourcesOfRatingByType.ToQueryString()
            };

            return View("ReportDebugView", reportDebugViewModel);
        }

        public IActionResult ActorsPlayingCharactersInMultiplasProducoes()
        {
            var sourcesOfRatingByType =
                _entertainmentDbContext
                    .Actors
                    .Where(x => x.Characters.Count > 1)
                    .Select(x => new
                    {
                        ActorName = x.Name,
                        Characters = x.Characters.Select(y => new
                        {
                            CharacterName = y.Name,
                            ProductionType = y.Production.GetType().Name,
                            ProductionName = y.Production.Name,
                            Stars = y.Production.Ratings.Average(z => z.Stars)
                        })
                    })
                    .Take(3);

            var reportDebugViewModel = new ReportDebugViewModel
            {
                Question = nameof(ActorsPlayingCharactersInMultiplasProducoes),
                Json = JsonConvert.SerializeObject(sourcesOfRatingByType, Formatting.Indented),
                Sql = sourcesOfRatingByType.ToQueryString()
            };

            return View("ReportDebugView", reportDebugViewModel);
        }
    }
}
