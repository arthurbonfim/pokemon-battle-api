namespace PokemonBattleApi.Dtos;

public class BattleRequestDto
{
    public Guid PlayerId { get; set; }
    public int OpponentId { get; set; }
}