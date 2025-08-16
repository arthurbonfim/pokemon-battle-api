namespace PokemonBattleApi.Services;

using PokemonBattleApi.Models;
using PokemonBattleApi.Data;
public class ShopService
{
    public List<Item> GetAvailableItems() => AvailableItems.Items;

    public bool PurchaseItem(Guid playerId, int itemId, out string message)
    {
        var player = FakeDatabase.Players.FirstOrDefault(p => p.Id == playerId);
        if (player == null)
        {
            message = "Player not found.";
            return false;
        }
        var item = AvailableItems.Items.FirstOrDefault(i => i.Id == itemId);
        if (item == null)
        {
            message = "Item not found.";
            return false;
        }

        if (player.Credits < item.Price)
        {
            message = "Insufficient funds.";
            return false;
        }

        player.Credits -= item.Price;
        player.AddItem(item);
        message = "Item purchased successfully.";
        return true;
    }

    public bool SellItem(Guid playerId, int itemId, out string message)
    {
        var player = FakeDatabase.Players.FirstOrDefault(p => p.Id == playerId);
        if (player == null)
        {
            message = "Player not found.";
            return false;
        }

        var item = player.Items.FirstOrDefault(i => i.Id == itemId);
        if (item == null)
        {
            message = "Item not found in player's inventory.";
            return false;
        }

        player.Credits += item.Price;
        player.RemoveItem(item);
        message = "Item sold successfully.";
        return true;
    }
}