// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class EnemyAIPatrolState : EnemyAIState
// {

//     public EnemyAIPatrolState(EnemyAI enemyAI) : base(enemyAI){}

//     public override void BeginState(){
//         MoveRandom();
//         enemyAI.myEnemy.GetComponent<SpriteRenderer>().color = Color.white;
//     }

//     Vector3 moveVec;

//     public override void UpdateState(){
//         Debug.Log(timer);
//         if(timer > 1.5f;){
//             timer = 0;
//             MoveRandom();
//         }

//         enemyAI.myEnemy.Move(moveVec);

//         if(enemyAI.GetTarget() != null){
//             enemyAI.ChangeState(enemyAI.chaseState);
//         }
//     }

//     public void MoveRandom(){
//         moveVec = (new Vector3(MoveRandom.Range(-1f,1f),MoveRandom.Range(-1f,1f),0));
//     }


 
// }
