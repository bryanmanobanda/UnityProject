using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour
{
    public Text winLabel;
    public AudioSource correctSound;
    public AudioSource dropSound;
    public AudioSource hitSound;
    public bool invencible;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Drop")
        {
            Score.points = Score.points + 10;
            dropSound.time = 9;
            dropSound.Play();
        }

        if (collision.tag == "Correct")
        {
            winLabel.text = "Correcto";
            Score.points = Score.points + 50;
            Score.correcto = true;
            hitSound.time = 9;
            hitSound.Play();
            correctSound.time = 9;
            correctSound.Play();
        }

        if (collision.tag == "Incorrect")
        {
            winLabel.text = "Incorrecto";
            Score.points = Score.points - 10;
            hitSound.time = 9;
            hitSound.Play();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Vida" && Score.points > 0)
        {
            if (!invencible && Score.points> 0)
            {
                Score.points = Score.points - 5;
                hitSound.time = 9;
                hitSound.Play();
                StartCoroutine(Invulneravilidad());
            }
        }
    }

    IEnumerator Invulneravilidad()
    {
        invencible = true;
        yield return new WaitForSeconds(1);
        invencible = false;
    }

    private void FixedUpdate()
    {
        Debug.Log(correctSound.time);
        if(correctSound.time > 1) 
        {
            correctSound.Stop();
        }

        Debug.Log(dropSound.time);
        if (dropSound.time > 1)
        {
            dropSound.Stop();
        }

        Debug.Log(hitSound.time);
        if (hitSound.time > 1)
        {
            hitSound.Stop();
        }
    }
}
