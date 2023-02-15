using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;

    public float speed = 1.0f;
    private float gravity = 4.5f;
    private float vSpeed;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (!GameManager.onMenu && !GameManager.onDialogue)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            
            if (characterController.isGrounded)
            {
                vSpeed = 0;
            }
            Vector3 move = transform.right * x + transform.forward * z;
            vSpeed -= gravity * Time.deltaTime;
            move.y = vSpeed;


            characterController.Move(move * speed * Time.deltaTime);
        }
    }
}