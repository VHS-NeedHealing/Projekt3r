using UnityEngine;

public class StorySC : MonoBehaviour
{
    public TMPro.TextMeshProUGUI storySMessage;
    //zmienna
       private bool hasRun = false;
    
    private void OnTriggerEnter2D(Collider2D collision)   
    {
        if(collision.CompareTag("Player") && !hasRun)
        {
           storySMessage.text="I have to collect all these triangles so I can go home.";
           storySMessage.gameObject.SetActive(true);
        }
     }
    private void OnTriggerExit2D(Collider2D collision)
     {
        if(collision.CompareTag("Player"))
        {
           storySMessage.gameObject.SetActive(false);
           hasRun = true;
        }
     }
    
}