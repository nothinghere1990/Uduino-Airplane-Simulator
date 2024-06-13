using System;
using UnityEngine;
using Uduino;

public class ADXL345_Test : MonoBehaviour
{
    public float ax;
    public float ay;
    public float az;


    void Start()
    {
        UduinoManager.Instance.OnValueReceived += OnValueReceived;
    }

    void OnValueReceived(string data, UduinoDevice board)
    {
        // 解析數據
        string[] values = data.Split(" ");
        ax = float.Parse(values[0]);
        ay = float.Parse(values[1]);
        az = float.Parse(values[2]);
    }
}