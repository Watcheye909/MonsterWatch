using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBackground : MonoBehaviour
{
    public static Vector3 SearchPos;
    public static int availableRangers;
    
    void Start()
    {
        availableRangers = 3;
    }

  
    void Update()
    {
        
    }


    //When a player clicks on the map.
    public void OnMouseDown()
    {
        Debug.Log("click");
        
        SearchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (availableRangers > 0)
        {

        }
    }
}
