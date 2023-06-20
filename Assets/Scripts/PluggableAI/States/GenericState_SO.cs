using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create State/GenericState_SO", fileName = "GenericState_SO", order = 0)]
public class GenericState_SO : State
{
    public override void OnEnter(PluggableStateController controller)
    {
        base.OnEnter(controller);
    }

    public override void OnExit(PluggableStateController controller)
    {
        base.OnExit(controller);
    }
}
