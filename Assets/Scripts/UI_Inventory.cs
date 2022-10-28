using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour {

    private Inventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;
    public Sprite redSprite;
    public Sprite blueSprite;
    public Sprite greenSprite;
    public Sprite orangeSprite;
    public Sprite purpleSprite;
    public Transform pfItemWorld;


    private void Start(){
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");
    }

    public void SetInventory(Inventory inventory){
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems(){
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 30f;
        foreach (Item item in inventory.GetItemList()){
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);

            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            Image image = itemSlotRectTransform.Find("image").GetComponent<Image>();

            if (item.itemType == Item.ItemType.blueGlasses) {
                image.sprite = blueSprite;
            }            
            else if (item.itemType == Item.ItemType.redGlasses) {
                image.sprite = redSprite;
            }
            else if (item.itemType == Item.ItemType.purpleGlasses) {
                image.sprite = purpleSprite;
            }
            else if (item.itemType == Item.ItemType.orangeGlasses) {
                image.sprite = orangeSprite;
            }
            else {
                image.sprite = greenSprite;
            }
            if (x >= 6){

                y = -2;
                x = 0;
            }
            else{
                x+=3;
            }

        }
    }

}
