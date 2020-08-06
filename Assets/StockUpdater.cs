using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


namespace roundbeargames_tutorial
{
    public class StockUpdater : MonoBehaviour
    {

        public TextMeshProUGUI stocks;
        public string one, two;
        public TextMeshProUGUI oT, tT;
        void Start()
        {
            stocks = GetComponent<TextMeshProUGUI>();
        }

        // Update is called once per frame
        void Update()
        {
            one = oT.text;
            two = tT.text;
            if(one.Contains("DEATHS: "))
            {
                one = one.Substring(8);

            }

            if (two.Contains("DEATHS: "))
            {
                two = two.Substring(8);

            }

            stocks.text = one + " - " + two;
        }
    }
}

