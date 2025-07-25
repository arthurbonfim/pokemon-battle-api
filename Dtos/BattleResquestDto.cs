namespace PokemonBattleApi.Dtos;

public class BattleRequestDto
{
    public Guid Player1Id { get; set; }
    public Guid Player2Id { get; set; }
}