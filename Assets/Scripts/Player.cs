using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;
    private Inventory inventory;
    private void Start ()
    {
        inventory = new Inventory ();
        uiInventory.SetInventory (inventory);

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
