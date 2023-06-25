using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEliminar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<SpriteRenderer>().enabled = false;
        gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
        Destroy(gameObject, 0.3f);
    }
}
