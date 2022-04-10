using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWarsAPI.Models;
using StarWarsAPI.Interfaces;

namespace StarWarsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly ICharacterLogic characterLogic;
        public CharactersController(ICharacterLogic characterLogic)
        {
            this.characterLogic = characterLogic;
        }

        [HttpGet("id")]
        public async Task<Character> GetCharacter(int characterId)
        {
            return await characterLogic.GetCharacter(characterId);
        }
    }
}
