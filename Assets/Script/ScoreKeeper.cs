using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    int leftScore = 0;
    int rightScore = 0;

    [SerializeField]
    TextMeshProUGUI leftScoreTxt;

    [SerializeField]
    TextMeshProUGUI rightScoreTxt;

    public void Goal(Parede.WallName collision)
    {
       if(collision == Parede.WallName.Right)
        {
            leftScore += 1;
        }
       else if (collision == Parede.WallName.Left)
        {
            rightScore += 1;
        }

        leftScoreTxt.text = leftScore.ToString();
        rightScoreTxt.text = rightScore.ToString();

        Debug.Log(leftScore + " " + rightScore);
    }
}
