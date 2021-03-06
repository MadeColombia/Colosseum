using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt_Pointer : MonoBehaviour
{

    public Transform player;
    private float sensitivityX;
    private float mouseX;
    private float sensitivityY;
    private float mouseY;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.position + new Vector3(0, 2f, 0);

        this.sensitivityX = 4f;
        this.sensitivityY = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(0, 2f, 0);

        mouseX = Input.GetAxis("Mouse X") * sensitivityX;
        mouseY = Input.GetAxis("Mouse Y") * sensitivityY;

        Vector3 rotation = transform.eulerAngles;
        float rotationX;


        if (rotation.x > 90)
        {
            rotationX = rotation.x - 360;
        }
        else
        {
            rotationX = rotation.x;
        }

        if ((mouseY < 0 && rotationX < 75) || (mouseY > 0 && rotationX > -60))
        {
            transform.Rotate(-mouseY, 0, 0);
        }

        transform.RotateAround(transform.position, Vector3.up, this.mouseX);
    }
}