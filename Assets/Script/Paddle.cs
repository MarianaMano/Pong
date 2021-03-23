using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    // mudança de veriável no jogo //
    [SerializeField]
    float velocidade = 0.5f;

    [SerializeField]
    float paddleHeight = 1f;

    [SerializeField]
    KeyCode UpKey = KeyCode.UpArrow;
    
    [SerializeField]
    KeyCode DownKey = KeyCode.DownArrow;


    /*
     *  para distinguir entre "double" e "float" é com "f" no fim
     *  usar "double" é raro
     *  não multiplicar nrs GRANDES por nrs PEQUENOS
     */

    // Update is called once per frame
    void Update()
    {

        /*
         * se tecla para cima
         * então subir
         * senão se tecla para baixo
         * então descer
         */

        if (Input.GetKey(UpKey))
        {
            //sobe
            transform.position += velocidade * Vector3.up * Time.deltaTime;

            /* a += 3;
             * a = a + 3
             */

        }
        else if (Input.GetKey(DownKey))
        {
            //desce
            transform.position += velocidade * Vector3.down * Time.deltaTime;

            // velocidade é "float" por isso tenho de add vector 3
        }

        /* verificar os limites (com ifs) 

        float cameraHeight = Camera.main.orthographicSize;
        
        if (transform.position.y >= cameraHeight - 0.5f)
        {
            // variável auxiliar // 
             
            Vector3 positionAux = transform.position;
            positionAux.y = cameraHeight - 0.5f;
            transform.position = positionAux;

            // regra do unity - não posso alterar diretamente o y no transform.position  //
        }

        if (transform.position.y <= -cameraHeight + 0.5f)
        {

            Vector3 positionAux = transform.position;
            positionAux.y = -cameraHeight + 0.5f;
            transform.position = positionAux;
*
        }
        */

        // verificar os limites (Clamp)

        float cameraHeight = Camera.main.orthographicSize;
        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp(positionAux.y, 
            -cameraHeight + (paddleHeight * 0.5f), 
            cameraHeight - (paddleHeight * 0.5f));
        transform.position = positionAux;

        // evitar fazer divisões //
    }
}