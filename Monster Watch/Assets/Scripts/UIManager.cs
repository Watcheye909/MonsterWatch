using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static bool inUI;

    public GameObject searchPrompt;
    
    void Start()
    {
        inUI = false;
        searchPrompt.SetActive(false);
    }
    
    //Checking if the player is using the UI.
    void Update()
    {
        if (searchPrompt.activeInHierarchy)
        {
            //Debug.Log("active");
            inUI = true;
        }
        else
        {
            inUI = false;
        }
    }

    //Functionality for every button that says no.
    public void NoButton(GameObject prompt)
    {
        prompt.SetActive(false);
    }

    

}
