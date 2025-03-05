using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButton : MonoBehaviour
{

    public int buttonNumber;

    public static bool ranger1InPosition;
    public static bool ranger2InPosition;
    public static bool ranger3InPosition;

    void Start()
    {
        ranger1InPosition = false;
        ranger2InPosition = false;
        ranger3InPosition = false;
    }

    
    void Update()
    {
       
    }

    //When the button is clicked.
    private void OnMouseDown()
    {
        Debug.Log("Yes");
        if (UIManager.inUI == false)
        {
            if (buttonNumber == 1)
            {
                ranger1InPosition = false;
            }
            if (buttonNumber == 2)
            {
                ranger2InPosition = false;
            }
            if (buttonNumber == 3)
            {
                ranger3InPosition = false;
            }
        }
        
    }
}
