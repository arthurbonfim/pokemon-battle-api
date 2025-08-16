namespace PokemonBattleApi.Models;

using PokemonBattleApi.Enums;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public EItemType Type { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Value { get; set; } // Represents the value of the item, e.g., healing amount or effect strength
    public int Price { get; set; } // Represents the cost of the item in the game currency
}