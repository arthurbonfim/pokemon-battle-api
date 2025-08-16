namespace PokemonBattleApi.Models;

public class Player
{
    public Player(string username)
    {
        Username = string.IsNullOrWhiteSpace(username) ? "Player" : username;
    }

    public Guid Id { get; init; } = Guid.NewGuid();
    public string Username { get; set; }
    public const int InitialCredits = 1000;
    public int Credits { get; set; } = InitialCredits;
    public const int MaxPokemons = 6;
    private readonly List<Pokemon> _pokemons = new();
    public IReadOnlyList<Pokemon> Pokemons => _pokemons;
    private readonly List<Item> _items = new();

    public IReadOnlyList<Item> Items => _items;

    public void AddPokemon(Pokemon pokemon)
    {
        ArgumentNullException.ThrowIfNull(pokemon);
        // Avoid adding the same Pokémon more than once to the player
        if (_pokemons.Any(p => p.Id == pokemon.Id)) return;
        _pokemons.Add(pokemon);
    }
    public void RemovePokemon(Pokemon pokemon)
    {
        ArgumentNullException.ThrowIfNull(pokemon);
        if (!_pokemons.Any(p => p.Id == pokemon.Id)) return;
        _pokemons.Remove(pokemon);
    }

    public void AddItem(Item item)
    {
        ArgumentNullException.ThrowIfNull(item);
        _items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        ArgumentNullException.ThrowIfNull(item);
        if (!_items.Any(i => i.Id == item.Id)) return;
        _items.Remove(item);
    }
}