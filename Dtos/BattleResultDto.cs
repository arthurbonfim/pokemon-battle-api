namespace PokemonBattleApi.Dtos;

public class BattleResultDto
{
    public string WinnerName { get; set; } = string.Empty;
    public int Player1Score { get; set; }
    public int Player2Score { get; set; }
}