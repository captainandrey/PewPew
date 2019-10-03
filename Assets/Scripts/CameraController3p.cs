using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController3p : MonoBehaviour
{

    public float RotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;
    const string mouseXName = "Mouse X";
    const string mouseYName = "Mouse Y";

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        MoveCamera();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveCamera()
    {
        mouseX += Input.GetAxis(mouseXName) * RotationSpeed;
        mouseY += Input.GetAxis(mouseYName) * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);

        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);

    }
}
