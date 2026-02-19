using UnityEngine;

public class ItemWorldSpawner : MonoBehaviour
{
    public ItemData ItemData;
    private void Start ()
    {
        ItemsWorld.spawnItemWorld (transform.position, ItemData);
        Destroy (gameObject);
    }
}
