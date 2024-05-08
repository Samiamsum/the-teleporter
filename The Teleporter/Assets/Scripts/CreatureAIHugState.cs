using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureAIHugState : CreatureAIState
{

    public CreatureAIHugState(CreatureAI creatureAI) : base(creatureAI){}


    public override void BeginState()
    {
        //creatureAI.SetColor(Color.red);
    }

    public override void UpdateState()
    {
        if(creatureAI.GetTarget() != null){
            creatureAI.myCreature.MoveToward(creatureAI.GetTarget().transform.position);
        }else{
            //creatureAI.ChangeState(creatureAI.investigateState);
            creatureAI.ChangeState(creatureAI.patrolState);
        }

    }
}