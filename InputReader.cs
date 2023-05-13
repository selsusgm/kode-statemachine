using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputReader : MonoBehaviour,control.IPlayerActions
{
    private control control;
    
   public Vector2 movementvalue { get; private set; }
 private   void Start()
    {
        control = new control();
        control.Player.SetCallbacks(this);
        control.Enable();
    }
    private void OnDestroy()
    {
        control.Player.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        movementvalue = context.ReadValue<Vector2>();
    }


}
