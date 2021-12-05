using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Tilescode : MonoBehaviour
{
    public enum TileType
    { 
        Blank,
        Ghost, 
        Clue
    }
    public bool covered = true;
    public Sprite coveredSprite;
    public Tiletype tiletype = Tiletype.Blank;
    public TextMeshPro probability;

    private Sprite defaultSprite;

    void Start( ) { 
        defaultSprite = GetComponent<SpriteRenderer>().sprite; 
        GetComponent<SpriteRenderer>().sprite=coveredSprite; 
        
    }

    public void SetCovered (bool covered)
     { 
         
            covered=false; 
            GetComponent<SpriteRenderer>().sprite=defaultSprite; 
            
            
    }

    
}
