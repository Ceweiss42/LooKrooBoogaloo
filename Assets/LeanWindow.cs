using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lean.Gui
{
	/// <summary>This component works just like LeanToggle, but it registers itself with the LeanWindowCloser.
	/// This allows the window to be automatically closed if you press the LeanWindowCloser.CloseKey.</summary>
	[HelpURL(LeanGui.HelpUrlPrefix + "LeanWindow")]
	[AddComponentMenu(LeanGui.ComponentMenuPrefix + "Window")]
	public class LeanWindow : LeanToggle
	{
		protected override void TurnOnNow()
		{
			base.TurnOnNow();

			LeanWindowCloser.Register(this);
		}

        public void startGame()
        {
            SceneManager.LoadScene("RB/RB_Scenes/TutorialScene");
        }

        public void backToHub()
        {
            SceneManager.LoadScene("Startup");
        }

        public void settingsScene()
        {
            SceneManager.LoadScene("SettingsMenu");
        }

        public void quitGame()
        {
            Application.Quit();
            Debug.Log("Quit the Game");
        }

        public void Selected(string player)
        {
            Debug.Log("Player has selected " + player);
        }

        public void loadCharSelect()
        {
            SceneManager.LoadScene("Change Color on Hover");
        }
	}
}