using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDieState : IState
{
    private EnemyStateController _StateController;
    public string AnimationName => "die";

    public EnemyDieState(EnemyStateController controller)
    {
        _StateController = controller;
    }

    public void FixedLogicUpdate()
    {
        
    }

    public void LogicUpdate()
    {
        
    }

    public void OnEnter()
    {
        _StateController.Animator.SetBool(AnimationName, true);
    }

    public void OnExit()
    {
        _StateController.Animator.SetBool(AnimationName, false);
    }

    public void OnAnimationEnd()
    {
    }

    public void TakeHit()
    { }
}
