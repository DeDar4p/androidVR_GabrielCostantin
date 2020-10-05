using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoviment : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpheigh = 3f;
    Vector3 velocitity;
    bool isgrounded;
    public Transform GroundCheck;
    public float groundDistance = 0.3f;
    public LayerMask groundMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);
        if(isgrounded && velocitity.y < 0)
        {
            velocitity.y = 0f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
      
        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isgrounded)
        {
            velocitity.y = Mathf.Sqrt(jumpheigh * -2 * gravity);
        }

        velocitity.y += gravity * Time.deltaTime;

        controller.Move(velocitity * Time.deltaTime);

    }
}
