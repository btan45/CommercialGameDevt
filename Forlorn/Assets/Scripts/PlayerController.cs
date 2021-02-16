using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;

    // Start is called before the first frame update
    void Start()
    {
        // Makes sure that PlayerMovePoint is not a child
        movePoint.parent = null;

    }

    // Update is called once per frame
    void Update()
    {
        // Player moves toward the PlayerMovePoint
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        // Checks the distance first before moving
        if(Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
        {
            // Checking if there is any horizontal input, left or right
            if( Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }
            // Checking if there is any vertical input, up or down
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
            }
        }

    }
}
