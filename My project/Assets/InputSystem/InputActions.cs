// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputActions.inputactions'

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
            ""name"": ""Player"",
            ""id"": ""f03e3921-82b6-40c7-b5de-443e8b8ab172"",
            ""actions"": [
                {
                    ""name"": ""Moverse"",
                    ""type"": ""Value"",
                    ""id"": ""3324f3a5-2110-4c90-8ac2-2387ed64298c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Correr"",
                    ""type"": ""Button"",
                    ""id"": ""281e423d-3e03-4475-9386-52f795728f8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Despl_izq"",
                    ""type"": ""Value"",
                    ""id"": ""e8fd1e39-ea72-44e6-a738-0472b26f5002"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Despl_Dcha"",
                    ""type"": ""Value"",
                    ""id"": ""a6240fa2-ff36-4b03-a8dd-ff03600868ee"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9a3de973-7eff-4baf-b192-83294d1096f5"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd6fa730-863e-4087-933f-b1fa575ad812"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bdd495d-f26f-4d21-889b-f784cba5877c"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Despl_izq"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb301205-1ae0-4e46-ab07-137876697eb2"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Despl_Dcha"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""52d42075-b70e-4053-acb2-09d83d884e5f"",
            ""actions"": [
                {
                    ""name"": ""Orbitar"",
                    ""type"": ""Value"",
                    ""id"": ""efa64c05-43ee-4ad2-94bf-698d76730b93"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Apuntar"",
                    ""type"": ""Button"",
                    ""id"": ""9d696c54-dd15-46c2-ab37-6208da60508d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a090e743-9e5c-4c46-a555-f721a2a6d752"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orbitar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b5d72f9-0245-496c-b937-83de82efb402"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Moverse = m_Player.FindAction("Moverse", throwIfNotFound: true);
        m_Player_Correr = m_Player.FindAction("Correr", throwIfNotFound: true);
        m_Player_Despl_izq = m_Player.FindAction("Despl_izq", throwIfNotFound: true);
        m_Player_Despl_Dcha = m_Player.FindAction("Despl_Dcha", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Orbitar = m_Camera.FindAction("Orbitar", throwIfNotFound: true);
        m_Camera_Apuntar = m_Camera.FindAction("Apuntar", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Moverse;
    private readonly InputAction m_Player_Correr;
    private readonly InputAction m_Player_Despl_izq;
    private readonly InputAction m_Player_Despl_Dcha;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moverse => m_Wrapper.m_Player_Moverse;
        public InputAction @Correr => m_Wrapper.m_Player_Correr;
        public InputAction @Despl_izq => m_Wrapper.m_Player_Despl_izq;
        public InputAction @Despl_Dcha => m_Wrapper.m_Player_Despl_Dcha;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Moverse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoverse;
                @Moverse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoverse;
                @Moverse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoverse;
                @Correr.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @Correr.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @Correr.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @Despl_izq.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespl_izq;
                @Despl_izq.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespl_izq;
                @Despl_izq.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespl_izq;
                @Despl_Dcha.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespl_Dcha;
                @Despl_Dcha.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespl_Dcha;
                @Despl_Dcha.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespl_Dcha;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Moverse.started += instance.OnMoverse;
                @Moverse.performed += instance.OnMoverse;
                @Moverse.canceled += instance.OnMoverse;
                @Correr.started += instance.OnCorrer;
                @Correr.performed += instance.OnCorrer;
                @Correr.canceled += instance.OnCorrer;
                @Despl_izq.started += instance.OnDespl_izq;
                @Despl_izq.performed += instance.OnDespl_izq;
                @Despl_izq.canceled += instance.OnDespl_izq;
                @Despl_Dcha.started += instance.OnDespl_Dcha;
                @Despl_Dcha.performed += instance.OnDespl_Dcha;
                @Despl_Dcha.canceled += instance.OnDespl_Dcha;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Orbitar;
    private readonly InputAction m_Camera_Apuntar;
    public struct CameraActions
    {
        private @InputActions m_Wrapper;
        public CameraActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Orbitar => m_Wrapper.m_Camera_Orbitar;
        public InputAction @Apuntar => m_Wrapper.m_Camera_Apuntar;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Orbitar.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnOrbitar;
                @Orbitar.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnOrbitar;
                @Orbitar.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnOrbitar;
                @Apuntar.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnApuntar;
                @Apuntar.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnApuntar;
                @Apuntar.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnApuntar;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Orbitar.started += instance.OnOrbitar;
                @Orbitar.performed += instance.OnOrbitar;
                @Orbitar.canceled += instance.OnOrbitar;
                @Apuntar.started += instance.OnApuntar;
                @Apuntar.performed += instance.OnApuntar;
                @Apuntar.canceled += instance.OnApuntar;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IPlayerActions
    {
        void OnMoverse(InputAction.CallbackContext context);
        void OnCorrer(InputAction.CallbackContext context);
        void OnDespl_izq(InputAction.CallbackContext context);
        void OnDespl_Dcha(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnOrbitar(InputAction.CallbackContext context);
        void OnApuntar(InputAction.CallbackContext context);
    }
}
