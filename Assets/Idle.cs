using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    [CreateAssetMenu(fileName = "New State", menuName = "Roundbeargames/AbilityData/Idle")]
    public class Idle : StateData
    {
        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            animator.SetBool(TransitionParameter.Jump.ToString(), false);
			animator.SetBool(TransitionParameter.Attack.ToString(), false);
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            
            if (characterState.characterControl.Attack)
            {
                animator.SetBool(TransitionParameter.Attack.ToString(), true);
            }

            if (characterState.characterControl.Jump)
            {
                animator.SetBool(TransitionParameter.Jump.ToString(), true);
            }
			if (characterState.characterControl.MoveLeft && characterState.characterControl.MoveRight)
			{
				animator.SetBool(TransitionParameter.Move.ToString(), false);
			}

			if (characterState.characterControl.MoveRight)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), true);
            }

            if (characterState.characterControl.MoveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), true);
            }

            if (characterState.characterControl.Cartwheel)
			{
				animator.SetBool(TransitionParameter.Cartwheel.ToString(), true);
			}

            if (characterState.characterControl.Headbutt)
			{
				animator.SetBool(TransitionParameter.Headbutt.ToString(), true);
			}

            if (characterState.characterControl.BellyFlop)
			{
				animator.SetBool(TransitionParameter.BellyFlop.ToString(), true);
			}

			if (characterState.characterControl.HammerDown)
			{
				animator.SetBool(TransitionParameter.HammerDown.ToString(), true);
			}

            if(characterState.characterControl.Shift)
			{
				animator.SetBool(TransitionParameter.Shift.ToString(), true);
			}

            if(characterState.characterControl.FSidekick)
            {
                animator.SetBool(TransitionParameter.FSidekick.ToString(), true);
            }

            if(characterState.characterControl.BackflipSlam)
            {
                animator.SetBool(TransitionParameter.BackflipSlam.ToString(), true);
            }

            if(characterState.characterControl.SpringThrow)
            {
                animator.SetBool(TransitionParameter.SpringThrow.ToString(), true);
            }

            if(characterState.characterControl.WheelRoll)
            {
                animator.SetBool(TransitionParameter.SpringThrow.ToString(), true);
            }

            if(characterState.characterControl.Trampoline)
            {
                animator.SetBool(TransitionParameter.Trampoline.ToString(), true);
            }
		}

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
			
			
		}
    }
}