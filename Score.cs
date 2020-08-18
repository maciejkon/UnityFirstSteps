using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    private float playerPossition=0;
    public Text scoreText;
    public Text gameOverText;
    
    void Update()
    {
        gameOverText.enabled = false;
        playerPossition = -player.position.x;
        scoreText.text = playerPossition.ToString("0")+"m";

        if (FindObjectOfType<GameManager>().gameHasEnded == true)
        {
            gameOverText.enabled = true;
        }
    }


}
