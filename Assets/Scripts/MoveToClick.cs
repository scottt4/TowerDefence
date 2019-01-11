using UnityEngine;
using System.Collections;

public class MoveToClick : MonoBehaviour
{
    // Coordinates to move from (oldPos) to new (newPos)
    private Vector3 oldPos;
    private Vector3 newPos;

    // Don't allow mouse clicks while still moving
    private bool canReceiveInput;
    private bool destinationReached;

    private float movement;
    private SpriteRenderer render;

    private void Awake()
    {
        render = GetComponent<SpriteRenderer>();
        oldPos = gameObject.transform.position;

        canReceiveInput = true;
        movement = 0;
    }

    void Update()
    {
        // If we reached the destination, reset the weapon and allow for input again. Reset rotation if needed.
        if (destinationReached)
        {
            destinationReached = false;
            render.flipX = false;
            render.flipY = false;

            canReceiveInput = true;

            gameObject.transform.position = oldPos;
            movement = 0;
        }
        // If we haven not reached the destination, check how close we are. If we are really close, we shortcut the LERP function.
        else if ((int)gameObject.transform.position.x == (int)newPos.x && (int)gameObject.transform.position.y == (int)newPos.y)
        {
            destinationReached = true;
        }
        // If we have not reached the destination, and are not close to it either.
        else
        {
            // If (Input.GetMouseButton(0) would allow for us to manually fire.
            if (canReceiveInput)
            {
                canReceiveInput = false;
                newPos = Input.mousePosition;
                newPos = Camera.main.ScreenToWorldPoint(newPos);
                newPos.z = 0.0f;
            }
            else
            {
                movement += Time.deltaTime;
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, newPos, movement);
            }
        }
        // Rotate if object is still moving
        if ((gameObject.transform.position != oldPos) && !destinationReached)
        {
            Rotate();
        }
    }

    // Extract to another class later
    void Rotate()
    {
        if (!render.flipX && !render.flipY)
        {
            render.flipY = true;
        }
        else if (!render.flipX && render.flipY)
        {
            render.flipX = true;
        }
        else if (render.flipX && render.flipY)
        {
            render.flipY = false;
        }
        else
        {
            render.flipX = false;
        }
    }
}
