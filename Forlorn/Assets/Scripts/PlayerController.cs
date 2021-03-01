using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;

    public LayerMask stopMovement;
    private Animator playerAnimator = null;

    private static bool playerExists;

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
        float verticalInput = Input.GetAxisRaw("Vertical");
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        // Player moves toward the PlayerMovePoint
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        // Checks the distance first before moving
        if (Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
        {
            // Checking if there is any horizontal input, left or right
            if (Mathf.Abs(horizontalInput) == 1f)
            {
                // Checks to see if there is something ahead
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(horizontalInput, 0f, 0f), 0.2f, stopMovement))
                {
                    movePoint.position += new Vector3(horizontalInput, 0f, 0f);
                }
            }
            // Checking if there is any vertical input, up or down
            else if (Mathf.Abs(verticalInput) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, verticalInput, 0f), 0.2f, stopMovement))
                {
                    movePoint.position += new Vector3(0f, verticalInput, 0f);
                }
            }
        }


        bool isFront = verticalInput < 0;
        bool isBack = verticalInput > 0;
        bool isLeft = horizontalInput < 0;
        bool isRight = horizontalInput > 0;
        bool isIdle = horizontalInput == 0 && verticalInput == 0;

        // Animator
        playerAnimator.SetBool("isFront", isFront);

        playerAnimator.SetBool("isBack", isBack);

        playerAnimator.SetBool("isLeft", isLeft);

        playerAnimator.SetBool("isRight", isRight);

        playerAnimator.SetBool("isIdle", isIdle);



    }
}
