using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatemachine : StateMachine
{
    [field : SerializeField] public InputReader inputReader { get; private set; }
    [field: SerializeField] public Rigidbody2D rb { get; private set; }
    [field: SerializeField] public float kecepatnPlayer { get; private set; }
    private void Start()
    {
        Swictstate(new PlayerMoveState(this)); 
    }

}
