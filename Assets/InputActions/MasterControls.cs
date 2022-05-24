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
                },
                {
                    ""name"": ""EquipedFunction"",
                    ""type"": ""Button"",
                    ""id"": ""8f6ab660-4775-4221-a88b-1c3f0b3e9d02"",
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
                    ""id"": ""1cf2b9ea-baf7-4f60-996d-65369dca8ce8"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=8,y=8)"",
                    ""groups"": ""Controller"",
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
                    ""name"": """",
                    ""id"": ""58f588f3-ba0e-4bad-984d-a6f9a85da1a3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
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
                    ""name"": ""Left Stick"",
                    ""id"": ""e9810bbc-1f1c-4b0b-85c9-592803b0b01e"",
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
                    ""id"": ""bd37b747-673b-47eb-afef-3a085f357192"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Move_ForwardBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a1f7b727-4780-43a4-8aee-43d599648e6d"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
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
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""a601e6af-20d7-4845-b2e8-d53f68876132"",
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
                    ""id"": ""1c117176-2822-4361-8528-ad5298f79817"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Move_Laterally"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a17db5df-157b-4ea7-a957-6757be00080d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Move_Laterally"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c3fe877f-f871-49ba-9b78-9efb896abfaf"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""EquipedFunction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""d3c31288-77a3-460e-a1ed-2138ed12b38a"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""70c80ffc-cf4e-4b93-843f-100915254fdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""53cc4017-0ae4-4f7a-9a9a-1159af5d0cc6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
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
        m_Player_EquipedFunction = m_Player.FindAction("EquipedFunction", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Start = m_UI.FindAction("Start", throwIfNotFound: true);
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
    private readonly InputAction m_Player_EquipedFunction;
    public struct PlayerActions
    {
        private @MasterControls m_Wrapper;
        public PlayerActions(@MasterControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Move_ForwardBackward => m_Wrapper.m_Player_Move_ForwardBackward;
        public InputAction @Move_Laterally => m_Wrapper.m_Player_Move_Laterally;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @EquipedFunction => m_Wrapper.m_Player_EquipedFunction;
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
                @EquipedFunction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipedFunction;
                @EquipedFunction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipedFunction;
                @EquipedFunction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipedFunction;
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
                @EquipedFunction.started += instance.OnEquipedFunction;
                @EquipedFunction.performed += instance.OnEquipedFunction;
                @EquipedFunction.canceled += instance.OnEquipedFunction;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Start;
    public struct UIActions
    {
        private @MasterControls m_Wrapper;
        public UIActions(@MasterControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Start => m_Wrapper.m_UI_Start;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Start.started -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard+Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnMove_ForwardBackward(InputAction.CallbackContext context);
        void OnMove_Laterally(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnEquipedFunction(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnStart(InputAction.CallbackContext context);
    }
}
