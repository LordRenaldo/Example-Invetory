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
        Debug.Log (ItemList.Count);
    }

    public void AddItem ( ItemData item )
    {
        if (item.IsStackable ())
        {
            bool itemAlreadyInInventory = false;
            foreach (ItemData inventoryItem in ItemList)
            {
                if (inventoryItem.itemType == item.itemType)
                {
                    inventoryItem.Amount += item.Amount;
                    itemAlreadyInInventory = true;
                    break;
                }
            }

            if (!itemAlreadyInInventory)
            {
                ItemList.Add (item);
            }
        }
        else
        {
            ItemList.Add (item);
        }

        if (item != null)
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
