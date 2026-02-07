using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public List<ItemData> ItemList;
    public Inventory ()
    {
        ItemList = new List<ItemData> ();

        AddItem (new ItemData { itemType = ItemData.Itemtype.HealthPotion, Amount = 1 });

        Debug.Log (ItemList.Count);
    }

    public void AddItem ( ItemData item )
    {
        if (item != null) ItemList.Add (item);
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
