using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportationActivator : MonoBehaviour
{
    [SerializeField] XRRayInteractor teleportInteractor;
    [SerializeField] InputActionProperty teleportActivatorAction;
    
    // Start is called before the first frame update
    void Start()
    {
        teleportInteractor.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (teleportActivatorAction.action.WasReleasedThisFrame())
        {
            teleportInteractor.gameObject.SetActive(false);
        }
        if (teleportActivatorAction.action.WasPressedThisFrame())
        {
            teleportInteractor.gameObject.SetActive(true);
        }
    }
}
