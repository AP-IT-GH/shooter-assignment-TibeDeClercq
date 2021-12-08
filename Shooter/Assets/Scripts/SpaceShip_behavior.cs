using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip_behavior : MonoBehaviour
{
    private Rigidbody rb;
    public int direction;

    private float originalHeight;
    private float height = 0f;
    private int maxHeight = 4;
    private int minHeight = -4;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalHeight = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = -1;
        }
        else
        {
            direction = 0;
        }
        
    }

    void FixedUpdate()
    {
        if(direction == 1 && height < maxHeight)
        {
            height += 0.1f;
        }
        else if(direction == -1 && height > minHeight)
        {
            height -= 0.1f;
        }

        transform.position = new Vector3(transform.position.x, originalHeight + height, transform.position.z);
    }
}
