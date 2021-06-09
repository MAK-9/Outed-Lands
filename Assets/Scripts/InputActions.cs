// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Jetpack"",
            ""id"": ""238bedb0-bf8e-4ffc-af54-4c62f71e35d6"",
            ""actions"": [
                {
                    ""name"": ""LookAround"",
                    ""type"": ""PassThrough"",
                    ""id"": ""379833f1-6455-4576-ad6e-35208e7b822b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WSAD"",
                    ""type"": ""Button"",
                    ""id"": ""7f864acb-5d7c-467a-bea3-bbae09294ee7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""200fea5b-80a3-4a76-8d3d-ab9987f88a2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""20ace39d-0dd8-4a7d-865d-8c69aca18b8e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookAround"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WSAD"",
                    ""id"": ""1214bee1-9faf-449a-a284-f97520a33ca1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WSAD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1474010a-8a0f-4a29-9df5-77338a734d14"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WSAD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a3c0f9e5-ee62-4aa5-bc62-81b2dc4a5b3f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WSAD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4863be73-a553-4413-8014-df3bc5b69709"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WSAD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fdcfd790-6983-4c30-bd56-1ed9e85ba040"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WSAD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""50ada1e7-78e5-41dd-b510-87235ed0ce42"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""0485a44a-08e7-466a-986f-3c6018e6a779"",
            ""actions"": [
                {
                    ""name"": ""Look Up/Down"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f956f65a-cfb0-400c-8098-74731af9438c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b713df61-76af-465d-9fca-5538a5c613c9"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look Up/Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Jetpack
        m_Jetpack = asset.FindActionMap("Jetpack", throwIfNotFound: true);
        m_Jetpack_LookAround = m_Jetpack.FindAction("LookAround", throwIfNotFound: true);
        m_Jetpack_WSAD = m_Jetpack.FindAction("WSAD", throwIfNotFound: true);
        m_Jetpack_Jump = m_Jetpack.FindAction("Jump", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_LookUpDown = m_Camera.FindAction("Look Up/Down", throwIfNotFound: true);
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

    // Jetpack
    private readonly InputActionMap m_Jetpack;
    private IJetpackActions m_JetpackActionsCallbackInterface;
    private readonly InputAction m_Jetpack_LookAround;
    private readonly InputAction m_Jetpack_WSAD;
    private readonly InputAction m_Jetpack_Jump;
    public struct JetpackActions
    {
        private @InputActions m_Wrapper;
        public JetpackActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LookAround => m_Wrapper.m_Jetpack_LookAround;
        public InputAction @WSAD => m_Wrapper.m_Jetpack_WSAD;
        public InputAction @Jump => m_Wrapper.m_Jetpack_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Jetpack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JetpackActions set) { return set.Get(); }
        public void SetCallbacks(IJetpackActions instance)
        {
            if (m_Wrapper.m_JetpackActionsCallbackInterface != null)
            {
                @LookAround.started -= m_Wrapper.m_JetpackActionsCallbackInterface.OnLookAround;
                @LookAround.performed -= m_Wrapper.m_JetpackActionsCallbackInterface.OnLookAround;
                @LookAround.canceled -= m_Wrapper.m_JetpackActionsCallbackInterface.OnLookAround;
                @WSAD.started -= m_Wrapper.m_JetpackActionsCallbackInterface.OnWSAD;
                @WSAD.performed -= m_Wrapper.m_JetpackActionsCallbackInterface.OnWSAD;
                @WSAD.canceled -= m_Wrapper.m_JetpackActionsCallbackInterface.OnWSAD;
                @Jump.started -= m_Wrapper.m_JetpackActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_JetpackActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_JetpackActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_JetpackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LookAround.started += instance.OnLookAround;
                @LookAround.performed += instance.OnLookAround;
                @LookAround.canceled += instance.OnLookAround;
                @WSAD.started += instance.OnWSAD;
                @WSAD.performed += instance.OnWSAD;
                @WSAD.canceled += instance.OnWSAD;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public JetpackActions @Jetpack => new JetpackActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_LookUpDown;
    public struct CameraActions
    {
        private @InputActions m_Wrapper;
        public CameraActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LookUpDown => m_Wrapper.m_Camera_LookUpDown;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @LookUpDown.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnLookUpDown;
                @LookUpDown.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnLookUpDown;
                @LookUpDown.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnLookUpDown;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LookUpDown.started += instance.OnLookUpDown;
                @LookUpDown.performed += instance.OnLookUpDown;
                @LookUpDown.canceled += instance.OnLookUpDown;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IJetpackActions
    {
        void OnLookAround(InputAction.CallbackContext context);
        void OnWSAD(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnLookUpDown(InputAction.CallbackContext context);
    }
}
