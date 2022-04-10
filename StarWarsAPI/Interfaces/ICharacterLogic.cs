using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWarsAPI.Models;

namespace StarWarsAPI.Interfaces
{
    public interface ICharacterLogic
    {
        Task<Character> GetCharacter(int characterId);
    }
}
