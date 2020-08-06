using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    [CreateAssetMenu(fileName = "New State", menuName = "Roundbeargames/AbilityData/Jump")]
    public class Jump : StateData
    {
        public float JumpForce;
        public AnimationCurve Gravity;
        public AnimationCurve Pull;
        public bool Zero;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            if (Zero)
            {
                characterState.characterControl.RIGID_BODY.velocity = Vector3.zero;
            }
            characterState.characterControl.RIGID_BODY.AddForce(Vector3.up * JumpForce);
            animator.SetBool(TransitionParameter.Grounded.ToString(), false);
            animator.SetBool(TransitionParameter.SpringThrow.ToString(), false);

        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

            characterState.characterControl.GravityMultiplier = Gravity.Evaluate(stateInfo.normalizedTime);
            characterState.characterControl.PullMultiplier = Pull.Evaluate(stateInfo.normalizedTime);

            if(characterState.characterControl.Trampoline)
            {
                animator.SetBool(TransitionParameter.Trampoline.ToString(), true);
            }
            if (characterState.characterControl.WheelRoll)
            {
                animator.SetBool(TransitionParameter.WheelRoll.ToString(), true);
            }
            if (characterState.characterControl.SpringThrow)
            {
                animator.SetBool(TransitionParameter.SpringThrow.ToString(), true);
            }
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

            Gravity.Evaluate(0f);
            Pull.Evaluate(0f);
            animator.SetBool(TransitionParameter.SpringThrow.ToString(), false);

        }
    }
}