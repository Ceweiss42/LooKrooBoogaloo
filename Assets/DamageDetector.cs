using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

namespace roundbeargames_tutorial
{
    public class DamageDetector : MonoBehaviour
    {
        CharacterControl control;
        GeneralBodyPart DamagedPart;

        [SerializeField]
        private float HP;
        private int Stocks;

        public float objectDistance;

        private void Awake()
        { 
            
            control = GetComponent<CharacterControl>();
            HP = 0.0f;
            Stocks = 3;
        }

        public float GetHP()
        {
            return HP;
        }

        public float GetStocks()
        {
            return Stocks;
        }

        private void Update()
        {
            if (AttackManager.Instance.CurrentAttacks.Count > 0)
            {
                CheckAttack();
            }

            foreach (AttackInfo info in AttackManager.Instance.CurrentAttacks)
            {
                if (info.throwable)
                { 
 
                    Vector3 vec = info.col.gameObject.transform.position - info.Attacker.transform.position;
                    //Debug.Log("Hello There" + vec.z);
                }
            }

            if(this.GetComponentInParent<BoxCollider>().transform.position.y <= -20)
            {
                Respawn();
            }
            if (this.GetComponentInParent<BoxCollider>().transform.position.z < -20 || this.GetComponentInParent<BoxCollider>().transform.position.z > 20)
            {
                Respawn();
            }
        }

        public void setDistance(float num)
        {
            objectDistance = num;
        }

        private void CheckAttack()
        {
            foreach (AttackInfo info in AttackManager.Instance.CurrentAttacks)
            {

                if (info == null)
                {
                    continue;
                }

                if (!info.isRegisterd)
                {
                    continue;
                }

                if (info.isFinished)
                {
                    continue;
                }

                

                if (info.CurrentHits >= info.MaxHits)
                {
                    continue;
                }

                if (info.Attacker == control)
                {
                    continue;
                }

                if (info.MustFaceAttacker)
                {
                    Vector3 vec = Vector3.zero;
                    if(info.Attacker.transform.position.z > this.GetComponentInParent<BoxCollider>().transform.position.z)
                    {
                         vec =  info.Attacker.transform.position - this.transform.position;
                    }

                    else if(info.Attacker.transform.position.z < this.GetComponentInParent<BoxCollider>().transform.position.z)
                    {
                         vec = this.transform.position - info.Attacker.transform.position;
                    }
                    //Debug.Log(vec.z);
                    if (vec.z < info.LethalRange )
                    {
                        TakeDamage(info);
                        break;
                    }
                }

                if(info.throwable)
                {
                    GameObject thrownObj = GameObject.Find(info.objectName);
                    

                    if(thrownObj != null)
                    {
                        
                        float dist;
                        float obj = thrownObj.transform.position.z;

                        
                        float pos = control.transform.position.z;

                        if(obj < pos)
                        {
                            dist = pos - obj;
                        }
                        else if (obj > pos)
                        {
                            dist = obj - pos;
                        }
                        else
                        {
                            dist = 0;
                        }

                        //Debug.Log("------------------------->>>>>" + dist + ",   " + obj);
                        if (dist <= info.LethalRange)
                        {
                            
                            TakeDamage(info);
                        }
                    }
                    
                }

                if (info.MustCollide)
                {
                    if (IsCollided(info))
                    {
                        TakeDamage(info);
                    }
                }
                else
                {
                    float dist = Vector3.SqrMagnitude(this.gameObject.transform.position - info.Attacker.transform.position);
                    if (dist <= info.LethalRange)
                    {
                        TakeDamage(info);
                    }
                }
            }
        }

        private bool IsCollided(AttackInfo info)
        {
            foreach (TriggerDetector trigger in control.GetAllTriggers())
            {
                foreach (Collider collider in trigger.CollidingParts)
                {
                    foreach (string name in info.ColliderNames)
                    {
                        if (name.Equals(collider.gameObject.name))
                        {
                            if (collider.transform.root.gameObject == info.Attacker.gameObject)
                            {
                                DamagedPart = trigger.generalBodyPart;
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public bool IsDead()
        {
            if (HP >= 400)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void TakeDamage(AttackInfo info)
        {

            if(IsDead())
            {
                return;
            }

            

            float d = info.getDamage();
            float h = GetHP();
            float s = info.scaler;
            float b = info.baseMultiplier;

            if (info.Attacker.FaceLeft)
            {
                control.RIGID_BODY.AddForce(-Vector3.forward * 100);
            }

            else
            {
                control.RIGID_BODY.AddForce(Vector3.forward * 100);
            }

            
            

            
            control.CacheCharacterControl(control.SkinnedMeshAnimator);
            info.CurrentHits++;

            HP += info.AttackAbility.damage;
            if (info.AttackAbility.throwable)
            {
                bruh();
                Destroy(GameObject.Find(info.objectName));
            }

            if(IsDead())
            {
                control.SkinnedMeshAnimator.runtimeAnimatorController = DeathAnimationManager.Instance.GetAnimator(DamagedPart);
            }
            else
            {
                //Debug.Log("Player is not dead");
                //reaction
            }

            AttackManager.Instance.ForceDeregister(control);
        }

        public IEnumerator bruh()
        {
            yield return new WaitForSeconds(.4f);
            

        }

        public IEnumerator DelayedDestroy()
        {
            yield return new WaitForSeconds(1f);


        }

        public void Respawn()
        {          

            if(GetStocks() != 1)
            {
                this.Stocks -= 1;
                this.GetComponentInParent<BoxCollider>().transform.position = new Vector3(0, 5, 3);
                if(this.gameObject.GetComponent<ManualInput>().enabled)
                {
                    SpawnCharacters.DeathsOne += 1;
                }

                else
                {
                    SpawnCharacters.DeathsTwo += 1;
                }
            }

            else
            {
                SceneManager.LoadScene("Dolly Group");
            }


        }


    }
}