using PokemonBattleApi.Enums;

namespace PokemonBattleApi.Dtos;

public class PokemonDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<EPokemonTypes> Types { get; set; } = new();
    public int Power { get; set; }
    public int Cost { get; set; }
}