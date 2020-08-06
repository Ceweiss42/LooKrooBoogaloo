using Lean.Gui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

    
    public GameObject One, Two, Three, hitbox, particleUI, musicUI;

    public static bool hitboxBool, particles, music;

    public static int cursorSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        if(cursorSpeed == 1)
        {
            One.GetComponent<LeanToggle>().On = true;

        }

        else if (cursorSpeed == 2)
        {
            Two.GetComponent<LeanToggle>().On = true;
        }

        else
        {
            Three.GetComponent<LeanToggle>().On = true;
        }

        if (hitboxBool)
        {
            hitbox.GetComponent<LeanToggle>().On = true;
        }

        else
        {
            hitbox.GetComponent<LeanToggle>().On = false;
        }

        if (particles)
        {
            particleUI.GetComponent<LeanToggle>().On = true;
        }

        else
        {
            particleUI.GetComponent<LeanToggle>().On = false;
        }

        if (music)
        {
            musicUI.GetComponent<LeanToggle>().On = true;
        }

        else
        {
            musicUI.GetComponent<LeanToggle>().On = false;
        }

        One = GameObject.Find("Radio 1 (LeanToggle + LeanButton)");
        Two = GameObject.Find("Radio 2 (LeanToggle + LeanButton)");
        Three = GameObject.Find("Radio 3 (LeanToggle + LeanButton)");

    }

    // Update is called once per frame
    void Update()
    {
        if(One.GetComponent<LeanToggle>().On)
        {
            cursorSpeed = 1;
        }
        else if (Two.GetComponent<LeanToggle>().On)
        {
            cursorSpeed = 2;
        }
        else
        {
            cursorSpeed = 3;
        }

        
        hitboxBool = hitbox.GetComponent<LeanToggle>().On;

        music = musicUI.GetComponent<LeanToggle>().On;

        particles = particleUI.GetComponent<LeanToggle>().On;
        


    }
}
