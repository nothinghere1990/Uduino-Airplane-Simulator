using System;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public ADXL345_Test adxl345Test;
    [Range(0f, 10f)] public float sensitivity;
    [Range(0f, 100f)] public float speed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);

        transform.Rotate(- adxl345Test.ay * sensitivity,- adxl345Test.ax * sensitivity / 3 , adxl345Test.ax * sensitivity);
    }
}