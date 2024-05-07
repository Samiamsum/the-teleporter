// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class EnemyAIIdleState : EnemyAIState
// {
    
//     public EnemyAIIdleState(EnemyAI enemyAI) : base(enemyAI){

//     }

//     public override void UpdateState(){
//         //don't need to do anything
//         enemyAI.myEnemy.Stop();
//         //if enemy detects player, change to chase state
//         if(enemyAI.GetTarget() != null){
//             enemyAI.ChangeState(enemyAI.chaseState);
//         }
//     }

//     public override void BeginState(){
//         enemyAI.myEnemy.GetComponent<SpriteRenderer>().color = Color.white;
//     }

// }
