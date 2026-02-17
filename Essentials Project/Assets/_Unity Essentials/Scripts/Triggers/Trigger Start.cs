using UnityEngine;

public class TrigerrStartMessage : MonoBehaviour
{
    public TMPro.TextMeshProUGUI StartMessage;
    //zmienna
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartMessage.text = "What a mess!!";
            StartMessage.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartMessage.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}