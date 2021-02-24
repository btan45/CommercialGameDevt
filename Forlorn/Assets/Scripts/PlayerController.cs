using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;

    public LayerMask stopMovement;
    private Animator playerAnimator = null;

    // Start is called before the first frame update
    void Start()
    {
        // Makes sure that PlayerMovePoint is not a child
        movePoint.parent = null;

        playerAnimator = GetComponent<Animator>();
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

                // Checks to see if there is something ahead
                if ( !Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), 0.2f, stopMovement))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }
            // Checking if there is any vertical input, up or down
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), 0.2f, stopMovement))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }

        // Animator
        if (Input.GetKey("down"))
        {
            playerAnimator.SetBool("isFront", true);
        }
        else if (Input.GetKey("up"))
        {
            playerAnimator.SetBool("isBack", true);
        }
        else if (Input.GetKey("left"))
        {
            playerAnimator.SetBool("isLeft", true);
        }
        else if (Input.GetKey("right"))
        {
            playerAnimator.SetBool("isRight", true);
        }
      
    }
}
