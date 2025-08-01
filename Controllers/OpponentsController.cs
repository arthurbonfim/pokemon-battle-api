namespace PokemonBattleApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using PokemonBattleApi.Models;
using PokemonBattleApi.Services;


[ApiController]
[Route("api/[controller]")]
public class OpponentsController : ControllerBase
{
    private readonly OpponentService _opponentService = new();

    [HttpGet]
    public ActionResult<List<Opponent>> GetAllOpponents()
    {
        var opponents = _opponentService.GetAllOpponents();
        return Ok(opponents);
    }

    [HttpGet("{id}")]
    public ActionResult<Opponent> GetOpponentById(int id)
    {
        var opponent = _opponentService.GetOpponentById(id);
        if (opponent == null)
            return NotFound($"Opponent with ID {id} not found.");

        return Ok(opponent);
    }
}
