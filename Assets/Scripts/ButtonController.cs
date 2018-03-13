using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

	public Button PlayButton;
	public Button QuitButton;
	public Button MainMenuButton;

	public void PlayButtonClicked()
	{
		LoadLevel("PreLoad");
	}

	public void QuitButtonClicked()
	{
		Application.Quit();
	}

	public void MainMenuButtonClicked()
	{
		LoadLevel("MainMenu");
	}

	private void LoadLevel(string level)
	{
		SceneManager.LoadScene(level);
	}
}
