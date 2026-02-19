using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;
    private Inventory inventory;
    private void Start ()
    {
        inventory = new Inventory ();
        uiInventory.SetInventory (inventory);
        ItemsWorld.spawnItemWorld (new Vector3 (-0.4f, -2.84f), new ItemData { itemType = ItemData.Itemtype.HealthPotion, Amount = 1 });
        ItemsWorld.spawnItemWorld (new Vector3 (-0.9f, -2.84f), new ItemData { itemType = ItemData.Itemtype.ManaPotion, Amount = 1 });
        ItemsWorld.spawnItemWorld (new Vector3 (-3f, -2.84f), new ItemData { itemType = ItemData.Itemtype.Ring, Amount = 1 });
    }
    private void OnTriggerEnter2D ( Collider2D other )
    {
        ItemsWorld itemsWorld = other.GetComponent<ItemsWorld> ();
        if (itemsWorld != null)
        {
            inventory.AddItem (itemsWorld.GetItem ());
            itemsWorld.DestroySelf ();
        }
    }
}
