using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;

namespace roundbeargames_tutorial
{
    public enum PoolObjectType
    {
        ATTACKINFO,
        PUTTER,
        PUTTER_VFX,
        SPRING,
        WHEEL,
        TRAMPOLINE,
        SIDEKICK,
        BELLYFLOP,
        BUTTSLAM,
        GRENADE,
        EXPLOSION,
        HANDS,
        CLAP,
        LACROSSE_STICK,

    }

    public class PoolObjectLoader : MonoBehaviour
    {
        public static PoolObject InstantiatePrefab(PoolObjectType objType)
        {
            GameObject obj = null;

            switch (objType)
            {
                case PoolObjectType.ATTACKINFO:
                    {
                        obj = Instantiate(Resources.Load("AttackInfo", typeof(GameObject)) as GameObject);
                        break;
                    }
				case PoolObjectType.PUTTER:
					{
						obj = Instantiate(Resources.Load("Putter", typeof(GameObject)) as GameObject);
						break;
					}
				case PoolObjectType.PUTTER_VFX:
					{
						obj = Instantiate(Resources.Load("CFX2_RockHit", typeof(GameObject)) as GameObject);
						break;
					}
                case PoolObjectType.SPRING:
                    {
                        obj = Instantiate(Resources.Load("Spring", typeof(GameObject)) as GameObject);
                        break;
                    }
                case PoolObjectType.WHEEL:
                    {
                        obj = Instantiate(Resources.Load("Wheel", typeof(GameObject)) as GameObject);
                        break;
                    }
                case PoolObjectType.TRAMPOLINE:
                    {
                        obj = Instantiate(Resources.Load("Trampoline", typeof(GameObject)) as GameObject);
                        break;
                    }
                case PoolObjectType.SIDEKICK:
                    {
                        obj = Instantiate(Resources.Load("CFX_MagicPoof", typeof(GameObject)) as GameObject);
                        break;
                    }
                case PoolObjectType.BELLYFLOP:
                    {
                        obj = Instantiate(Resources.Load("CFX3_Hit_SmokePuff", typeof(GameObject)) as GameObject);
                        break;
                    }
                case PoolObjectType.BUTTSLAM:
                    {
                        obj = Instantiate(Resources.Load("CFX4 Drill Air Hit (NO COLLISION)", typeof(GameObject)) as GameObject);
                        break;
                    }

                case PoolObjectType.GRENADE:
                    {
                        obj = Instantiate(Resources.Load("Battery", typeof(GameObject)) as GameObject);
                        break;
                    }

                case PoolObjectType.EXPLOSION:
                    {
                        obj = Instantiate(Resources.Load("CFX_Explosion_B_Smoke+Text", typeof(GameObject)) as GameObject);
                        break;
                    }
                case PoolObjectType.HANDS:
                    {
                        obj = Instantiate(Resources.Load("Hands", typeof(GameObject)) as GameObject);
                        break;
                    }

                case PoolObjectType.CLAP:
                    {
                        obj = Instantiate(Resources.Load("CFX_Hit_C White", typeof(GameObject)) as GameObject);
                        break;
                    }
                case PoolObjectType.LACROSSE_STICK:
                    {
                        obj = Instantiate(Resources.Load("Putter", typeof(GameObject)) as GameObject);
                        break;
                    }
            }

            return obj.GetComponent<PoolObject>();
        }
    }
}