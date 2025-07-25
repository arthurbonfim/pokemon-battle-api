namespace PokemonBattleApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using PokemonBattleApi.Dtos;
using PokemonBattleApi.Models;
using PokemonBattleApi.Services;

[ApiController]
[Route("api/[controller]")]

public class PokemonsController : ControllerBase
{
    private readonly PokemonService _pokemonService;
    public PokemonsController(PokemonService pokemonService)
    {
        _pokemonService = pokemonService;
    }

    // Retorna os pokemons disponiveis
    [HttpGet]
    public ActionResult<List<PokemonDto>> GetAvailablePokemons()
    {
        var pokemons = _pokemonService.GetAvailablePokemons();
        return Ok(pokemons);
    }
}