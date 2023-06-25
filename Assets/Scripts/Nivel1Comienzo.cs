using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel1Comienzo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Score.escenaActual == 6)
        {
            Score.escenaActual = -1;
        }

        if (collision.tag == "Player")
        {
            Score.escenaActual++;
            Score.globalPoints = 0;
            Score.points = 0;
            Score.correcto = false;
            SceneManager.LoadScene(Score.escenaActual);
        }
    }
}
