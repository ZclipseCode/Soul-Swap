using UnityEngine;
using UnityEngine.InputSystem;

//[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    //[SerializeField] CharacterController controller;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject playerObject;
    [SerializeField] Vector3 playerVelocity;
    [SerializeField] bool groundedPlayer;
    [SerializeField] float playerSpeed = 2.0f;
    //[SerializeField] float jumpHeight = 1.0f;
    //[SerializeField] float gravityValue = -9.81f;
    [SerializeField] GameObject aimCursor;

    private Vector2 movementInput = Vector2.zero;
    private Vector2 aimInput = Vector2.zero;
    private float rotateAimValue;

    private void Start()
    {
        //controller = gameObject.GetComponent<CharacterController>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnAim(InputAction.CallbackContext context)
    {
        aimInput = context.ReadValue<Vector2>();
    }

    void Update()
    {
        aimCursor.transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y, playerObject.transform.position.z);


        //groundedPlayer = controller.isGrounded;
        //if (groundedPlayer && playerVelocity.y < 0)
        //{
        //    playerVelocity.y = 0f;
        //}

        Vector2 move = new Vector2(movementInput.x, movementInput.y);
        //playerObject.Move(move * Time.deltaTime * playerSpeed);
        rb.velocity = new Vector2(movementInput.x * playerSpeed, movementInput.y * playerSpeed);

        if (move != Vector2.zero)
        {
            gameObject.transform.forward = move;
        }

        Vector2 aim = new Vector2(aimInput.x, aimInput.y);
        rotateAimValue = Mathf.Atan(aimInput.y / aimInput.x) * Mathf.Rad2Deg;

        if (aimInput.x > 0)
        {
            aimCursor.transform.rotation = Quaternion.Euler(0, 0, rotateAimValue - 90);
        }
        else if (aimInput.x < 0)
        {
            aimCursor.transform.rotation = Quaternion.Euler(0, 0, rotateAimValue + 90);
        }



        playerObject.transform.rotation = Quaternion.Euler(0, 0, 0);

        //// Changes the height position of the player..
        //if (Input.GetButtonDown("Jump") && groundedPlayer)
        //{
        //    playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        //}

        //playerVelocity.y += gravityValue * Time.deltaTime;
        //controller.Move(playerVelocity * Time.deltaTime);
    }
}
