using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    private State currrentstate;
  
    public void Swictstate(State newstate)
    {
        currrentstate?.Exit();
        currrentstate = newstate;
        currrentstate?.Enter();
    }
    
    private void Update()
    {
        currrentstate?.Tick(Time.deltaTime);
    }
}
