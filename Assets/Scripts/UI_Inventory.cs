using System;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    Inventory inventory;
    [SerializeField] GameObject itemsTemplate;
    [SerializeField] Transform itemsContainer;
    public void SetInventory ( Inventory inventory )
    {
        this.inventory = inventory;
        inventory.OnItemListChanged += inventory_OnItemListChanged;
        RefreshInventoryItems ();
    }

    private void inventory_OnItemListChanged ( object sender, EventArgs e )
    {
        RefreshInventoryItems ();
    }

    void RefreshInventoryItems ()
    {
        if (inventory != null)
        {
            foreach (Transform child in itemsContainer)
            {
                if (child == itemsTemplate) continue;
                Destroy (child.gameObject);
            }

            foreach (ItemData item in inventory.GetItemList ())
            {
                var newUitem = Instantiate (itemsTemplate, itemsContainer).GetComponent<RectTransform> ();
                newUitem.name = item.itemType.ToString ();
                var image = newUitem.Find ("Border/Image").GetComponent<Image> ();
                image.sprite = item.GetSprite ();
            }
        }
    }
}