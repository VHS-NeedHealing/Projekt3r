using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TrigerrMessageWall : MonoBehaviour
{

    public TextMeshProUGUI doorMessage;
    //zmiennna do przechowywania okreœlonych danych

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            doorMessage.text = "It's a wall";
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
        Debug.Log("Wall popup");
    }
}
