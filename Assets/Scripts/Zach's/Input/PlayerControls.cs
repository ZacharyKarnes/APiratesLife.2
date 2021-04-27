// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Zach's/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Locomotion"",
            ""id"": ""ab6e3386-9c9e-47f9-a8e8-061a4bbaf0a5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b5530551-3979-4111-889e-16d1eb8a0fbe"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7045357b-63aa-4bfe-9dcb-3658ee32d651"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""45406413-1bf7-42e6-95d3-9ebb70a09416"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RAttack"",
                    ""type"": ""Button"",
                    ""id"": ""2ce896ee-2286-4bde-b841-cb894f645c03"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LAttack"",
                    ""type"": ""Button"",
                    ""id"": ""afeb6b66-e615-4557-ae42-943c5c74e3d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""a4019caa-4e84-458a-a1dc-3c4028df46ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sheath"",
                    ""type"": ""Button"",
                    ""id"": ""8cb1385d-2c9b-4e4b-823b-f4dc3b5eb73c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""63289207-fb0a-4f17-a66b-abe63815e838"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""61406f96-5603-49f4-b582-fc3268b8a061"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4bbcb106-52cc-4e6f-bf2f-9698a04c5ccd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c20232c5-07c4-4942-9b97-e7ef1326f2b4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""23c83c00-dedc-4d07-a13f-633aebf884c5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""eca9f45c-462b-4cce-89dc-feefc5d63f1d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7740b162-0745-421e-a7c4-bbf6cbb72cad"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32690b2e-6b97-45d4-81b7-072ea9b3ec3f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3312cfd-cced-47b6-8401-cad44a080334"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""faeaaf11-d22f-4aa3-a6e4-b43eb9d59265"",
                    ""path"": ""<Mouse>/forwardButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b86dd60-0418-4a18-8961-db0bb6fa61cd"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sheath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Emotes"",
            ""id"": ""9f668cb2-c058-4750-bf57-58f758995082"",
            ""actions"": [
                {
                    ""name"": ""Twerk"",
                    ""type"": ""Button"",
                    ""id"": ""7b68f42d-13b3-4654-972d-a47f7cc70b50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ca5020d7-209e-414f-99dc-473e2e948160"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Twerk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Locomotion
        m_Locomotion = asset.FindActionMap("Locomotion", throwIfNotFound: true);
        m_Locomotion_Move = m_Locomotion.FindAction("Move", throwIfNotFound: true);
        m_Locomotion_Look = m_Locomotion.FindAction("Look", throwIfNotFound: true);
        m_Locomotion_Jump = m_Locomotion.FindAction("Jump", throwIfNotFound: true);
        m_Locomotion_RAttack = m_Locomotion.FindAction("RAttack", throwIfNotFound: true);
        m_Locomotion_LAttack = m_Locomotion.FindAction("LAttack", throwIfNotFound: true);
        m_Locomotion_Dodge = m_Locomotion.FindAction("Dodge", throwIfNotFound: true);
        m_Locomotion_Sheath = m_Locomotion.FindAction("Sheath", throwIfNotFound: true);
        // Emotes
        m_Emotes = asset.FindActionMap("Emotes", throwIfNotFound: true);
        m_Emotes_Twerk = m_Emotes.FindAction("Twerk", throwIfNotFound: true);
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

    // Locomotion
    private readonly InputActionMap m_Locomotion;
    private ILocomotionActions m_LocomotionActionsCallbackInterface;
    private readonly InputAction m_Locomotion_Move;
    private readonly InputAction m_Locomotion_Look;
    private readonly InputAction m_Locomotion_Jump;
    private readonly InputAction m_Locomotion_RAttack;
    private readonly InputAction m_Locomotion_LAttack;
    private readonly InputAction m_Locomotion_Dodge;
    private readonly InputAction m_Locomotion_Sheath;
    public struct LocomotionActions
    {
        private @PlayerControls m_Wrapper;
        public LocomotionActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Locomotion_Move;
        public InputAction @Look => m_Wrapper.m_Locomotion_Look;
        public InputAction @Jump => m_Wrapper.m_Locomotion_Jump;
        public InputAction @RAttack => m_Wrapper.m_Locomotion_RAttack;
        public InputAction @LAttack => m_Wrapper.m_Locomotion_LAttack;
        public InputAction @Dodge => m_Wrapper.m_Locomotion_Dodge;
        public InputAction @Sheath => m_Wrapper.m_Locomotion_Sheath;
        public InputActionMap Get() { return m_Wrapper.m_Locomotion; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LocomotionActions set) { return set.Get(); }
        public void SetCallbacks(ILocomotionActions instance)
        {
            if (m_Wrapper.m_LocomotionActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnJump;
                @RAttack.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnRAttack;
                @RAttack.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnRAttack;
                @RAttack.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnRAttack;
                @LAttack.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLAttack;
                @LAttack.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLAttack;
                @LAttack.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLAttack;
                @Dodge.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnDodge;
                @Sheath.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnSheath;
                @Sheath.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnSheath;
                @Sheath.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnSheath;
            }
            m_Wrapper.m_LocomotionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @RAttack.started += instance.OnRAttack;
                @RAttack.performed += instance.OnRAttack;
                @RAttack.canceled += instance.OnRAttack;
                @LAttack.started += instance.OnLAttack;
                @LAttack.performed += instance.OnLAttack;
                @LAttack.canceled += instance.OnLAttack;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
                @Sheath.started += instance.OnSheath;
                @Sheath.performed += instance.OnSheath;
                @Sheath.canceled += instance.OnSheath;
            }
        }
    }
    public LocomotionActions @Locomotion => new LocomotionActions(this);

    // Emotes
    private readonly InputActionMap m_Emotes;
    private IEmotesActions m_EmotesActionsCallbackInterface;
    private readonly InputAction m_Emotes_Twerk;
    public struct EmotesActions
    {
        private @PlayerControls m_Wrapper;
        public EmotesActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Twerk => m_Wrapper.m_Emotes_Twerk;
        public InputActionMap Get() { return m_Wrapper.m_Emotes; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EmotesActions set) { return set.Get(); }
        public void SetCallbacks(IEmotesActions instance)
        {
            if (m_Wrapper.m_EmotesActionsCallbackInterface != null)
            {
                @Twerk.started -= m_Wrapper.m_EmotesActionsCallbackInterface.OnTwerk;
                @Twerk.performed -= m_Wrapper.m_EmotesActionsCallbackInterface.OnTwerk;
                @Twerk.canceled -= m_Wrapper.m_EmotesActionsCallbackInterface.OnTwerk;
            }
            m_Wrapper.m_EmotesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Twerk.started += instance.OnTwerk;
                @Twerk.performed += instance.OnTwerk;
                @Twerk.canceled += instance.OnTwerk;
            }
        }
    }
    public EmotesActions @Emotes => new EmotesActions(this);
    public interface ILocomotionActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRAttack(InputAction.CallbackContext context);
        void OnLAttack(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
        void OnSheath(InputAction.CallbackContext context);
    }
    public interface IEmotesActions
    {
        void OnTwerk(InputAction.CallbackContext context);
    }
}
