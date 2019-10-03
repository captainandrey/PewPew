using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController3p : MonoBehaviour
{
    public float Speed = 5;
    public const string HorizontalAxisName = "Horizontal";
    public const string VerticalAxisName = "Vertical";
    public const string JumpName = "Jump";
    Rigidbody rb;
    public float JumpForce = 5;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        var horizontalInput = Input.GetAxis(HorizontalAxisName);
        var verticalInput = Input.GetAxis(VerticalAxisName);
        var movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * Speed * Time.deltaTime;


        //JUMP
        var y = rb.velocity.y;
        if (Input.GetButtonDown(JumpName))
        {
            y = JumpForce;
        }
        rb.velocity = new Vector3(0, y, 0);



        transform.Translate(movement, Space.Self);

    }
}
