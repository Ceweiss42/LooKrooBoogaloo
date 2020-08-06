using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    public class ManualInputTwo : MonoBehaviour
    {
        private CharacterControl characterControl;

        private void Awake()
        {
            characterControl = this.gameObject.GetComponent<CharacterControl>();
        }

        void Update()
        {
            if (VirtualInputManagerTwo.Instance.MoveRight)
            {
                if (VirtualInputManagerTwo.Instance.Attack)
                {
                    VirtualInputManagerTwo.Instance.Cartwheel = true;
                    VirtualInputManagerTwo.Instance.MoveRight = false;
                    VirtualInputManagerTwo.Instance.Attack = false;
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

            if (VirtualInputManagerTwo.Instance.MoveLeft)
            {
                if (VirtualInputManagerTwo.Instance.Attack)
                {
                    VirtualInputManagerTwo.Instance.Cartwheel = true;
                    VirtualInputManagerTwo.Instance.MoveLeft = false;
                    VirtualInputManagerTwo.Instance.Attack = false;
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

            if (VirtualInputManagerTwo.Instance.Jump)
            {
                /*if(VirtualInputManagerTwo.Instance.Attack)
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

            if (VirtualInputManagerTwo.Instance.Attack)
            {
                if (!VirtualInputManagerTwo.Instance.MoveRight && !VirtualInputManagerTwo.Instance.MoveLeft)
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

            if (VirtualInputManagerTwo.Instance.Cartwheel)
            {
                characterControl.Cartwheel = true;
                characterControl.Attack = false;
            }
            else
            {
                characterControl.Cartwheel = false;

            }

            if (VirtualInputManagerTwo.Instance.Headbutt)
            {
                characterControl.Headbutt = true;
                characterControl.Attack = false;
                characterControl.Jump = false;
            }
            else
            {
                characterControl.Headbutt = false;

            }
            if (VirtualInputManagerTwo.Instance.Down)
            {
                characterControl.Down = true;
            }
            else
            {
                characterControl.Down = false;
            }

            if (VirtualInputManagerTwo.Instance.BellyFlop)
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


            if (VirtualInputManagerTwo.Instance.HammerDown)
            {
                characterControl.HammerDown = true;
                characterControl.Jump = false;
            }
            else
            {
                characterControl.HammerDown = false;
            }

            if (VirtualInputManagerTwo.Instance.Jump && VirtualInputManagerTwo.Instance.HammerDown)
            {
                characterControl.HammerDown = true;
                characterControl.Jump = false;
            }

            else
            {

            }

            if (VirtualInputManagerTwo.Instance.Shift)
            {
                characterControl.Shift = true;
            }
            else
            {
                characterControl.Shift = false;
            }

            if (VirtualInputManagerTwo.Instance.FSidekick)
            {
                characterControl.FSidekick = true;

            }
            else
            {
                characterControl.FSidekick = false;
            }

            if (VirtualInputManagerTwo.Instance.BackflipSlam)
            {
                characterControl.BackflipSlam = true;
            }
            else
            {
                characterControl.BackflipSlam = false;
            }

            if (VirtualInputManagerTwo.Instance.SpringThrow)
            {
                characterControl.SpringThrow = true;
            }

            else
            {
                characterControl.SpringThrow = false;
            }

            if (VirtualInputManagerTwo.Instance.WheelRoll)
            {
                characterControl.WheelRoll = true;
            }
            else
            {
                characterControl.WheelRoll = false;
            }

            if (VirtualInputManagerTwo.Instance.Trampoline)
            {
                characterControl.Trampoline = true;
            }

            else
            {
                characterControl.Trampoline = false;
            }

        }
    }
}