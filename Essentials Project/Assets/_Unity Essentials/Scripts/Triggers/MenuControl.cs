using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public AudioMixer audioMixer;
    private bool musicMuted = false;
    private bool SFXMuted = false;
    public GameObject menu;
    private bool isMenuActive = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isMenuActive = !isMenuActive;
            menu.SetActive(isMenuActive);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Hania_scene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ButtonMusicMute()
    {
        musicMuted = !musicMuted;
        if (musicMuted)
        {
            audioMixer.SetFloat("MusicVolume", -80f);
        }
        else
        {
            audioMixer.SetFloat("MusicVolume", 0f);
        }
    }
    public void ButtonSFXMute()
    {
        SFXMuted = !SFXMuted;
        if (SFXMuted)
        {
            audioMixer.SetFloat("SFXVolume", -80f);
        }
        else
        {
            audioMixer.SetFloat("SFXVolume", 0f);
        }
    }
    public void SetMusicVolume(float sliderVolume)
    {
        float db = Mathf.Lerp(-80f, 20f, sliderVolume);
        audioMixer.SetFloat("MusicVolume", db);
    }
    public void SetSFXVolume(float sliderVolume)
    {
        float db = Mathf.Lerp(-80f, 20f, sliderVolume);
        audioMixer.SetFloat("SFXVolume", db);
    }
}