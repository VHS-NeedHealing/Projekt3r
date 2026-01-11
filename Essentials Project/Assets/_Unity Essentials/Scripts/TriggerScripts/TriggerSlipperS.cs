using UnityEngine;

public class TriggerSlipperS : MonoBehaviour
{
    public TMPro.TextMeshProUGUI slipperSMessage;
    //zmienna
       private bool hasRun = false;
    
    private void OnTriggerEnter2D(Collider2D collision)   
    {
        if(collision.CompareTag("Player") && !hasRun)
        {
           slipperSMessage.text="That's a fancy pair of slippers!";
           slipperSMessage.gameObject.SetActive(true);
        }
     }
    private void OnTriggerExit2D(Collider2D collision)
     {
        if(collision.CompareTag("Player"))
        {
           slipperSMessage.gameObject.SetActive(false);
           hasRun = true;
        }
     }
    
    void Update()
    {
        Debug.Log("hell");
    }
}
