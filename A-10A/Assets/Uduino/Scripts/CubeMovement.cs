using System;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public ADXL345_Test adxl345Test;
    [Range(0f, 10f)] public float sensitivity;
    public float speed;
    public float rotateY;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        speed = adxl345Test.stickX;
        rotateY = adxl345Test.stickY / 2000;
        
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);

        transform.Rotate(- adxl345Test.ay * sensitivity,- adxl345Test.ax * sensitivity / 3 + rotateY , adxl345Test.ax * sensitivity);
    }
}