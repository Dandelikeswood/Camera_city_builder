using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string levelToLoad;

    public GameObject controlsWindow;
    public GameObject creditsWindow;
    [SerializeField] private AudioSource click_sound;


    public void StartGame()
    {
        click_sound.Play();
        SceneManager.LoadScene(levelToLoad);
    }

    public void OpenControlsWindow()
    {
        click_sound.Play();
        controlsWindow.SetActive(true);
    }

    public void OpenCreditsWindow()
    {
        click_sound.Play();
        creditsWindow.SetActive(true);
    }

    public void CloseControlsWindow()
    {
        click_sound.Play();
        controlsWindow.SetActive(false);
    }

    public void CloseCreditsWindow()
    {
        click_sound.Play();
        creditsWindow.SetActive(false);
    }

    public void QuitGame()
    {
        click_sound.Play();
        Application.Quit();
    }
}