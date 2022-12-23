using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private Rigidbody2D rb;

    public Rigidbody2D grapple;
    public float moveSpeed = 4.5f;
    Vector2 movement;

    public int movementInt;
    public bool[] movementArray = new bool[] { false, false, false, false };

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey("w"))
        {
            movementInt = 1;
            movementArray[0] = true;
        }
        else if (Input.GetKey("d"))
        {
            movementInt = 2;
            movementArray[1] = true;
        }
        else if (Input.GetKey("s"))
        {
            movementInt = 3;
            movementArray[2] = true;
        }
        else if (Input.GetKey("a")) 
        {
            movementInt = 4;
            movementArray[3] = true;
        }
        else 
        {
            movementInt = 0;
            movementArray[0] = false;
            movementArray[1] = false;
            movementArray[2] = false;
            movementArray[3] = false;
        }

        if (Input.GetKeyUp("w"))
        {
            movementInt = 1;
            movementArray[0] = false;
        }
        else if (Input.GetKeyUp("d"))
        {
            movementInt = 2;
            movementArray[1] = false;
        }
        else if (Input.GetKeyUp("s"))
        {
            movementInt = 3;
            movementArray[2] = false;
        }
        else if (Input.GetKeyUp("a"))
        {
            movementInt = 4;
            movementArray[3] = false;
        }


    }



    void FixedUpdate() 
    {
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
        if (movementInt == 0) 
        {
            grapple.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
        if (movementInt == 1) 
        {
            grapple.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
        if (movementInt == 2) 
        {
            //movement.x = Input.GetAxisRaw("Horizontal");
            //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        }
    }
}
