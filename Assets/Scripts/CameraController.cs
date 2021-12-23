using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    private InputControl inputControl;
    public float mSensitivity = 25f;
    float moveY, moveX, mScroll, click;

    void Awake()
    {
        inputControl = new InputControl();

        inputControl.Cam.Zoom.performed += ctx => mScroll = ctx.ReadValue<float>();
        inputControl.Cam.Zoom.canceled += ctx => mScroll = ctx.ReadValue<float>();

        inputControl.Cam.Move.started += ctx => click = ctx.ReadValue<float>();
        inputControl.Cam.Move.performed += ctx => click = ctx.ReadValue<float>();

    }

    public void OnEnable() => inputControl.Enable();
    public void OnDisable() => inputControl.Disable();

    void Update()
    {
        if (click == 1)
        {
            moveY += inputControl.Cam.YAxis.ReadValue<float>() * mSensitivity * Time.deltaTime;
            moveX += inputControl.Cam.XAxis.ReadValue<float>() * mSensitivity * Time.deltaTime;
            moveY = Mathf.Clamp(moveY, -90, 90);
            transform.eulerAngles = new Vector3(moveY, -moveX, 0);
        }
        if (mScroll > 0)
        {
            gameObject.GetComponent<Camera>().fieldOfView -= 10;
            mSensitivity -= 3;
        }
        if (mScroll < 0)
        {
            gameObject.GetComponent<Camera>().fieldOfView += 10;
            mSensitivity += 3;
        }
        gameObject.GetComponent<Camera>().fieldOfView = Mathf.Clamp(gameObject.GetComponent<Camera>().fieldOfView, 10, 100);
        mSensitivity = Mathf.Clamp(mSensitivity, 1, 20);
    }
}
