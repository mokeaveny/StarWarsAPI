using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWarsAPI.Models;

namespace StarWarsAPI.Repository
{
    public interface IStarWarsAPIRepository
    {
        Task<Character> GetCharacter(int characterId);
    }
}
