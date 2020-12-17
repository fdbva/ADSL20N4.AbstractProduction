using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ADSL20N4.AbstractProduction.Entities
{
    public class EntertainmentDbContext : DbContext
    {
        public EntertainmentDbContext(DbContextOptions<EntertainmentDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=entertainment.db");

        public DbSet<ProductionEntity> Productions { get; set; }
        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<SeriesEntity> Series { get; set; }
        public DbSet<RatingEntity> Ratings { get; set; }
        public DbSet<CharacterEntity> Characters { get; set; }
        public DbSet<ActorEntity> Actors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var movies = new[] {
                new MovieEntity { Id = 1, Name = "Avengers: Endgame", WorldwideBoxOfficeGross = 2_797_800_564, DurationInMinutes = 181, Release = new DateTime(2019, 4, 26) },
                new MovieEntity { Id = 2, Name = "The Lion King", WorldwideBoxOfficeGross = 1_654_791_102, DurationInMinutes     = 118, Release = new DateTime(2019, 7, 19) },
                new MovieEntity { Id = 3, Name = "Ip Man 4", WorldwideBoxOfficeGross = 192_617_891, DurationInMinutes = 105, Release = new DateTime(2019, 12, 25) },
                new MovieEntity { Id = 4, Name = "Gemini Man", WorldwideBoxOfficeGross = 166_623_705, DurationInMinutes = 116, Release = new DateTime(2019, 11, 20) },
                new MovieEntity { Id = 5, Name = "Downton Abbey", WorldwideBoxOfficeGross = 194_051_302, DurationInMinutes = 120, Release = new DateTime(2020, 9, 20 )}
            };

            var series = new[] {
                new SeriesEntity { Id = 6 , Name = "The Fresh Prince of Bel-Air", NumberOfEpisodes = 148, Release = new DateTime(1990, 9, 10) },
                new SeriesEntity { Id = 7 , Name = "Downton Abbey", NumberOfEpisodes = 52, Release = new DateTime(2010, 09, 26) },
                new SeriesEntity { Id = 8 , Name = "Stranger Things", NumberOfEpisodes = 34 , Release = new DateTime(2016, 7, 11) },
                new SeriesEntity { Id = 9 , Name = "Kantaro: The Sweet Tooth Salaryman", NumberOfEpisodes = 12, Release = new DateTime(2017,7, 14) },
                new SeriesEntity { Id = 10, Name = "The Walking Dead", NumberOfEpisodes = 177 , Release = new DateTime(2010, 10, 31) }
            };

            modelBuilder.Entity<MovieEntity>().HasData(movies);
            modelBuilder.Entity<SeriesEntity>().HasData(series);

            modelBuilder.Entity<CharacterEntity>().HasData(new[]
            {
                // movies
                new CharacterEntity { Id = 1, Name = "Tony Stark", ProductionId = 1, ActorId = 1 },
                new CharacterEntity { Id = 2, Name = "Steve Rogers", ProductionId = 1, ActorId = 2 },
                new CharacterEntity { Id = 3, Name = "Okoye", ProductionId = 1, ActorId = 3 },
                new CharacterEntity { Id = 4, Name = "Simba", ProductionId = 2, ActorId = 4 },
                new CharacterEntity { Id = 5, Name = "Nala", ProductionId = 2, ActorId = 5 },
                new CharacterEntity { Id = 6, Name = "Ip Man", ProductionId = 3, ActorId = 6 },
                new CharacterEntity { Id = 7, Name = "Henry Brogan", ProductionId = 4, ActorId = 7 },
                new CharacterEntity { Id = 8, Name = "Violet Crawley", ProductionId = 5, ActorId = 8 },
                new CharacterEntity { Id = 9, Name = "Lady Mary Crawley", ProductionId = 5, ActorId = 9 },
                // television
                new CharacterEntity { Id = 10, Name = "Will Smith", ProductionId = 6, ActorId = 7},
                new CharacterEntity { Id = 11, Name = "Hilary Banks", ProductionId = 6, ActorId = 10 },
                new CharacterEntity { Id = 12, Name = "Violet Crawley", ProductionId = 7, ActorId = 8 },
                new CharacterEntity { Id = 13, Name = "Lady Mary Crawley", ProductionId = 7, ActorId = 9 },
                new CharacterEntity { Id = 14, Name = "Eleven", ProductionId = 8, ActorId = 11 },
                new CharacterEntity { Id = 15, Name = "Lucas", ProductionId = 8, ActorId = 12 },
                new CharacterEntity { Id = 16, Name = "Joyce Byers", ProductionId = 8, ActorId = 13 },
                new CharacterEntity { Id = 17, Name = "Jim Hopper", ProductionId = 8, ActorId = 14 },
                new CharacterEntity { Id = 18, Name = "Ametani Kantarou", ProductionId = 9, ActorId = 15},
                new CharacterEntity { Id = 19, Name = "Sano Erika", ProductionId = 9, ActorId = 16 },
                new CharacterEntity { Id = 20, Name = "Daryl Dixon", ProductionId = 10, ActorId = 17 },
                new CharacterEntity { Id = 21, Name = "Michonne", ProductionId = 10, ActorId = 3 },
                new CharacterEntity { Id = 22, Name = "Carol Peletier", ProductionId = 10, ActorId = 18 }
            });

            modelBuilder.Entity<ActorEntity>().HasData(new ActorEntity[]
            {
                new ActorEntity { Id = 1, Name = "Robert Downey Jr." },
                new ActorEntity { Id = 2, Name = "Chris Evans" },
                new ActorEntity { Id = 3, Name = "Danai Guira" },
                new ActorEntity { Id = 4, Name = "Donald Glover" },
                new ActorEntity { Id = 5, Name = "Beyoncé" },
                new ActorEntity { Id = 6, Name = "Donny Yen" },
                new ActorEntity { Id = 7, Name = "Will Smith" },
                new ActorEntity { Id = 8, Name = "Maggie Smith" },
                new ActorEntity { Id = 9, Name = "Michelle Dockery" },
                new ActorEntity { Id = 10, Name = "Karyn Parsons" },
                new ActorEntity { Id = 11, Name = "Millie Bobby Brown" },
                new ActorEntity { Id = 12, Name = "Caleb McLaughlin" },
                new ActorEntity { Id = 13, Name = "Winona Ryder"},
                new ActorEntity { Id = 14, Name = "David Harbour" },
                new ActorEntity { Id = 15, Name = "Matsuya Onoe" },
                new ActorEntity { Id = 16, Name = "Hazuki Shimizu"},
                new ActorEntity { Id = 17, Name = "Norman Reedus" },
                new ActorEntity { Id = 18, Name = "Melissa McBride" }
            });

            var random = new Random();
            const int size = 100;
            var sources = new[] {
                "Internet",
                "Newspaper",
                "Magazine",
                "App"
            };

            //atentos Union vs Concat
            var productions = movies.Cast<ProductionEntity>().Union(series).ToList();

            var ratings = productions
                .SelectMany((production, index) => {
                    return Enumerable
                        .Range(index * 100 + 1, size - 1)
                        .Select(id => new RatingEntity
                        {
                            Id = id,
                            ProductionId = production.Id,
                            Stars = random.Next(1, 6),
                            Source = sources[random.Next(0, sources.Length)]
                        }).ToList();
                });

            modelBuilder.Entity<RatingEntity>().HasData(ratings);

            modelBuilder.Model.

            base.OnModelCreating(modelBuilder);
        }
    }
}
