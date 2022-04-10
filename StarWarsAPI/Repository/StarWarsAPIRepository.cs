using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using StarWarsAPI.Models;
using Dapper;

namespace StarWarsAPI.Repository
{
    public class StarWarsAPIRepository : IStarWarsAPIRepository
    {
        private readonly IDbConnection db;

        public StarWarsAPIRepository(IDbConnection db)
        {
            this.db = db;
        }

        public async Task<Character> GetCharacter(int characterId)
        {
            return (await db.QuerySingleAsync<Character>(
                "SELECT * FROM dbo.Character WHERE Id = @characterId",
                new { characterId }));
        }
    }
}
