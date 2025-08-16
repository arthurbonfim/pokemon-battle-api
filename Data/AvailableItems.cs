namespace PokemonBattleApi.Data;

using PokemonBattleApi.Models;
using PokemonBattleApi.Enums;

public static class AvailableItems
{
    public static List<Item> Items { get; } = new()
    {
        new Item { Id = 0, Name = "Power Stone", Type = EItemType.AttackBoost, Description = "Increases max-attack power in 15", Value = 15, Price = 30},
        new Item { Id = 1, Name = "X Attack", Type = EItemType.AttackBoost, Description = "Increases max-attack power in 10", Value = 10, Price = 20},
        new Item { Id = 2, Name = "X Power Max", Type = EItemType.AttackBoost, Description = "Increases max-attack power in 25", Value = 25, Price = 50}
    };
}