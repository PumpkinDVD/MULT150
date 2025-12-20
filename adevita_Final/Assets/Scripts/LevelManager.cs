using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "Main";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
