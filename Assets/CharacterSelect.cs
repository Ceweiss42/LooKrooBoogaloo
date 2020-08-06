using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
	public enum PCT
	{
		NONE,
		MATEO,
		EVAN,
		BRENDAN,
		NOAH,
		WILLEN,
		CAMERON,
		IAN,
		RANDOM,
	}

	[CreateAssetMenu(fileName = "characterSelect", menuName = "Roundbeargames/CharacterSelect/CharacterSelect")]
	public class CharacterSelect : ScriptableObject
	{
		public PCT SelectedCharacterType;
	}
}