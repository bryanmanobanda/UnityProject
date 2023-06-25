using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public Text InstructionText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            if(Score.correcto || Score.escenaActual == 3 || Score.escenaActual == 5)
            {
                Score.escenaActual++;
                Score.correcto = false;
                Score.globalPoints += Score.points;
                Score.points = 0;
                SceneManager.LoadScene(Score.escenaActual);
            }
            else
            {
                InstructionText.text = "Escoge la respuesta correcta";
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        InstructionText.text = "";
    }
}
