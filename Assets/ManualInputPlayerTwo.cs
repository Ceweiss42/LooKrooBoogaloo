using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    public class ManualInputPlayerTwo : MonoBehaviour
    {
        private CharacterControl characterControl;

        private void Awake()
        {
            characterControl = this.gameObject.GetComponent<CharacterControl>();
        }

        void Update()
        {
            if (VirtualInputManagerPlayerTwo.Instance.MoveRight)
            {
                if (VirtualInputManagerPlayerTwo.Instance.Attack)
                {
                    VirtualInputManagerPlayerTwo.Instance.Cartwheel = true;
                    VirtualInputManagerPlayerTwo.Instance.MoveRight = false;
                    VirtualInputManagerPlayerTwo.Instance.Attack = false;
                    characterControl.Cartwheel = true;
                }
                else
                {
                    characterControl.MoveRight = true;
                    characterControl.Cartwheel = false;
                }

            }
            else
            {
                characterControl.MoveRight = false;
            }

            if (VirtualInputManagerPlayerTwo.Instance.MoveLeft)
            {
                if (VirtualInputManagerPlayerTwo.Instance.Attack)
                {
                    VirtualInputManagerPlayerTwo.Instance.Cartwheel = true;
                    VirtualInputManagerPlayerTwo.Instance.MoveLeft = false;
                    VirtualInputManagerPlayerTwo.Instance.Attack = false;
                    characterControl.Cartwheel = true;
                }
                else
                {
                    characterControl.MoveLeft = true;
                    characterControl.Cartwheel = false;
                }

            }
            else
            {
                characterControl.MoveLeft = false;
            }

            if (VirtualInputManagerPlayerTwo.Instance.Jump)
            {
                /*if(VirtualInputManager.Instance.Attack)
				{
					characterControl.Cartwheel = true;
					characterControl.Jump = false;
				}
				else
				{*/
                characterControl.Jump = true;
                //}

            }
            else
            {
                characterControl.Jump = false;
            }

            if (VirtualInputManagerPlayerTwo.Instance.Attack)
            {
                if (!VirtualInputManagerPlayerTwo.Instance.MoveRight && !VirtualInputManagerPlayerTwo.Instance.MoveLeft)
                {
                    characterControl.Attack = true;
                }
                else
                {
                    characterControl.Attack = false;
                    characterControl.Cartwheel = true;
                }


            }
            else
            {
                characterControl.Attack = false;
            }

            if (VirtualInputManagerPlayerTwo.Instance.Cartwheel)
            {
                characterControl.Cartwheel = true;
                characterControl.Attack = false;
            }
            else
            {
                characterControl.Cartwheel = false;

            }

            if (VirtualInputManagerPlayerTwo.Instance.Headbutt)
            {
                characterControl.Headbutt = true;
                characterControl.Attack = false;
                characterControl.Jump = false;
            }
            else
            {
                characterControl.Headbutt = false;

            }
            if (VirtualInputManagerPlayerTwo.Instance.Down)
            {
                characterControl.Down = true;
            }
            else
            {
                characterControl.Down = false;
            }

            if (VirtualInputManagerPlayerTwo.Instance.BellyFlop)
            {
                characterControl.BellyFlop = true;
                characterControl.Attack = false;
                characterControl.Jump = false;
                characterControl.Down = false;
            }
            else
            {
                characterControl.BellyFlop = false;

            }


            if (VirtualInputManagerPlayerTwo.Instance.HammerDown)
            {
                characterControl.HammerDown = true;
                characterControl.Jump = false;
            }
            else
            {
                characterControl.HammerDown = false;
            }

            if (VirtualInputManagerPlayerTwo.Instance.Jump && VirtualInputManagerPlayerTwo.Instance.HammerDown)
            {
                characterControl.HammerDown = true;
                characterControl.Jump = false;
            }

            else
            {

            }

            if (VirtualInputManagerPlayerTwo.Instance.Shift)
            {
                characterControl.Shift = true;
            }
            else
            {
                characterControl.Shift = false;
            }

            if (VirtualInputManagerPlayerTwo.Instance.FSidekick)
            {
                characterControl.FSidekick = true;

            }
            else
            {
                characterControl.FSidekick = false;
            }

            if (VirtualInputManagerPlayerTwo.Instance.BackflipSlam)
            {
                characterControl.BackflipSlam = true;
            }
            else
            {
                characterControl.BackflipSlam = false;
            }

        }
    }
}