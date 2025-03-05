using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
 private Vector2 mousePosition;
    public float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        mousePosition = new Vector2(0,0);
        transform.position = new Vector2(0,0);
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }
}
