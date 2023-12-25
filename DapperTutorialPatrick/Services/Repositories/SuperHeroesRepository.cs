using Dapper;
using DapperTutorialPatrick.Models;
using DapperTutorialPatrick.Services.Interfaces;
using System.Data.SqlClient;

namespace DapperTutorialPatrick.Services.Repositories
{
    public class SuperHeroesRepository : ISuperHeroesRepository
    {
        private readonly IConfiguration _configuration;
        public SuperHeroesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IEnumerable<SuperHeroes>> GetAllSuperHeroesAsync()
        {
            // implicity closes the connection when its done 
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var heroes = await connection.QueryAsync<SuperHeroes>("SELECT * FROM SuperHeroes");
            return heroes;
        }

        public async Task<SuperHeroes> GetASuperHeroAsync(int id)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var hero = await connection.QueryAsync<SuperHeroes>("SELECT * FROM SuperHeroes WHERE Id = @Id", new { Id = id});
            return hero;
        }
        public async Task ISuperHeroesRepository CreateSuperHeroAsync(SuperHeroes superHero)
        {
            throw new NotImplementedException();
        }

        public async Task ISuperHeroesRepository DeleteSuperHeroAsync(int id)
        {
            throw new NotImplementedException();
        }


        public async Task ISuperHeroesRepository UpdateSuperHeroAsync(SuperHeroes superHero)
        {
            throw new NotImplementedException();
        }
    }
}
