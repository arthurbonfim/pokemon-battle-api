using PokemonBattleApi.Data;
using PokemonBattleApi.Dtos;
using PokemonBattleApi.Models;

namespace PokemonBattleApi.Services;

public class PokemonService
{
    public List<PokemonDto> GetAvailablePokemons()
    {
        return FakeDatabase.AvailablePokemons
        .Select(p => new PokemonDto
        {
            Id = p.Id,
            Name = p.Name,
            Types = p.Types,
            Power = p.Power,
            Cost = p.Cost
        }).ToList();
    }

    public Pokemon? GetPokemonById(int id)
    {
        return FakeDatabase.AvailablePokemons.FirstOrDefault(p => p.Id == id);
    }
}