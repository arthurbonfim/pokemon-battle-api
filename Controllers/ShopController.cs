namespace PokemonBattleApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using PokemonBattleApi.Data;
using PokemonBattleApi.Dtos;
using PokemonBattleApi.Models;
using PokemonBattleApi.Services;

[ApiController]
[Route("api/[controller]")]
public class ShopController : ControllerBase
{
    private readonly ShopService _shopService = new();

    [HttpGet("items")]
    public ActionResult<List<Item>> GetAvailableItems()
    {
        return Ok(_shopService.GetAvailableItems());
    }
}