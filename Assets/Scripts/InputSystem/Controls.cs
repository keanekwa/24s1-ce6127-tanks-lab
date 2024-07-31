//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Global"",
            ""id"": ""1ab31d70-45e4-4f1c-a891-b78a0dad9061"",
            ""actions"": [
                {
                    ""name"": ""ExitQuit"",
                    ""type"": ""Value"",
                    ""id"": ""fdd451ba-4394-434b-93d1-f1631a29e5d9"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Music"",
                    ""type"": ""Value"",
                    ""id"": ""7f25c4f8-d9f7-44fe-8609-53afa1b8e01b"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TankSFX"",
                    ""type"": ""Value"",
                    ""id"": ""6836343a-73af-4afe-adc1-b51e0409869f"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ShellSFX"",
                    ""type"": ""Value"",
                    ""id"": ""0a356d8c-f0d9-43b6-94a7-493e920fc9d4"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""FullscreenWindowed"",
                    ""type"": ""Value"",
                    ""id"": ""c31ee89c-6dc7-4e8e-bc41-b4f2ef6ef729"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""37a507f9-f5c8-4a8d-a9fb-7fa1f2da29fd"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAI"",
                    ""action"": ""ExitQuit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de2f3184-99ca-43cd-8796-7ba5d4c2c98f"",
                    ""path"": ""<Keyboard>/f5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAI"",
                    ""action"": ""Music"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11352ffa-9fd6-49a7-bd38-85cbaacdec3e"",
                    ""path"": ""<Keyboard>/f6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAI"",
                    ""action"": ""TankSFX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a299d71-76ef-46da-8210-e652d983af54"",
                    ""path"": ""<Keyboard>/f7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAI"",
                    ""action"": ""ShellSFX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b361649-b578-4d2f-bae1-d538fc063659"",
                    ""path"": ""<Keyboard>/f12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAI"",
                    ""action"": ""FullscreenWindowed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""65d20687-0efd-4921-8d03-aa2257f1e19f"",
            ""actions"": [
                {
                    ""name"": ""Continue"",
                    ""type"": ""Value"",
                    ""id"": ""2864a767-78cb-4c53-9f17-1891470b0bb0"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""23f5f9f0-853e-49dd-a523-8f5645fba3d1"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAI"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""556b1b7d-f5c6-4b58-9100-38ad5ffb38cc"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAI"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player1"",
            ""id"": ""0371f074-04c5-4376-96c3-478997ff128f"",
            ""actions"": [
                {
                    ""name"": ""MoveTurn"",
                    ""type"": ""Value"",
                    ""id"": ""09377a04-b5c4-4c44-b7e1-30d012cb9cfc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Value"",
                    ""id"": ""0f299eef-a891-4d2b-956d-cf17672024c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Direction"",
                    ""id"": ""4f596009-8c86-4abf-8698-e4a56fcb2ab4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveTurn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2ade656a-f763-4124-8c96-178c8d8e4dab"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""MoveTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8280913d-de54-4a8a-9f03-7284123d7a6c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""MoveTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ab4f59af-3f02-4b96-85ff-ab21e46aceb9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""MoveTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0f31c680-fefd-459b-8ab1-8153d2ca9215"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""MoveTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""40945f6b-6e3c-4403-824e-9c446dcb4a11"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""88f5266b-0d44-4116-83a4-da46ae48300a"",
            ""actions"": [
                {
                    ""name"": ""MoveTurn"",
                    ""type"": ""Value"",
                    ""id"": ""ae07ac40-cf99-4c47-a72e-54b68e97e908"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Value"",
                    ""id"": ""add9fc00-8a8c-4138-a084-e9d7240cad64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Direction"",
                    ""id"": ""ace9093c-db98-40e8-a581-8d550e589811"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveTurn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ab00a3f0-53e7-40e6-8691-663f99eef82e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""MoveTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5c11464e-06f9-4b14-8e69-d3702fc85c50"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""MoveTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""75291f9d-4925-4107-8aff-528d87923fb6"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""MoveTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""48d79147-d45d-423a-8cc3-df6818c06320"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""MoveTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e37c437a-9f47-4c94-a032-d40107f1a079"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14820a40-5788-4a7a-b0af-0ff67f539f9f"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMultiplayer;KeyboardAI"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMultiplayer"",
            ""bindingGroup"": ""KeyboardMultiplayer"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardAI"",
            ""bindingGroup"": ""KeyboardAI"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Global
        m_Global = asset.FindActionMap("Global", throwIfNotFound: true);
        m_Global_ExitQuit = m_Global.FindAction("ExitQuit", throwIfNotFound: true);
        m_Global_Music = m_Global.FindAction("Music", throwIfNotFound: true);
        m_Global_TankSFX = m_Global.FindAction("TankSFX", throwIfNotFound: true);
        m_Global_ShellSFX = m_Global.FindAction("ShellSFX", throwIfNotFound: true);
        m_Global_FullscreenWindowed = m_Global.FindAction("FullscreenWindowed", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Continue = m_Menu.FindAction("Continue", throwIfNotFound: true);
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_MoveTurn = m_Player1.FindAction("MoveTurn", throwIfNotFound: true);
        m_Player1_Fire = m_Player1.FindAction("Fire", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_MoveTurn = m_Player2.FindAction("MoveTurn", throwIfNotFound: true);
        m_Player2_Fire = m_Player2.FindAction("Fire", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Global
    private readonly InputActionMap m_Global;
    private List<IGlobalActions> m_GlobalActionsCallbackInterfaces = new List<IGlobalActions>();
    private readonly InputAction m_Global_ExitQuit;
    private readonly InputAction m_Global_Music;
    private readonly InputAction m_Global_TankSFX;
    private readonly InputAction m_Global_ShellSFX;
    private readonly InputAction m_Global_FullscreenWindowed;
    public struct GlobalActions
    {
        private @Controls m_Wrapper;
        public GlobalActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExitQuit => m_Wrapper.m_Global_ExitQuit;
        public InputAction @Music => m_Wrapper.m_Global_Music;
        public InputAction @TankSFX => m_Wrapper.m_Global_TankSFX;
        public InputAction @ShellSFX => m_Wrapper.m_Global_ShellSFX;
        public InputAction @FullscreenWindowed => m_Wrapper.m_Global_FullscreenWindowed;
        public InputActionMap Get() { return m_Wrapper.m_Global; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GlobalActions set) { return set.Get(); }
        public void AddCallbacks(IGlobalActions instance)
        {
            if (instance == null || m_Wrapper.m_GlobalActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GlobalActionsCallbackInterfaces.Add(instance);
            @ExitQuit.started += instance.OnExitQuit;
            @ExitQuit.performed += instance.OnExitQuit;
            @ExitQuit.canceled += instance.OnExitQuit;
            @Music.started += instance.OnMusic;
            @Music.performed += instance.OnMusic;
            @Music.canceled += instance.OnMusic;
            @TankSFX.started += instance.OnTankSFX;
            @TankSFX.performed += instance.OnTankSFX;
            @TankSFX.canceled += instance.OnTankSFX;
            @ShellSFX.started += instance.OnShellSFX;
            @ShellSFX.performed += instance.OnShellSFX;
            @ShellSFX.canceled += instance.OnShellSFX;
            @FullscreenWindowed.started += instance.OnFullscreenWindowed;
            @FullscreenWindowed.performed += instance.OnFullscreenWindowed;
            @FullscreenWindowed.canceled += instance.OnFullscreenWindowed;
        }

        private void UnregisterCallbacks(IGlobalActions instance)
        {
            @ExitQuit.started -= instance.OnExitQuit;
            @ExitQuit.performed -= instance.OnExitQuit;
            @ExitQuit.canceled -= instance.OnExitQuit;
            @Music.started -= instance.OnMusic;
            @Music.performed -= instance.OnMusic;
            @Music.canceled -= instance.OnMusic;
            @TankSFX.started -= instance.OnTankSFX;
            @TankSFX.performed -= instance.OnTankSFX;
            @TankSFX.canceled -= instance.OnTankSFX;
            @ShellSFX.started -= instance.OnShellSFX;
            @ShellSFX.performed -= instance.OnShellSFX;
            @ShellSFX.canceled -= instance.OnShellSFX;
            @FullscreenWindowed.started -= instance.OnFullscreenWindowed;
            @FullscreenWindowed.performed -= instance.OnFullscreenWindowed;
            @FullscreenWindowed.canceled -= instance.OnFullscreenWindowed;
        }

        public void RemoveCallbacks(IGlobalActions instance)
        {
            if (m_Wrapper.m_GlobalActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGlobalActions instance)
        {
            foreach (var item in m_Wrapper.m_GlobalActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GlobalActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GlobalActions @Global => new GlobalActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private List<IMenuActions> m_MenuActionsCallbackInterfaces = new List<IMenuActions>();
    private readonly InputAction m_Menu_Continue;
    public struct MenuActions
    {
        private @Controls m_Wrapper;
        public MenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Continue => m_Wrapper.m_Menu_Continue;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void AddCallbacks(IMenuActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuActionsCallbackInterfaces.Add(instance);
            @Continue.started += instance.OnContinue;
            @Continue.performed += instance.OnContinue;
            @Continue.canceled += instance.OnContinue;
        }

        private void UnregisterCallbacks(IMenuActions instance)
        {
            @Continue.started -= instance.OnContinue;
            @Continue.performed -= instance.OnContinue;
            @Continue.canceled -= instance.OnContinue;
        }

        public void RemoveCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Player1
    private readonly InputActionMap m_Player1;
    private List<IPlayer1Actions> m_Player1ActionsCallbackInterfaces = new List<IPlayer1Actions>();
    private readonly InputAction m_Player1_MoveTurn;
    private readonly InputAction m_Player1_Fire;
    public struct Player1Actions
    {
        private @Controls m_Wrapper;
        public Player1Actions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveTurn => m_Wrapper.m_Player1_MoveTurn;
        public InputAction @Fire => m_Wrapper.m_Player1_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void AddCallbacks(IPlayer1Actions instance)
        {
            if (instance == null || m_Wrapper.m_Player1ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player1ActionsCallbackInterfaces.Add(instance);
            @MoveTurn.started += instance.OnMoveTurn;
            @MoveTurn.performed += instance.OnMoveTurn;
            @MoveTurn.canceled += instance.OnMoveTurn;
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
        }

        private void UnregisterCallbacks(IPlayer1Actions instance)
        {
            @MoveTurn.started -= instance.OnMoveTurn;
            @MoveTurn.performed -= instance.OnMoveTurn;
            @MoveTurn.canceled -= instance.OnMoveTurn;
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
        }

        public void RemoveCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer1Actions instance)
        {
            foreach (var item in m_Wrapper.m_Player1ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player1ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private List<IPlayer2Actions> m_Player2ActionsCallbackInterfaces = new List<IPlayer2Actions>();
    private readonly InputAction m_Player2_MoveTurn;
    private readonly InputAction m_Player2_Fire;
    public struct Player2Actions
    {
        private @Controls m_Wrapper;
        public Player2Actions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveTurn => m_Wrapper.m_Player2_MoveTurn;
        public InputAction @Fire => m_Wrapper.m_Player2_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void AddCallbacks(IPlayer2Actions instance)
        {
            if (instance == null || m_Wrapper.m_Player2ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player2ActionsCallbackInterfaces.Add(instance);
            @MoveTurn.started += instance.OnMoveTurn;
            @MoveTurn.performed += instance.OnMoveTurn;
            @MoveTurn.canceled += instance.OnMoveTurn;
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
        }

        private void UnregisterCallbacks(IPlayer2Actions instance)
        {
            @MoveTurn.started -= instance.OnMoveTurn;
            @MoveTurn.performed -= instance.OnMoveTurn;
            @MoveTurn.canceled -= instance.OnMoveTurn;
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
        }

        public void RemoveCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer2Actions instance)
        {
            foreach (var item in m_Wrapper.m_Player2ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player2ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    private int m_KeyboardMultiplayerSchemeIndex = -1;
    public InputControlScheme KeyboardMultiplayerScheme
    {
        get
        {
            if (m_KeyboardMultiplayerSchemeIndex == -1) m_KeyboardMultiplayerSchemeIndex = asset.FindControlSchemeIndex("KeyboardMultiplayer");
            return asset.controlSchemes[m_KeyboardMultiplayerSchemeIndex];
        }
    }
    private int m_KeyboardAISchemeIndex = -1;
    public InputControlScheme KeyboardAIScheme
    {
        get
        {
            if (m_KeyboardAISchemeIndex == -1) m_KeyboardAISchemeIndex = asset.FindControlSchemeIndex("KeyboardAI");
            return asset.controlSchemes[m_KeyboardAISchemeIndex];
        }
    }
    public interface IGlobalActions
    {
        void OnExitQuit(InputAction.CallbackContext context);
        void OnMusic(InputAction.CallbackContext context);
        void OnTankSFX(InputAction.CallbackContext context);
        void OnShellSFX(InputAction.CallbackContext context);
        void OnFullscreenWindowed(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnContinue(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnMoveTurn(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMoveTurn(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}