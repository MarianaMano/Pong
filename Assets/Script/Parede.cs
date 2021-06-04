using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parede : MonoBehaviour
{
    public enum WallName { Left, Right } 
    
    [SerializeField]
    ScoreKeeper marcador;

    [SerializeField]
    WallName lado = WallName.Left ; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /* quando a bola bater, avisamos o ScoreKeeper
        * para aumentar a ppontuação
        */

        marcador.Goal(lado);

    }
}
