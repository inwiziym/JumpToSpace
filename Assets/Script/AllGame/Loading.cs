using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Loading : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public AudioSource Music;

    public void LoadLvl(int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex));
        Time.timeScale = 0;
        Music.mute = true;

    }

    IEnumerator LoadAsync(int sceneIndex)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            slider.value = progress;
            Time.timeScale = 0;
            Music.mute = true;
            progressText.text = progress * 100f + "%";
            yield return null;
        }
    }
}
