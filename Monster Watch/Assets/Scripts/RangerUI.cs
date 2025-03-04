using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangerUI : MonoBehaviour
{
    public int rangerNumber;
    public SpriteRenderer sprite;
    public Sprite circle;
    

    void Start()
    {
        circle = sprite.sprite;
    }

    void Update()
    {
        if (MapBackground.availableRangers >= rangerNumber)
        {
            sprite.sprite = circle;
        }
        else
        {
            sprite.sprite = null;
            
        }
    }
}
