using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    
    bool bolafoilancada = false;
    
    float tempoDecorrido = 0f;

    [SerializeField]
    float tempoEspera = 2f;



    // Start is called before the first frame update
    void Start()
    {
        /*
         if(Random.value < 0.5f)
         {
             GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
         }
         else
         {
             GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.left;
         }
         */

        // esperar 2 segundos //

        System.Threading.Thread.Sleep(2000);

        GetComponent<Rigidbody2D>().velocity = velocidade * Random.onUnitSphere;

    }

    // Update is called once per frame
    void Update()
    {
        /* if (bolafoilancada == false)
       {
           tempoDecorrido = tempoDecorrido + Time.deltaTime; // tempoDecorrido += Time.deltaTime; //

           if(tempoDecorrido >= tempoEspera)
           {
               GetComponent<Rigidbody2D>().velocity = velocidade * Random.onUnitSphere;
               bolafoilancada = true;
           }
       }
      */
    }
}
