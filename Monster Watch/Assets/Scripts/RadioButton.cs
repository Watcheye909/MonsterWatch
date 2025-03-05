using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButton : MonoBehaviour
{
    public Radio radio;
    public bool inRange;
    
    public int radioChannel;
    private int rangerChannel;


    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.Mouse0))
        {
            radio.currentChannel = radioChannel;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            inRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            inRange = false;
        }
    }
}
