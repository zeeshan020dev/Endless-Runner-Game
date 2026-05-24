using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;

    [Header("Movement Settings")]
    public float forwardSpeed;
    public float maxSpeed = 15f;
    public float speedIncreaseRate = 0.1f;
    public float laneDistance = 4;
    private int desiredLane = 1; // 0:Left, 1:Mid, 2:Right

    [Header("Jump & Physics")]
    public float jumpForce = 10f;
    public float gravity = -20f;

    [Header("Sliding")]
    public Animator animator;
    private bool isSliding = false;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Guard Clause: Only run logic if game has started
        if (!PlayerManager.isGameStarted) return;

        // 1. Gradually Increase Speed (Optimized for WebGL)
        if (forwardSpeed < maxSpeed)
            forwardSpeed += speedIncreaseRate * Time.deltaTime;

        direction.z = forwardSpeed;

        // 2. Handling Jump
        if (controller.isGrounded)
        {
            direction.y = -1;
            // Using Space as a secondary WebGL-friendly jump key
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
        else
        {
            direction.y += gravity * Time.deltaTime;
        }

        // 3. Sliding Logic
        if (Input.GetKeyDown(KeyCode.DownArrow) && !isSliding)
        {
            StartCoroutine(Slide());
        }

        // 4. Lane Switching Input
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 3) desiredLane = 2;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1) desiredLane = 0;
        }

        // 5. Calculate Target Position
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desiredLane == 0) targetPosition += Vector3.left * laneDistance;
        else if (desiredLane == 2) targetPosition += Vector3.right * laneDistance;

        // Optimized Lerp for WebGL (using a fixed step for smoothness)
        if (transform.position != targetPosition)
        {
            Vector3 diff = targetPosition - transform.position;
            Vector3 moveDir = diff.normalized * 25 * Time.deltaTime;
            if (moveDir.sqrMagnitude < diff.sqrMagnitude)
                controller.Move(moveDir);
            else
                controller.Move(diff);
        }
    }

    private void FixedUpdate()
    {
        if (!PlayerManager.isGameStarted) return;
        controller.Move(direction * Time.fixedDeltaTime);
    }

    private void Jump()
    {
        direction.y = jumpForce;
        animator.SetTrigger("isJumping"); // Trigger for WebGL efficiency
    }

    private IEnumerator Slide()
    {
        isSliding = true;
        animator.SetBool("isSliding", true);

        // Change Collider to pass under obstacles
        controller.center = new Vector3(0, -0.5f, 0);
        controller.height = 1f;

        yield return new WaitForSeconds(1.3f);

        
        controller.center = new Vector3(0, 0, 0);
        controller.height = 2f;

        animator.SetBool("isSliding", false);
        isSliding = false;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.CompareTag("Obstacle") && !PlayerManager.gameOver)
        {
            PlayerManager.gameOver = true;
            if (AudioManager.instance != null)
            {
                AudioManager.instance.PlaySound("GameOver");
            }
        }
    }
}