using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        Wood, Iron, Stone, Plank, Crystal, Copper
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
                
            case ItemType.Copper: return ItemAssets.Instance.copperSprite;
            case ItemType.Stone: return ItemAssets.Instance.stoneSprite;
            case ItemType.Crystal: return ItemAssets.Instance.crystalSprite;
            case ItemType.Iron: return ItemAssets.Instance.ironSprite;
            case ItemType.Wood: return ItemAssets.Instance.woodSprite;
            case ItemType.Plank: return ItemAssets.Instance.plankSprite;
        }
    }
}
