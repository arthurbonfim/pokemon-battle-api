using PokemonBattleApi.Enums;

namespace PokemonBattleApi.Models;

public class Opponent
{
    public Opponent(int id, string name, List<Pokemon> pokemons, EOpponentDifficulty difficulty)
    {
        Id = id;
        Name = name;
        Pokemons = pokemons ?? new List<Pokemon>();
        Difficulty = difficulty;
    }
    public int Id { get; init; }
    public string Name { get; set; } = string.Empty;
    public List<Pokemon> Pokemons { get; init; } = new();
    public EOpponentDifficulty Difficulty { get; init; }
}