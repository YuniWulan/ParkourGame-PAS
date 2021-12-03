using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    //variable
    public GameObject player;
    public float speed = 2f;
    public Rigidbody rb;
    public Vector3 jump;
    public float jumpForce = 10.5f;
    public bool isGrounded;

    private float xInput;
    private float yInput;
   
    void Start()
    {
     
        Debug.Log("started");

        //set rb var
        rb = GetComponent<Rigidbody>();
        //set jump var
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //get Input
        xInput = Input.GetAxis("Horizontal") * speed;
        yInput = Input.GetAxis("Vertical") * speed;


        //Jump Input
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }


    }

    private void FixedUpdate()
    {
        //apply movement
        Vector3 moveDirection = new Vector3(xInput, 0f, yInput) * speed;
        transform.position += moveDirection; 
    }

    //Jika cube tidak di udara
    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
}
