using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    Vector3 movement;
    Vector2 mouseInput;
    CharacterController characterController;
    public Camera cam;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        movement.y = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        characterController.Move(movement);
        // mouseInput.x=Input.GetAxis("Mouse X");
        // mouseInput.y=Input.GetAxis("Mouse Y");
        mouseInput = new Vector2(Input.GetAxis("Mouse X") * rotationSpeed, Input.GetAxis("Mouse Y") * rotationSpeed);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);
        // cam.transform.rotation = Quaternion.Euler(cam.transform.rotation.eulerAngles.x + (-mouseInput.y), cam.transform.rotation.eulerAngles.y, cam.transform.rotation.eulerAngles.z);
        cam.transform.rotation = Quaternion.Euler(cam.transform.rotation.eulerAngles + new Vector3(-mouseInput.y, 0f, 0f));
    }
}