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

    public (bool Success, string Message) DeletePlayer(Guid id)
    {
        var player = GetPlayerById(id);
        if (player == null)
            return (false, "Player not found");

        FakeDatabase.Players.Remove(player);
        return (true, "Player deleted successfully");
    }

    public (bool Success, string Message) UpdatePlayerUsername(Guid playerId, string newUsername)
    {
        var player = GetPlayerById(playerId);
        if (player == null)
            return (false, "Player not found");

        if (string.IsNullOrWhiteSpace(newUsername))
            return (false, "Invalid username");

        if (FakeDatabase.Players.Any(p => p.Username.Equals(newUsername, StringComparison.OrdinalIgnoreCase) && p.Id != playerId))
            return (false, "Username already exists");

        player.UpdateUsername(newUsername);
        return (true, "Username updated successfully");
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
    public BattleResultDto? Battle(Guid playerId, int opponentId)
    {
        var player = GetPlayerById(playerId);
        var opponent = PredefinedOpponents.Opponents.FirstOrDefault(o => o.Id == opponentId);

        if (player == null || opponent == null)
            return null;

        int score1 = player.Pokemons.Sum(p => p.Power);
        int score2 = opponent.Pokemons.Sum(p => p.Power);

        string winner = score1 > score2 ? player.Username :
                        score2 > score1 ? opponent.Name :
                        "Draw";

        return new BattleResultDto
        {
            Player1Score = score1,
            Player2Score = score2,
            WinnerName = winner
        };
    }

}