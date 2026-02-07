using UnityEngine;

public class ItemData
{
    public enum Itemtype { HealthPotion, ManaPotion, Sword, Coin, Stone, Ring }
    public Itemtype itemType;
    public int Amount;

    public Sprite GetSprite ()
    {
        switch (itemType)
        {
            default:
            case Itemtype.ManaPotion: return ItemsAssets.Instance.manaPotionSprite;
            case Itemtype.Sword: return ItemsAssets.Instance.swordSprite;
            case Itemtype.HealthPotion: return ItemsAssets.Instance.healthPotionSprite;
            case Itemtype.Coin: return ItemsAssets.Instance.coinSprite;
            case Itemtype.Stone: return ItemsAssets.Instance.stoneSprite;
            case Itemtype.Ring: return ItemsAssets.Instance.ringSprite;

        }

    }
}
