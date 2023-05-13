using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : State
{
    protected PlayerStatemachine statemachine;
    public PlayerBaseState (PlayerStatemachine statemachine)
    {
        this.statemachine = statemachine;
    }
}
