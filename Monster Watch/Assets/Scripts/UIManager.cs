using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static bool inUI;

    public GameObject searchPrompt;
    public GameObject Ranger;
    public GameObject Tower1;
    public GameObject Tower2;
    public GameObject Tower3;
    
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


    //Spawning the rangers
    public void SpawnRanger ()
    {
        float rand = Random.Range(0, 3);
        if (rand < 1.1f)
        {
            Instantiate(Ranger, Tower1.transform.position, Quaternion.identity);
            searchPrompt.SetActive(false);
        }
        else if (1 < rand && rand > 2.1f) 
        {
            Instantiate(Ranger, Tower2.transform.position, Quaternion.identity);
            searchPrompt.SetActive(false);
        }
        else if (rand > 2)
        {
            Instantiate(Ranger, Tower3.transform.position, Quaternion.identity);
            searchPrompt.SetActive(false);
        }

    }

}
