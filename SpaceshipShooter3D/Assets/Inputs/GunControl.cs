// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/GunControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GunControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GunControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GunControl"",
    ""maps"": [
        {
            ""name"": ""GunControlMap"",
            ""id"": ""f885704b-71e2-4b89-8c9f-415b97e858b5"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""97229bc0-e399-49de-b187-b6e600dd0d1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""046c7c32-c4ff-4fd4-ac96-e7c9635d5475"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GunControlMap
        m_GunControlMap = asset.FindActionMap("GunControlMap", throwIfNotFound: true);
        m_GunControlMap_Fire = m_GunControlMap.FindAction("Fire", throwIfNotFound: true);
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

    // GunControlMap
    private readonly InputActionMap m_GunControlMap;
    private IGunControlMapActions m_GunControlMapActionsCallbackInterface;
    private readonly InputAction m_GunControlMap_Fire;
    public struct GunControlMapActions
    {
        private @GunControl m_Wrapper;
        public GunControlMapActions(@GunControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_GunControlMap_Fire;
        public InputActionMap Get() { return m_Wrapper.m_GunControlMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GunControlMapActions set) { return set.Get(); }
        public void SetCallbacks(IGunControlMapActions instance)
        {
            if (m_Wrapper.m_GunControlMapActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_GunControlMapActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_GunControlMapActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_GunControlMapActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_GunControlMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public GunControlMapActions @GunControlMap => new GunControlMapActions(this);
    public interface IGunControlMapActions
    {
        void OnFire(InputAction.CallbackContext context);
    }
}
