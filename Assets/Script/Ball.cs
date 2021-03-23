using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    bool bolafoilancada = false;
    float tempo = 0f;



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

        GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;
          
   

       /* if (bolafoilancada == false)
        {
            tempo = tempo + Time.deltaTime;

            if(tempo >= 2)
            {
                GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;
                bolafoilancada = true;
            }
        }
       */
        


    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
