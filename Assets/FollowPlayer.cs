using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace roundbeargames_tutorial
{
    public class FollowPlayer : MonoBehaviour
    {
        public Image uiArrow;
        public double fieldOfView;

        public Quaternion normalRotation;
        public Quaternion calculatedRotation;

        public Quaternion Left, Right, Up;

        public Vector3 zero;



        void Update()
        {

            fieldOfView = Camera.main.fieldOfView;
            float scale = (float)(24.5 / fieldOfView);

            uiArrow.transform.localScale = new Vector3(scale, scale, scale);

            Vector3 tracker = Camera.main.WorldToScreenPoint(this.transform.position);
           uiArrow.transform.position = tracker;

            Vector3 pos = uiArrow.transform.position;

            pos.x = Mathf.Clamp(pos.x, (float)(1000 / fieldOfView), Screen.width - (float)(1000 / fieldOfView));
            pos.y = Mathf.Clamp(pos.y, (float)(2000 / fieldOfView), Screen.height - (float)(500 / fieldOfView));
            uiArrow.transform.position = pos;

            if((uiArrow.transform.position.y < Screen.height - (float)(500 / fieldOfView) - 10) && (uiArrow.transform.position.y > (float)(2000 / fieldOfView)))
            {
                if ((uiArrow.transform.position.x > (float)(1000 / fieldOfView)) && (uiArrow.transform.position.y < Screen.width - (float)(1000 / fieldOfView)))
                {
                    uiArrow.transform.rotation = normalRotation;
                }

                else
                {

                    Vector2 target = Camera.main.WorldToScreenPoint(this.transform.position);

                    Vector2 arrow = uiArrow.transform.position;

                    Vector2 difference = arrow - target;
                    //Debug.Log(difference);

                    if (difference.x < .1f && difference.y < .1f)
                    {
                        uiArrow.transform.rotation = normalRotation;
                    }

                    else if (difference.x < .1f)
                    {
                        uiArrow.transform.rotation = Right;
                    }
                    else if (difference.x < -.1f)
                    {
                        uiArrow.transform.rotation = Left;
                    }

                    else if(difference.y < .1f)
                    {
                        uiArrow.transform.rotation = Up;
                    }

                    else
                    {
                        double bruh = Math.Atan(Math.Abs(difference.x) / difference.y);

                        calculatedRotation.z = (float)bruh;


                        uiArrow.transform.rotation = calculatedRotation;
                        
                    }
                    
                }
                
            }

            else
            {

                Vector2 target = Camera.main.WorldToScreenPoint(this.transform.position);

                Vector2 arrow = uiArrow.transform.position;

                Vector2 difference = target - arrow ;
                //Debug.Log(difference);

                if(difference.x < .1f && difference.y < .1f)
                {
                    uiArrow.transform.rotation = normalRotation;
                }

                else if (difference.x < .1f)
                {
                    uiArrow.transform.rotation = Left;
                }
                else if (difference.x < -.1f)
                {
                    uiArrow.transform.rotation = Right;
                }

                else if (difference.y < .1f)
                {
                    uiArrow.transform.rotation = Up;
                }
                else
                {
                    double bruh = Math.Atan(Math.Abs(difference.x) / difference.y);

                    calculatedRotation.z = (float)bruh;


                    uiArrow.transform.rotation = calculatedRotation;
                    
                }
                
            }






        }
    }
    



}