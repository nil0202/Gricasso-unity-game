using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {


    public enum ItemType{
        blueGlasses,
        greenGlasses,
        redGlasses,
        purpleGlasses,
        orangeGlasses,
    }

    public ItemType itemType;
    public bool on;  

    public Sprite GetSprite() {

            switch (itemType){
            default:
            case ItemType.blueGlasses:      return ItemAssets.Instance.blueSprite; 
            case ItemType.greenGlasses:     return ItemAssets.Instance.greenSprite; 
            case ItemType.redGlasses:       return ItemAssets.Instance.redSprite;
            case ItemType.orangeGlasses:    return ItemAssets.Instance.orangeSprite; 
            case ItemType.purpleGlasses:    return ItemAssets.Instance.purpleSprite; 
        }


    }

}
