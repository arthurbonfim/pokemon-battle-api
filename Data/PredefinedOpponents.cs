using PokemonBattleApi.Models;
using PokemonBattleApi.Enums;
using PokemonBattleApi.Services;

namespace PokemonBattleApi.Data;

public class PredefinedOpponents
{
    private static readonly PokemonService _pokemonService = new();

    public static List<Opponent> Opponents { get; } = new()
    {
        new Opponent(0, "Team Rocket",
            _pokemonService.GetPokemonsByIds(new[] {
                52, // Meowth
                24, // Arbok
                110 // Weezing
            }),
            EOpponentDifficulty.Easy),

        new Opponent(1, "Giovanni",
            _pokemonService.GetPokemonsByIds(new[] {
                31, // Nidoqueen
                34, // Nidoking
                51, // Dugtrio
                112, // Rhydon
                130 // Persian
            }),
            EOpponentDifficulty.Medium),

        new Opponent(2, "Elite Four - Lance",
            _pokemonService.GetPokemonsByIds(new[] {
                6,   // Charizard
                130, // Gyarados
                149, // Dragonite
                147, // Dratini
                148, // Dragonair
                142  // Aerodactyl
            }),
            EOpponentDifficulty.Hard),
    };
}