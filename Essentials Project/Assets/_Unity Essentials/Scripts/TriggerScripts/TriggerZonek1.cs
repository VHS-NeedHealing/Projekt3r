using UnityEngine;

public class TriggerZonek1 : MonoBehaviour
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


    // Update is called once per frame
    void Update()
    {
        
    }
}
