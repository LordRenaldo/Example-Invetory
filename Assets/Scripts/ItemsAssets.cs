using UnityEngine;

public class ItemsAssets : MonoBehaviour
{
    public static ItemsAssets Instance { get; private set; }
    public Sprite healthPotionSprite;
    public Sprite manaPotionSprite;
    public Sprite swordSprite;
    public Sprite stoneSprite;
    public Sprite ringSprite;
    public Sprite coinSprite;

    private void Awake ()
    {
        Instance = this;
    }
}
