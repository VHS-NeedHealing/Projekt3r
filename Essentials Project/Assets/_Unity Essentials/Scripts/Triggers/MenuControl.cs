using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Menucontroller : MonoBehaviour
{
    public AudioMixer audioMixer;
    private bool musicMuted = false;
    private bool SFXMuted = false;
    public GameObject menu;
    private bool isMenuActive = false;
    // Scene.name;
    Scene scene;

    private void Start()
    {
        //scene = SceneManager.GetActiveScene();
        scene = SceneManager.GetActiveScene();
    }

    private void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.P) && scene.name == "1_Paulina_scene")
            {
                isMenuActive = !isMenuActive;
                menu.SetActive(isMenuActive);
            }
    }
   
    public void RestartPaulina()
    {
        SceneManager.LoadScene("1_Paulina_scene");
        Debug.Log("restarted");
    }
    public void RestartHania()
    {
        SceneManager.LoadScene("2_Hania_scene");
        Debug.Log("restarted");
    }
    public void RestartWiktoria()
    {
        SceneManager.LoadScene("3_Wiktoria_scene");
        Debug.Log("restarted");
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("_MainMenu_Scene");
    }
    public void ButtonMusicMute()
    {
        musicMuted = !musicMuted;
        if (musicMuted)
        {
            audioMixer.SetFloat("MusicVolume", -80f);
            Debug.Log("mute_music");
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