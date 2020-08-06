using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    public class Throwable : MonoBehaviour
    {

        public float pos;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            pos = this.gameObject.transform.position.z;
            //Debug.Log(this.gameObject.transform.position.z);
            if(!this.gameObject.transform.parent == null)
            {
                this.gameObject.transform.root.GetComponent<DamageDetector>().setDistance(pos);
            }
            else
            {
                //Debug.Log("Object has no parent");
            }
            
                
        }

    }
}

