using PokemonBattleApi.Data;
using PokemonBattleApi.Models;

namespace PokemonBattleApi.Services;

public class OpponentService
{
    public List<Opponent> GetAllOpponents()
    {
        return PredefinedOpponents.Opponents;
    }

    public Opponent? GetOpponentById(int id)
    {
        return PredefinedOpponents.Opponents.FirstOrDefault(o => o.Id == id);
    }
}
