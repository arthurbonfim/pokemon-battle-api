using PokemonBattleApi.Models;
using PokemonBattleApi.Enums;
using PokemonBattleApi.Services;

namespace PokemonBattleApi.Data;

public class PredefinedOpponents
{
    private static readonly PokemonService _pokemonService = new();

    public static List<Opponent> Opponents { get; } = new()
    {
        new Opponent(0, "Team Rocket", EOpponentDifficulty.Easy,
            _pokemonService.GetPokemonsByIds(new[] {
                52, // Meowth
                24, // Arbok
                110 // Weezing
            })),

        new Opponent(1, "Giovanni", EOpponentDifficulty.Medium,
            _pokemonService.GetPokemonsByIds(new[] {
                31, // Nidoqueen
                34, // Nidoking
                51, // Dugtrio
                112, // Rhydon
                130 // Persian
            })),

        new Opponent(2, "Elite Four - Lance", EOpponentDifficulty.Hard,
            _pokemonService.GetPokemonsByIds(new[] {
                6,   // Charizard
                130, // Gyarados
                149, // Dragonite
                147, // Dratini
                148, // Dragonair
                142  // Aerodactyl
            }))
    };
}