using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FirstPersonCamera : MonoBehaviour
{

    public Transform player;
    public float mouseSense = 2f;
    private float cameraVerticalRotation = 0f;

    public TMP_InputField tmproText;
    public Slider slider;
    // Start is called before the first frame update

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.onMenu && !GameManager.onDialogue)
        {
            float inputX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
            float inputY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;

            cameraVerticalRotation -= inputY;
            cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(cameraVerticalRotation, 0f, 0f);

            player.Rotate(Vector3.up * inputX);
        }
    }

}
