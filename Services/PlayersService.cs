namespace PokemonBattleApi.Services;

using PokemonBattleApi.Models;
using PokemonBattleApi.Dtos;
using PokemonBattleApi.Data;

public class PlayersService
{
    private readonly PokemonService _pokemonService;
    public PlayersService(PokemonService pokemonService)
    {
        _pokemonService = pokemonService;
    }


    public Player CreatePlayer(CreatePlayerDto dto)
    {
        var player = new Player(dto.Username);
        FakeDatabase.Players.Add(player);
        return player;
    }

    public List<Player> GetAllPlayers()
    {
        return FakeDatabase.Players;
    }

    public Player? GetPlayerById(Guid id)
    {
        return FakeDatabase.Players.FirstOrDefault(p => p.Id == id);
    }

    public bool AddPokemonToPlayer(Guid playerId, int pokemonId)
    {
        var player = GetPlayerById(playerId);
        var pokemon = _pokemonService.GetPokemonById(pokemonId);

        // player cannot have more than 6 pokemons
        if (player == null || player.Pokemons.Count >= Player.MaxPokemons)
            return false;

        // player cannot have duplicate pokemons
        if (pokemon == null || player.Pokemons.Any(p => p.Id == pokemon.Id))
            return false;

        // player cannot buy pokemons if he does not have enough credits
        if (player.Credits < pokemon.Cost)
            return false;

        player.AddPokemon(pokemon);
        player.Credits -= pokemon.Cost;
        return true;
    }
    public bool RemovePokemonFromPlayer(Guid playerId, int pokemonId)
    {
        var player = GetPlayerById(playerId);
        if (player == null)
            return false;

        var pokemon = _pokemonService.GetPokemonById(pokemonId);
        // checks if the pokemon is on the player's team
        if (pokemon == null || !player.Pokemons.Any(p => p.Id == pokemon.Id))
            return false;

        player.RemovePokemon(pokemon);
        player.Credits += pokemon.Cost;
        return true;
    }
    public BattleResultDto? Battle(Guid player1Id, Guid player2Id)
    {
        var p1 = GetPlayerById(player1Id);
        var p2 = GetPlayerById(player2Id);

        if (p1 == null || p2 == null)
            return null;

        int score1 = p1.Pokemons.Sum(p => p.Power);
        int score2 = p2.Pokemons.Sum(p => p.Power);

        string winner = score1 > score2 ? p1.Username :
                        score2 > score1 ? p2.Username :
                        "Draw";

        return new BattleResultDto
        {
            Player1Score = score1,
            Player2Score = score2,
            WinnerName = winner
        };
    }

}