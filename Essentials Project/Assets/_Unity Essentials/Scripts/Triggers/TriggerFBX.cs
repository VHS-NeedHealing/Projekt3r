using UnityEngine;
using UnityEngine.Audio;


public class TriggerSFX : MonoBehaviour
{
 
   public AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D collison)
    {

        if (collison.CompareTag("Player"))
        {
            audioSource.Play();
        }
        Debug.Log("Trigger SFX played");
    }

}