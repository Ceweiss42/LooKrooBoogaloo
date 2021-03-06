﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace roundbeargames_tutorial
{
    public class Ledge : MonoBehaviour
    {
        public Vector3 EndPosition;
        public Vector3 Offset;
        public LedgeChecker lc;

        public static bool IsLedge(GameObject obj)
        {
            if (obj.GetComponent<Ledge>() == null)
            {
                return false;
            }

            return true;
        }

        public static bool IsLedgeChecker(GameObject obj)
        {
            if (obj.GetComponent<LedgeChecker>() == null)
            {
                return false;
            }

            return true;
        }
    }
}

