using Cinemachine;
using roundbeargames_tutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace roundbeargames_tutorial
{
    public class SpawnCharactersTwo : MonoBehaviour
    {
        public PCT playerOneChar, playerTwoChar;

        public string Damage, Stocks;

        public CharacterControl pOne;
        public GameObject d, s;

        [SerializeField]
        public static int DeathsOne, DeathsTwo;
        public int DOne, DTwo;

        public GameObject[] edges;


        // Start is called before the first frame update
        void Start()
        {

            d = GameObject.Find(Damage);
            s = GameObject.Find(Stocks);

            playerOneChar = SelectCharacter.pOnePlayer;
            playerTwoChar = SelectCharacter.pTwoPlayer;

            SpawnPlayers(playerOneChar, playerTwoChar);

        }

        // Update is called once per frame
        void Update()
        {
            DOne = GetDeathOne();
            DTwo = GetDeathTwo();

            edges = GameObject.FindGameObjectsWithTag("ColliderEdge");

            for (int i = 0; i < edges.Length; i++)
            {
                edges[i].GetComponent<MeshRenderer>().enabled = Settings.hitboxBool;
            }


        }

        public void SpawnPlayers(PCT one, PCT two)
        {
            string objName = "";

            switch (two)
            {
                case PCT.NONE:
                    {
                        objName = "Mateo";
                    }
                    break;
                case PCT.MATEO:
                    {
                        objName = "Mateo";
                    }
                    break;
                case PCT.EVAN:
                    {
                        objName = "Evan";
                    }
                    break;
                case PCT.WILLEN:
                    {
                        objName = "Mateo";
                    }
                    break;
                case PCT.NOAH:
                    {
                        objName = "Mateo";
                    }
                    break;
                case PCT.BRENDAN:
                    {
                        objName = "Mateo";
                    }
                    break;
                case PCT.CAMERON:
                    {
                        objName = "Mateo";
                    }
                    break;
                case PCT.IAN:
                    {
                        objName = "Mateo";
                    }
                    break;
                case PCT.RANDOM:
                    {
                        objName = "Mateo";
                    }
                    break;



            }

            GameObject obj = Instantiate(Resources.Load(objName, typeof(GameObject)) as GameObject); ;
            obj.transform.position = this.transform.position;
            this.GetComponent<MeshRenderer>().enabled = false;

            pOne = obj.GetComponent<CharacterControl>();
            d.GetComponent<UIDamageText>().dd = pOne;
            s.GetComponent<UIStocksText>().cc = pOne;
            //s.GetComponent<UIStocksText>().dd = obj.GetComponent<DamageDetector>();
            obj.GetComponent<ManualInput>().enabled = false;
            obj.GetComponent<ManualInputTwo>().enabled = true;

            GameObject.Find("Targetgroup").GetComponent<CinemachineTargetGroup>().AddMember(obj.transform, 1, 0);

            obj.GetComponentInChildren<FollowPlayer>().uiArrow = GameObject.Find("Image RED").GetComponent<Image>();
        }

        public int GetDeathOne()
        {
            return DeathsOne;
        }
        public int GetDeathTwo()
        {
            return DeathsTwo;
        }
    }

}
