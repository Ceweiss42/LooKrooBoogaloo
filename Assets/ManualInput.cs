using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    public class ManualInput : MonoBehaviour
    {
        private CharacterControl characterControl;

        private void Awake()
        {
            characterControl = this.gameObject.GetComponent<CharacterControl>();
        }

        void Update()
        {
			if (VirtualInputManager.Instance.MoveRight)
			{
				if (VirtualInputManager.Instance.Attack)
				{
					VirtualInputManager.Instance.Cartwheel = true;
					VirtualInputManager.Instance.MoveRight = false;
					VirtualInputManager.Instance.Attack = false;
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

			if (VirtualInputManager.Instance.MoveLeft)
			{
				if (VirtualInputManager.Instance.Attack)
				{
					VirtualInputManager.Instance.Cartwheel = true;
					VirtualInputManager.Instance.MoveLeft = false;
					VirtualInputManager.Instance.Attack = false;
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

			if (VirtualInputManager.Instance.Jump)
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

            if (VirtualInputManager.Instance.Attack)
            {
                if(!VirtualInputManager.Instance.MoveRight && !VirtualInputManager.Instance.MoveLeft)
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

			if (VirtualInputManager.Instance.Cartwheel)
			{
				characterControl.Cartwheel = true;
				characterControl.Attack = false;
			}
			else
			{
				characterControl.Cartwheel = false;

			}

			if (VirtualInputManager.Instance.Headbutt)
			{
				characterControl.Headbutt = true;
				characterControl.Attack = false;
				characterControl.Jump = false;
			}
			else
			{
				characterControl.Headbutt = false;

			}
            if(VirtualInputManager.Instance.Down)
			{
				characterControl.Down = true;
			}
			else
			{
				characterControl.Down = false;
			}

			if (VirtualInputManager.Instance.BellyFlop)
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


			if (VirtualInputManager.Instance.HammerDown)
			{
				characterControl.HammerDown = true;
				characterControl.Jump = false;
			}
			else
			{
				characterControl.HammerDown = false;
			}

            if(VirtualInputManager.Instance.Jump && VirtualInputManager.Instance.HammerDown)
			{
				characterControl.HammerDown = true;
				characterControl.Jump = false;
			}

            else
			{

			}

            if(VirtualInputManager.Instance.Shift)
			{
				characterControl.Shift = true;
			}
			else
			{
				characterControl.Shift = false;
			}

            if(VirtualInputManager.Instance.FSidekick)
            {
                characterControl.FSidekick = true;

            }
            else
            {
                characterControl.FSidekick = false;
            }

            if(VirtualInputManager.Instance.BackflipSlam)
            {
                characterControl.BackflipSlam = true;
            }
            else
            {
                characterControl.BackflipSlam = false;
            }

            if(VirtualInputManager.Instance.SpringThrow)
            {
                characterControl.SpringThrow = true;
            }

            else
            {
                characterControl.SpringThrow = false;
            }

            if(VirtualInputManager.Instance.WheelRoll)
            {
                characterControl.WheelRoll = true;
            }
            else
            {
                characterControl.WheelRoll = false;
            }

            if(VirtualInputManager.Instance.Trampoline)
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