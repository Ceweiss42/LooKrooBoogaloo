using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
	[CreateAssetMenu(fileName = "New State", menuName = "Roundbeargames/AbilityData/Fall")]
	public class Fall : StateData
	{
		public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
		{
			animator.SetBool(TransitionParameter.Grounded.ToString(), false);
			animator.SetBool(TransitionParameter.Attack.ToString(), false);
			animator.SetBool(TransitionParameter.Cartwheel.ToString(), false);
			animator.SetBool(TransitionParameter.Jump.ToString(), false);
			animator.SetBool(TransitionParameter.Attack.ToString(), false);
			animator.SetBool(TransitionParameter.Cartwheel.ToString(), false);
			animator.SetBool(TransitionParameter.Move.ToString(), false);
			animator.SetBool(TransitionParameter.Headbutt.ToString(), false);


		}

		public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
		{
			if (characterState.characterControl.Attack)
			{
				animator.SetBool(TransitionParameter.Attack.ToString(), true);
			}

			if(characterState.characterControl.Cartwheel)
            {
				animator.SetBool(TransitionParameter.Cartwheel.ToString(), true);
            }
			if (characterState.characterControl.Headbutt)
			{
				animator.SetBool(TransitionParameter.Headbutt.ToString(), true);
			}

			if (characterState.characterControl.HammerDown)
			{
				animator.SetBool(TransitionParameter.HammerDown.ToString(), true);
			}

			if (characterState.characterControl.FSidekick)
			{
				animator.SetBool(TransitionParameter.FSidekick.ToString(), true);
			}
			if (characterState.characterControl.BackflipSlam)
			{
				animator.SetBool(TransitionParameter.BackflipSlam.ToString(), true);
			}


		}

		public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
		{
			animator.SetBool(TransitionParameter.Jump.ToString(), false);
			animator.SetBool(TransitionParameter.Attack.ToString(), false);
			animator.SetBool(TransitionParameter.Cartwheel.ToString(), false);
			animator.SetBool(TransitionParameter.Move.ToString(), false);
			animator.SetBool(TransitionParameter.Headbutt.ToString(), false);
		}
	}
}