using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
<<<<<<< Updated upstream
{
 private Vector2 mousePosition;
    public float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
=======
{   
    [Header("Mouse Movement")]
    private Vector2 mousePosition;
    public float moveSpeed = 0.1f;

    [Header("Mouse State")]
    public bool objInRange;
    public bool clicking;
    
    [Header("Setup")]
    public LayerMask interactable;

    

    //NOT NEED SINCE THE RADIO'S BEEN DESTROYED VIOLENTLY
    //public Radio radio;
    //public int radioChannel;
    //private int rangerChannel;


    // Start is called before the first frame update
    void Start()
    {
        objInRange = false;
        clicking = false;

        //[MOUSE POSITION SETUP]
>>>>>>> Stashed changes
        mousePosition = new Vector2(0,0);
        transform.position = new Vector2(0,0);
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
=======
        if(objInRange && Input.GetKeyDown(KeyCode.Mouse0))
        {
            clicking = true;
        }
        else
        {
            clicking = false;
        }

        //[MOUSE MOVEMENT SETUP]
>>>>>>> Stashed changes
        Cursor.visible = false;
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }
<<<<<<< Updated upstream
=======

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == interactable)
        {
            objInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.layer == interactable)
        {
            objInRange = false;
        }
    }
>>>>>>> Stashed changes
}
