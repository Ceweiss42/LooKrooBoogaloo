using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

namespace roundbeargames_tutorial
{
	public class UIStocksText : MonoBehaviour
	{
		public CharacterControl cc;
		public TextMeshProUGUI stocks;
		// Start is called before the first frame update
		void Start()
		{
			stocks = GetComponent<TextMeshProUGUI>();
		}

		// Update is called once per frame
		void Update()
		{
			stocks.text = "DEATHS: " + cc.dd.GetStocks();

		}
	}

}
