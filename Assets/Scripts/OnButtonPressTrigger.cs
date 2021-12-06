using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class OnButtonPressTrigger : MonoBehaviour
{
    private bool triggerIsEnter = false;
    
    [Tooltip("Actions to check")]
    public InputAction action = null;

    // When the button is pressed
    public UnityEvent OnPress = new UnityEvent();

    // When the button is released
    public UnityEvent OnRelease = new UnityEvent();
    
    public bool TriggerIsEnter {
        get {return triggerIsEnter;}
        set {triggerIsEnter = value;}
    }
    
    private void Awake()
    {
        action.started += Pressed;
        action.canceled += Released;
    }

    private void OnDestroy()
    {
        action.started -= Pressed;
        action.canceled -= Released;
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    private void Pressed(InputAction.CallbackContext context)
    {
        if (triggerIsEnter) {
            OnPress.Invoke();
        }  
    }

    private void Released(InputAction.CallbackContext context)
    {
        OnRelease.Invoke();
    }
}
