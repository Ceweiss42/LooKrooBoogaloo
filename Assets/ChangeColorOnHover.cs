using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace roundbeargames_tutorial
{
    public class ChangeColorOnHover : MonoBehaviour
    {
        public CircleCollider2D p1, p2;

        public List<Image> playerCubes = new List<Image>();

        void Start()
        {
            p1 = GetComponent<CircleCollider2D>();
            p2 = GetComponent<CircleCollider2D>();

            
        }
        
        void Update()
        {
            foreach (Image c in playerCubes)
            {
               if(p1.bounds.Intersects(c.GetComponent<BoxCollider2D>().bounds))
                {
                    c.color = new Color(255, 0, 0);
                }
            }
        }
    }
}