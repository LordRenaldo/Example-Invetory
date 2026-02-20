using System;
using UnityEngine;

[Serializable]
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
    public bool IsStackable ()
    {
        switch (itemType)
        {
            default:
            case Itemtype.ManaPotion:
            case Itemtype.HealthPotion:
            case Itemtype.Stone:
            case Itemtype.Coin:
            return true;
            case Itemtype.Sword:
            case Itemtype.Ring:
            return false;

        }
    }
}
