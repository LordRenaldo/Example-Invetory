using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    Inventory inventory;
    [SerializeField] GameObject itemsTemplate;
    [SerializeField] Transform itemsContainer;
    public void SetInventory ( Inventory inventory )
    {
        this.inventory = inventory;
        RefreshInventoryItems ();
    }
    void RefreshInventoryItems ()
    {
        if (inventory != null)
        {
            foreach (ItemData item in inventory.GetItemList ())
            {
                var newUitem = Instantiate (itemsTemplate, itemsContainer).GetComponent<RectTransform> ();

                newUitem.name = item.itemType.ToString ();
            }
        }
    }
}