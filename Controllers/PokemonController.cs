using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace APISERVER.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {
        
        List<Pokemon> pokemons = new List <Pokemon>()
        {

            new Pokemon() {name = "Magikarp"},
            new Pokemon() {name = "SnorlaxX"}

        };



        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }

        [HttpPut]
        public ActionResult Put(Pokemon pokemon)
        {
            pokemons.Add(pokemon);

            return Ok();
        }

    }
}
