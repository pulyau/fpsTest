using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform cam;
    public float MoveSpeed = 50f;
    public float MouseSensitivity = 4f;
    public float JumpForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.rotation = (cam.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime, 0)));
        cam.rotation =(cam.rotation * Quaternion.Euler(new Vector3(Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime,0 , 0)));

        rb.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed*Time.deltaTime) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed*Time.deltaTime));
        if (Input.GetKeyDown("space"))
            rb.AddForce(transform.up * JumpForce*Time.deltaTime, ForceMode.Impulse);

//test change
    }


}
