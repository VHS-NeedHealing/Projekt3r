using UnityEngine;

public class TrigerrMessage : MonoBehaviour
{
    public TMPro.TextMeshProUGUI doorMessage;
    //zmienna
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            doorMessage.text = "Door is locked.";
            doorMessage.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            doorMessage.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}