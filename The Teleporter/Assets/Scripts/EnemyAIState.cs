// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public abstract class EnemyAIState
// {
    
//     protected EnemyAIState enemyAI;
//     protected float timer = 0;
//     public EnemyAIState(EnemyAIState newAI) {
//         enemyAI = newAI;
//     }

//     public void UpdateStateBase(){
//         timer+=Time.fixedDeltaTime;
//         UpdateState();
//     }

//     public void BeginStateBase(){
//         timer = 0;
//         //Debug.Log()
//         BeginStateBase();
//     }

//     //when we start the state
//     public abstract void UpdateState();
//     //Tick Method
//     public abstract void BeginState();


   
// }
