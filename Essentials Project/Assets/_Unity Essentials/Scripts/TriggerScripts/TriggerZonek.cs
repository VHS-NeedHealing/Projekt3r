using UnityEngine;

public class TriggerZonek : MonoBehaviour
{
    public TMPro.TextMeshProUGUI doorMessage;
    //zmienna
    void Start()
    {
        
    } 
    private void OnTriggerEnter2D(Collider2D collision)   
    {
        if(collision.CompareTag("Player"))
        {
           doorMessage.text="Door is locked";
           doorMessage.gameObject.SetActive(true);
        }
    }
    onTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
           doorMessage.gameObject.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
