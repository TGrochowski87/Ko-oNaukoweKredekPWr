using AutoMapper;
using CPC2020_2_Lab4.Infrastructure;
using CPC2020_2_Lab4.Models;

namespace CPC2020_2_Lab4.Repositories
{
    /// <summary>
    /// Klasa abstrakcyjna mająca zmienne i/lub metody, które każde repozytorium powinno zawierać
    /// </summary>
    public abstract class Repository
    {
        protected readonly DataBaseContext DbContext = new DataBaseContext();

        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));
       
        protected readonly IMapper Mapper = MapperConfig.CreateMapper();
    }
}
