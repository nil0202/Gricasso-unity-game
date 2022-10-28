using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{

    public static ItemAssets Instance { get; private set; }

    private void Awake(){

        Instance = this;

    }

    public Transform pfItemWorld;

    public Sprite redSprite;
    public Sprite orangeSprite;
    public Sprite blueSprite;
    public Sprite purpleSprite;
    public Sprite greenSprite;



}
