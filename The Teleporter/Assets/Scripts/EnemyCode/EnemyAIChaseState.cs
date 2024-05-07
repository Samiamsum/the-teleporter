// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class EnemyAIChaseState : EnemyAIState
// {
    
// public CreatureAIChaseState(EnemyAIChaseState enemyAI) : base(enemyAI){

// }

// public override void BeginState(){
//     enemyAI.myEnemy.GetComponent<SpriteRenderer>().color = Color.red;
// }

// public override void UpdateState(){
//     if(enemyAI.GetTarget() != null){
//         enemyAI.myEnemy.MoveToward(EnemyAIChaseState.GetTarget().transform.position);

//     }else{
//         enemyAI.ChangeState(enemyAI.patrolState);
//     }
// }


// }
