using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloqueVerde : MonoBehaviour
{
    private GameController gameController;
    private controlPuntuacion controlPuntuacion;
    public float dureza = 3;
    public int score = 25;
    //Variables sonido
    public AudioClip choque;
    public float volume = 10;

    private void Awake()
    {
        controlPuntuacion = GameObject.FindObjectOfType<controlPuntuacion>();
        gameController= GameObject.FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        AudioSource.PlayClipAtPoint(choque, transform.position, volume);

        dureza = dureza - 1;
        if (dureza <= 0)
        {
            Destroy(gameObject);
            
        }

    }
    public void OnDestroy()
    {
        controlPuntuacion.actualizarPuntos(score);
        gameController.comprobarVictoria();
    }




}
