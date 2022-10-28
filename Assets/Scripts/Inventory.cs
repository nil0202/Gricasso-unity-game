using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {

    private List<Item> itemList;

    public Inventory(){
        itemList = new List<Item>();

        AddItem(new Item {itemType = Item.ItemType.redGlasses, on = false});
        AddItem(new Item {itemType = Item.ItemType.purpleGlasses, on = false});
        AddItem(new Item {itemType = Item.ItemType.blueGlasses, on = false});
        AddItem(new Item {itemType = Item.ItemType.orangeGlasses, on = false});
        AddItem(new Item {itemType = Item.ItemType.greenGlasses, on = false});
        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item){
        itemList.Add(item);
    }

    public List<Item> GetItemList(){

        return itemList;

    }

}
