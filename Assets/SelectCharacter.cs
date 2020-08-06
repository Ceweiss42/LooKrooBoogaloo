using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace roundbeargames_tutorial
{

    public enum Names
    {
        EVAN,
        IAN,
        CAMERON,
        BRENDAN,
        NOAH,
        MATEO,
        WILLEN
    }
    public class SelectCharacter : MonoBehaviour
    {
        public Image playerOne, playerTwo;

        public Image source;

        public static Image displayOne, displayTwo;
        public static PCT pOnePlayer, pTwoPlayer;

        public void Start()
        {
            pOnePlayer = PCT.NONE;
            pTwoPlayer = PCT.NONE;

            displayOne = GameObject.Find("DisplayP1").GetComponent<Image>();
            displayTwo = GameObject.Find("DisplayP2").GetComponent<Image>();
            source = GetComponentInChildren<ChildImage>().GetComponent<Image>();
        }

        void Update()
        {
            if ((this.GetComponent<BoxCollider2D>().bounds.Intersects(playerOne.GetComponent<CircleCollider2D>().bounds)) && (this.GetComponent<BoxCollider2D>().bounds.Intersects(playerTwo.GetComponent<CircleCollider2D>().bounds)))
            {
                this.GetComponent<Image>().color = new Color(255, 0, 0);
                this.GetComponentInChildren<CapsuleCollider2D>().gameObject.GetComponent<Image>().enabled = true;
                //Debug.Log("Both Players have selected " + this.name);
                pTwoPlayer = this.GetComponent<CharacterControl>().playableCharacterType;
                pOnePlayer = this.GetComponent<CharacterControl>().playableCharacterType;

                displayOne.GetComponent<Image>().sprite = source.sprite;
                displayTwo.GetComponent<Image>().sprite = source.sprite;


            }

            else if (this.GetComponent<BoxCollider2D>().bounds.Intersects(playerOne.GetComponent<CircleCollider2D>().bounds))
            {
                this.GetComponent<Image>().color = new Color(255, 0, 0);
                this.GetComponentInChildren<CapsuleCollider2D>().gameObject.GetComponent<Image>().enabled = false;
                //Debug.Log("Player1 has selected " + this.name);
                pOnePlayer = this.GetComponent<CharacterControl>().playableCharacterType;
                displayOne.GetComponent<Image>().sprite = source.sprite;
            }

            else if (this.GetComponent<BoxCollider2D>().bounds.Intersects(playerTwo.GetComponent<CircleCollider2D>().bounds))
            {
                this.GetComponent<Image>().color = new Color(0, 0, 255);
                this.GetComponentInChildren<CapsuleCollider2D>().gameObject.GetComponent<Image>().enabled = false;
                //Debug.Log("Player2 has selected " + this.name);
                pTwoPlayer = this.GetComponent<CharacterControl>().playableCharacterType;
                displayTwo.GetComponent<Image>().sprite = source.sprite;
            }

            

            else
            {
                this.GetComponent<Image>().color = new Color(0, 0, 0);
                this.GetComponentInChildren<CapsuleCollider2D>().gameObject.GetComponent<Image>().enabled = false;
            }
                
        }

        public void backToHub()
        {
            SceneManager.LoadScene("Startup");
        }

        public void loadGame()
        {
            if (pOnePlayer != PCT.NONE && pTwoPlayer != PCT.NONE)
            {
                Debug.Log("Loading Scene... \n PLAYER ONE CHOSE: " + pOnePlayer + ", PLAYER TWO CHOSE: " + pTwoPlayer);
                SceneManager.LoadScene("RB/RB_Scenes/TutorialScene");

            }

            else
            {
                Debug.Log("You need to select a character first!");
            }
            
        }
    }
}

