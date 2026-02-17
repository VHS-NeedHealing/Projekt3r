using UnityEngine;

public class TrigerrCat : MonoBehaviour
{
    public TMPro.TextMeshProUGUI CatMessage;
    
    private bool hasRun = false;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasRun)
        {
            CatMessage.text = "Mrrrrrr, Miau O.o! ";
            CatMessage.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           CatMessage.gameObject.SetActive(false);
            hasRun = true;
        }
    }
}
