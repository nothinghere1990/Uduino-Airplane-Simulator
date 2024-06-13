using UnityEngine;

public class DynamicCameraFollow : MonoBehaviour
{
    public GameObject targetObject;  // 3D物件
    private Transform targetTransform;
    public Vector3 offset;           // 相機相對於3D物件的位置偏移

    void Start()
    {
        if (targetObject != null)
        {
            targetTransform = targetObject.transform;
            // 將Main Camera設置為目標物件的子對象
            transform.SetParent(targetTransform);
            // 設置相機的初始位置和旋轉
            transform.localPosition = offset;
            transform.localRotation = Quaternion.identity;
        }
    }

    void Update()
    {
        // 如果需要在運行時動態更新相機的位置和旋轉，可以在Update中進行
        if (targetTransform != null)
        {
            transform.localPosition = offset;
            transform.localRotation = Quaternion.identity;
        }
    }
}