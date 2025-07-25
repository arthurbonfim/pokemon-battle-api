using PokemonBattleApi.Enums;

namespace PokemonBattleApi.Models;

public class Pokemon
{
    public Pokemon(int id, string name, List<EPokemonTypes> types, int power, int cost)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Pokemon must have a valid name.", nameof(name));
        if (types == null || types.Count == 0) throw new ArgumentException("At least one type is required.", nameof(types));
        if (power < 0) throw new ArgumentOutOfRangeException("Power must be non-negative.", nameof(power));
        if (cost < 0) throw new ArgumentOutOfRangeException("Cost must be non-negative.", nameof(cost));

        Id = id;
        Name = name;
        //There should be no duplicate types
        Types = types.Distinct().ToList();
        Power = power;
        Cost = cost;
    }

    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public List<EPokemonTypes> Types { get; private set; }
    public int Power { get; set; }
    public int Cost { get; set; }
}