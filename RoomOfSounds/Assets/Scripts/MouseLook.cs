using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 300f;
    public Transform body;

    float yRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        // Debug.Log("ROT: " + transform.rotation.y);
        GameObject.FindObjectOfType<Connection>().pRotation = transform.rotation.y;

        transform.localRotation = Quaternion.Euler(yRotation, 0f, 0f);
        body.Rotate(Vector3.up * mouseX);
    }
}