using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TeleportManager : MonoBehaviour
{

    public InputActionReference teleportActionReference;

    public UnityEvent onTeleportActive;
    public UnityEvent onTeleportCancel;


    private void Start()
    {
        teleportActionReference.action.performed += teleportActivate;

        teleportActionReference.action.canceled -= teleportCancell;
    }

    // Activo el teleport Activo
    private void teleportActivate(InputAction.CallbackContext context) => onTeleportActive.Invoke();



    // Activo el teleport para cancelarlo
    void DelayedTeleportCancel()
    {
        onTeleportCancel.Invoke();
    }


    // Invoco al metodo con una tardanza de 0.01 seg
    private void teleportCancell(InputAction.CallbackContext context) {

        Invoke("DelayedTeleportCancel", 0.1f);
    }


        }
    
   
    
