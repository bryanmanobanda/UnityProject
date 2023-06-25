using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VentanaPrincipal : MonoBehaviour
{
    public Text InstructionText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Score.correcto)
            {
                Score.correcto = false;
                SceneManager.LoadScene(2);
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
