namespace PokemonBattleApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using PokemonBattleApi.Dtos;
using PokemonBattleApi.Models;
using PokemonBattleApi.Services;

[ApiController] // diz ao aspnet que a classe é um controlador de api
[Route("api/[controller]")] // define a rota base para acessar os metodos desse controller
public class PlayersController : ControllerBase
{
    private readonly PlayersService _playersService;

    // construtor para poder usar _playerService nos metodos abaixo
    public PlayersController(PlayersService playersService)
    {
        _playersService = playersService;
    }

    // Rota que cria um player e retorna sua locolizacao
    [HttpPost]
    public ActionResult<Player> CreatePlayer(CreatePlayerDto dto)
    {
        var player = _playersService.CreatePlayer(dto);
        return CreatedAtAction(nameof(GetPlayerById), new { id = player.Id }, player);
    }

    // rota para retornar todos os players
    [HttpGet]
    public ActionResult<List<Player>> GetAllPlayers()
    {
        var players = _playersService.GetAllPlayers();
        return Ok(players);
    }

    // rota que retorna um player pelo id
    [HttpGet("{id}")]
    public ActionResult<Player> GetPlayerById(Guid id)
    {
        var player = _playersService.GetPlayerById(id);
        if (player == null)
            return NotFound();

        return Ok(player);
    }

    // Adicionar um pokemon ao player
    [HttpPost("{playerId}/pokemons/{pokemonId}")]
    public IActionResult AddPokemonToPlayer(Guid playerId, int pokemonId)
    {
        var success = _playersService.AddPokemonToPlayer(playerId, pokemonId);
        if (!success)
            return BadRequest("Failed to add Pokémon. Check team size or if it's already added.");

        return Ok("Pokemon added successfully!");
    }

    // Remover pokemon de um player
    [HttpDelete("{playerId}/pokemons/{pokemonId}")]
    public IActionResult RemovePokemonFromPlayer(Guid playerId, int pokemonId)
    {
        var success = _playersService.RemovePokemonFromPlayer(playerId, pokemonId);
        if (!success)
            return BadRequest("Failed to remove pokemon. Check if the player and pokemon IDs are valid");
        return Ok("Pokemon removed successfully!");
    }

    [HttpPost("battle")]
    public IActionResult Battle([FromBody] BattleRequestDto resquest)
    {
        var result = _playersService.Battle(resquest.Player1Id, resquest.Player2Id);
        if (result == null)
            return BadRequest("Invalid Player(s)");

        return Ok(result);
    }
}