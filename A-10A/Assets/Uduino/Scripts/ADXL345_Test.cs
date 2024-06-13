using System;
using UnityEngine;
using Uduino;

public class ADXL345_Test : MonoBehaviour
{
    public float ax;
    public float ay;
    public float az;
    public volatile float stickX;
    public volatile float stickY;
    public volatile float stickBtn;
    
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

        stickX = float.Parse(values[3]) - 508;
        stickY = float.Parse(values[4]) - 508;
        stickBtn = float.Parse(values[5]);
    }
}