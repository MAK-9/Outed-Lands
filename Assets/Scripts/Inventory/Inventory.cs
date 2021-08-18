using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();
        
        //test adding items
        AddItem(new Item{ itemType = Item.ItemType.Wood, amount = 1});
        AddItem(new Item{ itemType = Item.ItemType.Plank, amount = 1});
        AddItem(new Item{ itemType = Item.ItemType.Copper, amount = 1});
        AddItem(new Item{ itemType = Item.ItemType.Iron, amount = 1});
        AddItem(new Item{ itemType = Item.ItemType.Crystal, amount = 1});
        AddItem(new Item{ itemType = Item.ItemType.Stone, amount = 1});
    }

    public void AddItem(Item item)
    {
        itemList.Add(item);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
