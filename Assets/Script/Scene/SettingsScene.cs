using UnityEngine;
using UnityEngine.SceneManagement;


public class SettingsScene : MonoBehaviour
{
    public int num_scnene = 1;
    public AudioSource Music;

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Music.mute = true;

    }

    public void LoadScene()
    {
        //PlayerPrefs.SetInt("DuctTapeScope", PlayerPrefs.GetInt("DuctTapeScope", 0) + allobjscale.DuctTape);   next update "save obj exit pause game"
        SceneManager.LoadScene(num_scnene);
    }
    public void RestartScene()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

    public void ApplicationExit()
    {
        Application.Quit();
    }
}
