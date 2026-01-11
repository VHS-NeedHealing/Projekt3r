using UnityEngine;

public class Trigger2mm : MonoBehaviour
{
    public TMPro.TextMeshProUGUI catMessage;
    //zmienna
       private bool hasRun = false;
    
    private void OnTriggerEnter2D(Collider2D collision)   
    {
        if(collision.CompareTag("Player") && !hasRun)
        {
           catMessage.text="Miau!";
           catMessage.gameObject.SetActive(true);
        }
     }
    private void OnTriggerExit2D(Collider2D collision)
     {
        if(collision.CompareTag("Player"))
        {
           catMessage.gameObject.SetActive(false);
           hasRun = true;
        }
     }
    
    void Update()
    {
        Debug.Log("hell");
    }
}
