using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public Transform roomLocation;
    public Transform externalLocation;
    
    private bool isExternal = false;

    public InputActionReference action;

    public void Start()
    {
        action.action.Enable();
        action.action.performed += ctx => {
            if (ctx.performed) ChangeLocation();
        };
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            ChangeLocation();
        }
    }

    public void ChangeLocation()
    {
        if (isExternal)
        {
            transform.position = roomLocation.position;
            transform.rotation = roomLocation.rotation;
            isExternal = false;
        }
        else
        {
            transform.position = externalLocation.position;
            transform.rotation = externalLocation.rotation;
            isExternal = true;
        }
    }
}