using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    public static bool playerAlive = true;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreValue + " / 15";

        if (playerAlive == false)
        {
            score.text = "YOU DIED!!!";
            score.transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 1);
        }

        if(scoreValue == 15)
        {
            score.text = "YOU DESTROYED ALL PLANETS! WINNER!!!";
            score.transform.position = new Vector3 (Screen.width / 2, Screen.height / 2 , 1);
        }
    }
}
