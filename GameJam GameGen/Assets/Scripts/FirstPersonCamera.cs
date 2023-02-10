using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FirstPersonCamera : MonoBehaviour
{

    public Transform player;
    public float mouseSense = 2f;
    private float cameraVerticalRotation = 0f;

    private bool lockCursor = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible= false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Mouse X")*mouseSense*Time.deltaTime;
        float inputY = Input.GetAxis("Mouse Y")*mouseSense*Time.deltaTime;

        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);  
        transform.localEulerAngles = Vector3.right* cameraVerticalRotation;

        player.Rotate(Vector3.up * inputX);
    }
}
