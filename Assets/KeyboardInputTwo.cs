using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace roundbeargames_tutorial
{
    public class KeyboardInputTwo : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (Input.GetKey(KeyCode.Keypad1))
                {
                    VirtualInputManagerTwo.Instance.Cartwheel = true;
                }
                else
                {
                    VirtualInputManagerTwo.Instance.MoveRight = true;
                    VirtualInputManagerTwo.Instance.Cartwheel = false;
                }

            }
            else
            {
                VirtualInputManagerTwo.Instance.MoveRight = false;
                VirtualInputManagerTwo.Instance.Cartwheel = false;

            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (Input.GetKey(KeyCode.Keypad1))
                {
                    VirtualInputManagerTwo.Instance.Cartwheel = true;
                }
                else
                {
                    VirtualInputManagerTwo.Instance.MoveLeft = true;
                    VirtualInputManagerTwo.Instance.Cartwheel = false;
                }

            }
            else
            {
                VirtualInputManagerTwo.Instance.MoveLeft = false;
                VirtualInputManagerTwo.Instance.Cartwheel = false;

            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                VirtualInputManagerTwo.Instance.Jump = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.Jump = false;
            }

            if (Input.GetKey(KeyCode.Keypad1))
            {
                VirtualInputManagerTwo.Instance.Attack = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.Attack = false;
            }

            if (((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.RightArrow))) && (Input.GetKey(KeyCode.Keypad1)))
            {
                VirtualInputManagerTwo.Instance.Cartwheel = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.Cartwheel = false;
            }

            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.Keypad1))
            {
                VirtualInputManagerTwo.Instance.Headbutt = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.Headbutt = false;
            }

            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.Keypad1))
            {
                VirtualInputManagerTwo.Instance.BellyFlop = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.BellyFlop = false;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                VirtualInputManagerTwo.Instance.Down = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.Down = false;
            }

            if (Input.GetKey(KeyCode.Keypad2))
            {
                VirtualInputManagerTwo.Instance.Smash = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.Smash = false;
            }

            if (Input.GetKey(KeyCode.Keypad2) && Input.GetKey(KeyCode.UpArrow))
            {
                VirtualInputManagerTwo.Instance.Smash = false;
                VirtualInputManagerTwo.Instance.HammerDown = true;
                VirtualInputManagerTwo.Instance.Jump = false;
            }
            else
            {
                VirtualInputManagerTwo.Instance.HammerDown = false;
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                VirtualInputManagerTwo.Instance.Shift = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.Shift = false;
            }

            if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) && Input.GetKey(KeyCode.Keypad2))
            {
                VirtualInputManagerTwo.Instance.FSidekick = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.FSidekick = false;
            }

            if ((Input.GetKey(KeyCode.DownArrow)) && Input.GetKey(KeyCode.Keypad2))
            {
                VirtualInputManagerTwo.Instance.BackflipSlam = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.BackflipSlam = false;
            }

            if (Input.GetKey(KeyCode.Keypad3))
            {
                VirtualInputManagerTwo.Instance.SpringThrow = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.SpringThrow = false;
            }

            if (Input.GetKey(KeyCode.Keypad3) && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)))
            {
                VirtualInputManagerTwo.Instance.WheelRoll = true;
            }

            else
            {
                VirtualInputManagerTwo.Instance.WheelRoll = false;
            }

            if ((Input.GetKey(KeyCode.UpArrow)) && Input.GetKey(KeyCode.Keypad3))
            {
                VirtualInputManagerTwo.Instance.Trampoline = true;
            }
            else
            {
                VirtualInputManagerTwo.Instance.Trampoline = false;
            }
        }
    }
}

