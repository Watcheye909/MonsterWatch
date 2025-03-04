using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBackground : MonoBehaviour
{
    public static Vector3 SearchPos;
    public static int availableRangers;
    public GameObject searchPrompt;

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
        if (UIManager.inUI == false)
        {
            Debug.Log("click");

            SearchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (availableRangers > 0)
            {
                searchPrompt.SetActive(true);
            }
        }
    }
}
