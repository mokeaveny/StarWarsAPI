using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWarsAPI.Interfaces;
using StarWarsAPI.Repository;
using Microsoft.Extensions.Logging;
using StarWarsAPI.Models;

namespace StarWarsAPI.Domain
{
    public class CharacterLogic : ICharacterLogic
    {
        private readonly IStarWarsAPIRepository repo;
        private readonly ILogger<CharacterLogic> logger;

        public CharacterLogic(IStarWarsAPIRepository repo, ILogger<CharacterLogic> logger)
        {
            this.repo = repo;
            this.logger = logger;
        }

        public async Task<Character> GetCharacter(int characterId)
        {
            logger.LogInformation("Getting Character");

            return await repo.GetCharacter(characterId);
        }
    }
}
