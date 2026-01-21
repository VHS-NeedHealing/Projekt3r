using UnityEngine;

public class TriggerCat : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("MEOW");


    }
}
