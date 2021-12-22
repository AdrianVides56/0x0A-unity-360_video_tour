using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    private InputControl inputControl;
    public float mSensitivity = 20f;
    float moveY, moveX;

    // Input Manager
    void Awake() => inputControl = new InputControl();
    public void OnEnable() => inputControl.Enable();
    public void OnDisable() => inputControl.Disable();

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            moveY = inputControl.Cam.YAxis.ReadValue<float>() * mSensitivity * Time.deltaTime;
            moveX = inputControl.Cam.XAxis.ReadValue<float>() * mSensitivity * Time.deltaTime;
            transform.Rotate(moveY, -moveX, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.Rotate(new Vector3(0,0,0));
        }
    }
}
