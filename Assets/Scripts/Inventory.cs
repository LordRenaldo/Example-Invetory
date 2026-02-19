using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public event EventHandler OnItemListChanged;
    public List<ItemData> ItemList;
    public Inventory ()
    {
        ItemList = new List<ItemData> ();

        AddItem (new ItemData { itemType = ItemData.Itemtype.HealthPotion, Amount = 1 });
        AddItem (new ItemData { itemType = ItemData.Itemtype.ManaPotion, Amount = 1 });
        AddItem (new ItemData { itemType = ItemData.Itemtype.Sword, Amount = 1 });

        Debug.Log (ItemList.Count);
    }

    public void AddItem ( ItemData item )
    {
        if (item != null) ItemList.Add (item);
        OnItemListChanged?.Invoke (this, EventArgs.Empty);
    }

    public void RemoveItem ( ItemData item )
    {
        if (ItemList.Contains (item)) ItemList.Remove (item);
    }

    public List<ItemData> GetItemList ()
    {
        return ItemList;
    }
}
