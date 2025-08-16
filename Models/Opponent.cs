using PokemonBattleApi.Enums;

namespace PokemonBattleApi.Models;

public class Opponent
{
    public Opponent(int id, string name, EOpponentDifficulty difficulty, List<Pokemon> pokemons)
    {
        Id = id;
        Name = name;
        Difficulty = difficulty;
        Pokemons = pokemons ?? new List<Pokemon>();
    }
    public int Id { get; init; }
    public string Name { get; set; } = string.Empty;
    public List<Pokemon> Pokemons { get; init; } = new();
    public EOpponentDifficulty Difficulty { get; init; }
}