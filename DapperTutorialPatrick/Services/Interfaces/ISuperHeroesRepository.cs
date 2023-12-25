using DapperTutorialPatrick.Models;

namespace DapperTutorialPatrick.Services.Interfaces
{
    public interface ISuperHeroesRepository
    {

        Task<IEnumerable<SuperHeroes>> GetAllSuperHeroesAsync();
        Task<SuperHeroes> GetASuperHeroAsync(int id);
        Task CreateSuperHeroAsync(SuperHeroes superHero);
        Task UpdateSuperHeroAsync(SuperHeroes superHero);
        Task DeleteSuperHeroAsync(int id);
    }
}
