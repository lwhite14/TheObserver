// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/MasterControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MasterControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MasterControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MasterControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""33d76b72-bc68-4724-83b6-66172b187efc"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""88613a2d-95a2-452e-9865-3bfdb96161f7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move_ForwardBackward"",
                    ""type"": ""Button"",
                    ""id"": ""7e94a78c-f037-446e-8685-dba8843d3745"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move_Laterally"",
                    ""type"": ""Button"",
                    ""id"": ""4a9225ec-b807-4ea7-99fe-52f32391cfa7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b1fac3bc-d717-4acc-bdfa-ce419f5fe3f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f17d3879-0ca3-4f6b-b55f-80fe96b7061d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a973ab6f-4a2c-44de-9860-e9da619ea681"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""b7e6bea7-1907-4799-a3a9-03be41a34e33"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_ForwardBackward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ccc03555-4bc9-4d2e-ba6a-9426a5d944a7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move_ForwardBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5a2e235a-43b2-425e-b272-17d81bf4808d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move_ForwardBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""79472ab9-69a1-4c21-b3f7-24811ba8425a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Laterally"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a57d835f-e098-48ce-b0e6-cdb6ee953329"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move_Laterally"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2aef8b12-b7a9-4183-b257-a77da9b2c461"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move_Laterally"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard+Mouse"",
            ""bindingGroup"": ""Keyboard+Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Move_ForwardBackward = m_Player.FindAction("Move_ForwardBackward", throwIfNotFound: true);
        m_Player_Move_Laterally = m_Player.FindAction("Move_Laterally", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Move_ForwardBackward;
    private readonly InputAction m_Player_Move_Laterally;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @MasterControls m_Wrapper;
        public PlayerActions(@MasterControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Move_ForwardBackward => m_Wrapper.m_Player_Move_ForwardBackward;
        public InputAction @Move_Laterally => m_Wrapper.m_Player_Move_Laterally;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Move_ForwardBackward.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_ForwardBackward;
                @Move_ForwardBackward.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_ForwardBackward;
                @Move_ForwardBackward.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_ForwardBackward;
                @Move_Laterally.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_Laterally;
                @Move_Laterally.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_Laterally;
                @Move_Laterally.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove_Laterally;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Move_ForwardBackward.started += instance.OnMove_ForwardBackward;
                @Move_ForwardBackward.performed += instance.OnMove_ForwardBackward;
                @Move_ForwardBackward.canceled += instance.OnMove_ForwardBackward;
                @Move_Laterally.started += instance.OnMove_Laterally;
                @Move_Laterally.performed += instance.OnMove_Laterally;
                @Move_Laterally.canceled += instance.OnMove_Laterally;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard+Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnMove_ForwardBackward(InputAction.CallbackContext context);
        void OnMove_Laterally(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
