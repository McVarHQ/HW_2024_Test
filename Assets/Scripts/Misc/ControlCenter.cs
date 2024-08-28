using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCenter : MonoBehaviour
{

    public Transform player;
    public GameOverScreen gameOverScreen;
    public int score;
    
    void Start()
    {
        score = -1;
    }

    
    void Update()
    {
        if (player.GetComponent<NoPulpitDetection>().isOut)
        {
            gameOverScreen.Setup(score);
        }
    }
}
