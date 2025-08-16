namespace PokemonBattleApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PokemonBattleApi.Dtos;
using PokemonBattleApi.Models;
using PokemonBattleApi.Services;

[ApiController]
[Route("api/[controller]")]
public class PlayersController : ControllerBase
{
    private readonly PlayersService _playersService;

    public PlayersController(PlayersService playersService)
    {
        _playersService = playersService;
    }

    private readonly ShopService _shopService = new();

    [HttpPost]
    public ActionResult<Player> CreatePlayer(CreatePlayerDto dto)
    {
        var player = _playersService.CreatePlayer(dto);
        return CreatedAtAction(nameof(GetPlayerById), new { id = player.Id }, player);
    }

    [HttpGet]
    public ActionResult<List<Player>> GetAllPlayers()
    {
        var players = _playersService.GetAllPlayers();
        return Ok(players);
    }

    [HttpGet("{id}")]
    public ActionResult<Player> GetPlayerById(Guid id)
    {
        var player = _playersService.GetPlayerById(id);
        if (player == null)
            return NotFound();

        return Ok(player);
    }

    [HttpPost("{playerId}/pokemons/{pokemonId}")]
    public IActionResult AddPokemonToPlayer(Guid playerId, int pokemonId)
    {
        var success = _playersService.AddPokemonToPlayer(playerId, pokemonId);
        if (!success)
            return BadRequest("Failed to add Pokémon. Check team size or if it's already added.");

        return Ok("Pokemon added successfully!");
    }

    [HttpDelete("{playerId}/pokemons/{pokemonId}")]
    public IActionResult RemovePokemonFromPlayer(Guid playerId, int pokemonId)
    {
        var success = _playersService.RemovePokemonFromPlayer(playerId, pokemonId);
        if (!success)
            return BadRequest("Failed to remove pokemon. Check if the player and pokemon IDs are valid");
        return Ok("Pokemon removed successfully!");
    }

    [HttpPost("{playerId}/items/{itemId}")]
    public ActionResult<Item> BuyItem(Guid playerId, int itemId)
    {
        bool success = _shopService.PurchaseItem(playerId, itemId, out var message);
        if (!success)
        {
            return BadRequest(message);
        }
        return Ok(message);
    }

    [HttpDelete("{playerId}/items/{itemId}")]
    public IActionResult RemoveItemFromPlayer(Guid playerId, int itemId)
    {
        var success = _shopService.SellItem(playerId, itemId, out var message);
        if (!success)
            return BadRequest(message);
        return Ok(message);
    }

    [HttpPost("battle")]
    public IActionResult Battle([FromBody] BattleRequestDto resquest)
    {
        var result = _playersService.Battle(resquest.PlayerId, resquest.OpponentId);
        if (result == null)
            return BadRequest("Invalid Player or Opponent ID");

        return Ok(result);
    }
}