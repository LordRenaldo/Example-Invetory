using UnityEngine;

public class ItemsWorld : MonoBehaviour
{
    [SerializeField] ItemData itemData;
    SpriteRenderer spriteRenderer;
    public static ItemsWorld spawnItemWorld ( Vector3 position, ItemData itemData )
    {
        Transform transform = Instantiate (ItemsAssets.Instance.itemWorldprefab, position, Quaternion.identity);
        ItemsWorld itemsWorld = transform.GetComponent<ItemsWorld> ();
        itemsWorld.SetItem (itemData);
        return itemsWorld;
    }
    public void SetItem ( ItemData item )
    {
        this.itemData = item;
        if (spriteRenderer == null) spriteRenderer = GetComponent<SpriteRenderer> ();
        spriteRenderer.sprite = itemData.GetSprite ();
    }
    private void Awake ()
    {
        spriteRenderer = GetComponent<SpriteRenderer> ();
    }
    public ItemData GetItem ()
    {
        return itemData;
    }
    public void DestroySelf ()
    {
        Destroy (gameObject);
    }
}
