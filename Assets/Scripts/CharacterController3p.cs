using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController3p : MonoBehaviour
{
    public float Speed = 5;
    const string HorizontalAxisName = "Horizontal";
    const string VerticalAxisName = "Vertical";

    public float JumpForce = 5;
    const string JumpName = "Jump";
    Rigidbody rb;

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
        if (Input.GetButtonDown(JumpName))
        {
            rb.velocity = new Vector3(0, JumpForce, 0);
        }

        transform.Translate(movement);

    }
}
