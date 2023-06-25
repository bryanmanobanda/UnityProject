using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalScore : MonoBehaviour
{
    public Text gScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gScore.text = Score.globalPoints.ToString();
        GetComponent<SpriteRenderer>().enabled = false;
        gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
        Destroy(gameObject, 0.3f);
    }
}