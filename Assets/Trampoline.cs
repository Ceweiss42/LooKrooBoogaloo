using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    [CreateAssetMenu(fileName = "New State", menuName = "Roundbeargames/AbilityData/Trampoline")]
    public class Trampoline : StateData
    {
        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            animator.SetBool(TransitionParameter.WheelRoll.ToString(), false);
            animator.SetBool(TransitionParameter.Move.ToString(), false);
            animator.SetBool(TransitionParameter.SpringThrow.ToString(), false);
            animator.SetBool(TransitionParameter.Trampoline.ToString(), false);
            animator.SetBool(TransitionParameter.SpringThrow.ToString(), false);

        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            animator.SetBool(TransitionParameter.WheelRoll.ToString(), false);
            animator.SetBool(TransitionParameter.Trampoline.ToString(), false);
            animator.SetBool(TransitionParameter.SpringThrow.ToString(), false);
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            //There is no update ability from this move for now
        }
    }

}
