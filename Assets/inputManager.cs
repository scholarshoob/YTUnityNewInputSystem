// GENERATED AUTOMATICALLY FROM 'Assets/inputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""inputManager"",
    ""maps"": [
        {
            ""name"": ""MK"",
            ""id"": ""e0e110a8-cb02-4f9e-884e-fcc0e5263844"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""1a3f1245-6f88-4bed-a4c4-522af5232849"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cf1c90de-ab52-42ab-8ba5-e44750a55be5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""7a24a026-2779-463c-844c-20d0a8702468"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""e38fc12d-d6a1-45f2-b339-a7d199e47aac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""03d7bc33-68b9-4723-a2a4-e94f32826aad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2dca83d2-f912-4d22-a070-a7c1eac1a50f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MK"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a42e84d1-a302-4c73-b6ff-67369a53d744"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MK"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f608a715-19e6-487e-bb9d-974e838d76d6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MK"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""99e079bc-16bd-45ff-be47-1f02926c314a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MK"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""115c8ecf-6e93-4882-b3ee-2efbcd047c80"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MK"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d792410d-0f63-437b-afe6-66d22316a5de"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MK"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f82cd7b-18ba-425d-b4cd-ced8c3c12031"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MK"",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MK"",
            ""bindingGroup"": ""MK"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MK
        m_MK = asset.FindActionMap("MK", throwIfNotFound: true);
        m_MK_Movement = m_MK.FindAction("Movement", throwIfNotFound: true);
        m_MK_Jump = m_MK.FindAction("Jump", throwIfNotFound: true);
        m_MK_Shoot = m_MK.FindAction("Shoot", throwIfNotFound: true);
        m_MK_Mouse = m_MK.FindAction("Mouse", throwIfNotFound: true);
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

    // MK
    private readonly InputActionMap m_MK;
    private IMKActions m_MKActionsCallbackInterface;
    private readonly InputAction m_MK_Movement;
    private readonly InputAction m_MK_Jump;
    private readonly InputAction m_MK_Shoot;
    private readonly InputAction m_MK_Mouse;
    public struct MKActions
    {
        private @InputManager m_Wrapper;
        public MKActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_MK_Movement;
        public InputAction @Jump => m_Wrapper.m_MK_Jump;
        public InputAction @Shoot => m_Wrapper.m_MK_Shoot;
        public InputAction @Mouse => m_Wrapper.m_MK_Mouse;
        public InputActionMap Get() { return m_Wrapper.m_MK; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MKActions set) { return set.Get(); }
        public void SetCallbacks(IMKActions instance)
        {
            if (m_Wrapper.m_MKActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MKActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MKActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MKActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_MKActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MKActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MKActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_MKActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MKActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MKActionsCallbackInterface.OnShoot;
                @Mouse.started -= m_Wrapper.m_MKActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_MKActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_MKActionsCallbackInterface.OnMouse;
            }
            m_Wrapper.m_MKActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
            }
        }
    }
    public MKActions @MK => new MKActions(this);
    private int m_MKSchemeIndex = -1;
    public InputControlScheme MKScheme
    {
        get
        {
            if (m_MKSchemeIndex == -1) m_MKSchemeIndex = asset.FindControlSchemeIndex("MK");
            return asset.controlSchemes[m_MKSchemeIndex];
        }
    }
    public interface IMKActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
    }
}
