using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour
{

    [SerializeField] private AudioSource click_sound;

    public void OpenItchio()
    {
        click_sound.Play();
        Application.OpenURL("https://dandelikeslion.itch.io/");
    }

    public void OpenPortfolio()
    {
        click_sound.Play();
        Application.OpenURL("https://jpro44.wixsite.com/-jeanne-boudouresque");
    }
}