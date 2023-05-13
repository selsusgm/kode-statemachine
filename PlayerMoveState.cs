using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState : PlayerBaseState
{
    public PlayerMoveState(PlayerStatemachine statemachine) : base(statemachine)
    {
    }

    public override void Enter()
    {
       
    }
    public override void Tick(float deltaTime)
    {
        Vector2 movement = new Vector2();
        movement = movement.normalized;
        movement.x = statemachine.inputReader.movementvalue.x;
        movement.y = statemachine.inputReader.movementvalue.y;
        statemachine.rb.velocity = movement *statemachine.kecepatnPlayer;
    }
    public override void Exit()
    {
    }

 
}
