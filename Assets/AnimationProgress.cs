using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
	public class AnimationProgress : MonoBehaviour
	{
		public List<PoolObjectType> PoolObjectList = new List<PoolObjectType>();
        public GameObject blockingObj;

		[Header("UpdateBoxCollider")]
		public float sizeSpeed, centerSpeed;
		public Vector3 targetSize, targetCenter;
		public bool Updating;
		public bool Updating_Spheres;
        public bool Taking_Damage;
        public bool isSpawned;

        public bool AttackTriggered;
        public float MaxPressTime;

        [SerializeField]
        private float pressTime;
         

        private CharacterControl control;


        public void Awake()
        {
            control = GetComponentInParent<CharacterControl>();
            pressTime = 0f;
        }
        public void Update()
        {
            if(control.Attack)
            {
                pressTime += Time.deltaTime;
            }

            else
            {
                pressTime = 0f;
            }

            if(pressTime == 0)
            {
                AttackTriggered = false;
            }

            if(pressTime > MaxPressTime)
            {
                AttackTriggered = false;
            }

            else
            {
                AttackTriggered = true;
            }
        }

    }
}
