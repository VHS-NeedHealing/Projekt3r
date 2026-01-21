using UnityEngine;

public class TriggerCat01 : MonoBehaviour
{
    public TMPro.TextMeshProUGUI catMessage;
    //zmienna
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            catMessage.text = "MEOW";
            catMessage.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            catMessage.gameObject.SetActive(false);
     
        }
    }

    void Update()
    {
        Debug.Log("Cat meows");
    }
}