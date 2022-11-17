using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    private int movement = 125;
    private float speed = 300f;
    private int limit = 250;

    private bool canMove = true;
    private Vector3 nextPosition;


    void Update()
    {
        // Input key movements and conditions met to move
        if (Input.GetKeyDown(KeyCode.RightArrow) && canMove)
        {
            if (transform.position.x != limit) 
            {
                nextPosition = new Vector3(transform.position.x + movement, transform.position.y, transform.position.z);
            }
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow) && canMove) 
        {
            if (transform.position.x != -limit)
            {
                nextPosition = new Vector3(transform.position.x - movement, transform.position.y, transform.position.z);
            }
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow) && canMove) 
        {
            if (transform.position.y != limit)
            {
                nextPosition = new Vector3(transform.position.x, transform.position.y + movement, transform.position.z);
            }
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && canMove) 
        {
            if (transform.position.y != -limit)
            {
                nextPosition = new Vector3(transform.position.x, transform.position.y - movement, transform.position.z);
            }
        }

        // Movement comand
        if (nextPosition != transform.position) 
        {           
            Moving();
        }
        if (nextPosition == transform.position)
        {
            canMove = true;
        }
    }

    // While moving you cant change the direction
    public void Moving()
    {
        canMove = false;

        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);
    }
}
