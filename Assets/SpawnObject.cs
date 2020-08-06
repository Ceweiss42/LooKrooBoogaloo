using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

namespace roundbeargames_tutorial
{
	[CreateAssetMenu(fileName = "New State", menuName = "Roundbeargames/AbilityData/SpawnObject")]
	public class SpawnObject : StateData
	{

		public PoolObjectType ObjectType;
		[Range(0f, 1f)]
		public float SpawnTiming;
        public float Speed;
      

		public string ParentObjectName = string.Empty;
		public string ExplosiveParent = string.Empty;
		public bool StickToParent;
        public bool Throwable;
		public bool OffsetRot;
		public bool Explosive;
		public Quaternion rotation;

		public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
		{
			if (SpawnTiming == 0f)
			{
				
				SpawnObj(characterState.characterControl);
				
			}
		}

		public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
		{
			

			if (!characterState.characterControl.ap.PoolObjectList.Contains(ObjectType))
			{
				if (stateInfo.normalizedTime >= SpawnTiming)
				{
					
					SpawnObj(characterState.characterControl);
					
				}
			}

		}

		public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
		{

			
			if (characterState.characterControl.ap.PoolObjectList.Contains(ObjectType))
			{
                characterState.characterControl.ap.PoolObjectList.Remove(ObjectType);
			}
		}

		private void SpawnObj(CharacterControl control)
		{

			if (control.ap.PoolObjectList.Contains(ObjectType))
			{
				return;
			}

			Debug.Log("Spawning " + ObjectType.ToString() + "|||||||||||||| Looking for: " + ParentObjectName);

			GameObject obj = PoolManager.Instance.GetObject(ObjectType);

			if (!string.IsNullOrEmpty(ParentObjectName))
			{
				GameObject p;

				if(control.GetChildObj(ParentObjectName) == null)
                {
					 p = GameObject.Find(ParentObjectName);
                }
				 p = control.GetChildObj(ParentObjectName);
				obj.transform.parent = p.transform;
				obj.transform.localPosition = Vector3.zero;
				obj.transform.localRotation = Quaternion.identity;

				
			}

            if (Throwable)
            {
                Rigidbody rb = obj.GetComponent<Rigidbody>();
                obj.transform.localPosition = Vector3.zero;
                obj.transform.localRotation = Quaternion.identity;


                if (obj.transform.root.GetComponent<CharacterControl>().FaceLeft)
                {
                    rb.velocity = -Vector3.forward * Speed;
                }
                else
                {
                    rb.velocity = Vector3.forward * Speed;
                }
                obj.transform.parent = null;

            }

			if(Explosive)
            {
				obj.transform.parent = GameObject.Find(ExplosiveParent).transform;
            }

            if (!StickToParent)
			{
                obj.transform.localPosition = Vector3.zero;
				obj.transform.parent = null;
                obj.transform.localRotation = Quaternion.identity;
          
            }

			if(OffsetRot)
            {
				obj.transform.rotation = rotation;
			}

            

			obj.SetActive(true);

			control.ap.PoolObjectList.Add(ObjectType);
		}
	}
}