using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    public float jumpspeed = 4f;

    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(Input.GetKey("a") || Input.GetKey("left"))
        {
            body.velocity = new Vector2(-speed, body.velocity.y);
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            body.velocity = new Vector2(speed, body.velocity.y);
        }
        else
        {
            body.velocity = new Vector2 (0, body.velocity.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
