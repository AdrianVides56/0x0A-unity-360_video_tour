// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControl"",
    ""maps"": [
        {
            ""name"": ""Cam"",
            ""id"": ""33f5220d-67d6-468e-9ef3-055a76cbd8aa"",
            ""actions"": [
                {
                    ""name"": ""XAxis"",
                    ""type"": ""Value"",
                    ""id"": ""18ecc51c-25aa-4271-8eca-6a1d87e69543"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""YAxis"",
                    ""type"": ""Value"",
                    ""id"": ""b5f5afd3-5b4c-45fd-92f0-7e1aacd4dabb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""c64df461-4f7f-49d9-8d0a-40d46c64fa48"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7c92684c-82dc-4f9f-9a84-62fb42fde346"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""SlowTap(duration=0.01,pressPoint=0.1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""897c65cf-4c09-4c5c-9b7d-b909ebf276f9"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fada6ab3-290c-44e0-99ef-678932c3b983"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80b4892c-d5ac-47f0-bab1-e3763a2a0e90"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec465f6c-d95c-4c33-8c05-c155eb0a5151"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Cam
        m_Cam = asset.FindActionMap("Cam", throwIfNotFound: true);
        m_Cam_XAxis = m_Cam.FindAction("XAxis", throwIfNotFound: true);
        m_Cam_YAxis = m_Cam.FindAction("YAxis", throwIfNotFound: true);
        m_Cam_Zoom = m_Cam.FindAction("Zoom", throwIfNotFound: true);
        m_Cam_Move = m_Cam.FindAction("Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Cam
    private readonly InputActionMap m_Cam;
    private ICamActions m_CamActionsCallbackInterface;
    private readonly InputAction m_Cam_XAxis;
    private readonly InputAction m_Cam_YAxis;
    private readonly InputAction m_Cam_Zoom;
    private readonly InputAction m_Cam_Move;
    public struct CamActions
    {
        private @InputControl m_Wrapper;
        public CamActions(@InputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @XAxis => m_Wrapper.m_Cam_XAxis;
        public InputAction @YAxis => m_Wrapper.m_Cam_YAxis;
        public InputAction @Zoom => m_Wrapper.m_Cam_Zoom;
        public InputAction @Move => m_Wrapper.m_Cam_Move;
        public InputActionMap Get() { return m_Wrapper.m_Cam; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CamActions set) { return set.Get(); }
        public void SetCallbacks(ICamActions instance)
        {
            if (m_Wrapper.m_CamActionsCallbackInterface != null)
            {
                @XAxis.started -= m_Wrapper.m_CamActionsCallbackInterface.OnXAxis;
                @XAxis.performed -= m_Wrapper.m_CamActionsCallbackInterface.OnXAxis;
                @XAxis.canceled -= m_Wrapper.m_CamActionsCallbackInterface.OnXAxis;
                @YAxis.started -= m_Wrapper.m_CamActionsCallbackInterface.OnYAxis;
                @YAxis.performed -= m_Wrapper.m_CamActionsCallbackInterface.OnYAxis;
                @YAxis.canceled -= m_Wrapper.m_CamActionsCallbackInterface.OnYAxis;
                @Zoom.started -= m_Wrapper.m_CamActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CamActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CamActionsCallbackInterface.OnZoom;
                @Move.started -= m_Wrapper.m_CamActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CamActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CamActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CamActionsCallbackInterface = instance;
            if (instance != null)
            {
                @XAxis.started += instance.OnXAxis;
                @XAxis.performed += instance.OnXAxis;
                @XAxis.canceled += instance.OnXAxis;
                @YAxis.started += instance.OnYAxis;
                @YAxis.performed += instance.OnYAxis;
                @YAxis.canceled += instance.OnYAxis;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CamActions @Cam => new CamActions(this);
    public interface ICamActions
    {
        void OnXAxis(InputAction.CallbackContext context);
        void OnYAxis(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
