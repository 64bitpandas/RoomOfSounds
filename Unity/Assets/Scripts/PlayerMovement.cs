using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  

    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        // Debug.Log("X: " + transform.position.x);
        // Debug.Log("Y: " + transform.position.y);
        GameObject.FindObjectOfType<Connection>().pxPos = transform.position.x;
        GameObject.FindObjectOfType<Connection>().pyPos = transform.position.z;

        Vector3 move = transform.right * x + transform.forward * z;
        GetComponent<CharacterController>().Move(move * Time.deltaTime * speed);
    }
}
