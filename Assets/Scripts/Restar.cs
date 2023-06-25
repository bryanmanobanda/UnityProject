using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restar : MonoBehaviour
{
    public Text textScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        textScore.text = Score.points.ToString();
    }
}
