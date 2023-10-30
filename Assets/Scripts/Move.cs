using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D body;
    public float horizontal;
    public float vertical;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        //Saved this piece of code because of its referens to the keyboard keys, useful for activating
        //certain types of events when pressing down a button, like abilities or menu.
        /*
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = transform.position + new Vector3(0.1f, 0, 0);
        }
        */
    }

    //FixedUpdate is called 50 times per second
    private void FixedUpdate()
    {
        body.velocity = new Vector2 (horizontal * speed, vertical * speed);
    }
}
