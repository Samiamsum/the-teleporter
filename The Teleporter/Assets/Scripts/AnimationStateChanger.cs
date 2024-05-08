using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateChanger : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private string currentState = "Idle";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeAnimationState(string newState){
        if(currentState == newState){
            return;
        }

        currentState = newState;
        animator.Play(currentState);

    }

}
