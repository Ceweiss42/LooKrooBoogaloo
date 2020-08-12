using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    public class AttackInfo : MonoBehaviour
    {
        public CharacterControl Attacker = null;
        public Attack AttackAbility;
        public List<string> ColliderNames = new List<string>();
        //public DeathType deathType;
        public bool MustCollide;
        public bool MustFaceAttacker;
        public float LethalRange;
        public int MaxHits;
        public int CurrentHits;
        public bool isRegisterd;
        public bool isFinished;
        public float Damage;
        public float scaler;
        public float baseMultiplier;
        public bool throwable;
        public Collider col;
        public string objectName;
        public bool bouncy;
        public Vector3 knockAngle;

        public void ResetInfo(Attack attack, CharacterControl attacker)
        {
            isRegisterd = false;
            isFinished = false;
            AttackAbility = attack;
            Attacker = attacker;
            
        }

        public void Register(Attack attack)
        {
            isRegisterd = true;

            AttackAbility = attack;
            ColliderNames = attack.ColliderNames;
            //deathType = attack.deathType;
            MustCollide = attack.MustCollide;
            MustFaceAttacker = attack.MustFaceAttacker;
            LethalRange = attack.LethalRange;
            MaxHits = attack.MaxHits;
            CurrentHits = 0;
            Damage = attack.damage;
            scaler = attack.scaler;
            baseMultiplier = attack.baseMultiplier;
            throwable = attack.throwable;
            col = attack.collider;
            objectName = attack.objectName;
            bouncy = attack.bouncy;
            knockAngle = attack.knockAngle;
             
        }

        private void OnDisable()
        {
            isFinished = true;
        }

        public float getDamage()
        {
            return Damage;
        }
    }
}
