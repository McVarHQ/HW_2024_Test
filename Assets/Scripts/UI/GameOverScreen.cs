using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public GameObject currScore;

    public void Setup(int score)
    {
        currScore.SetActive(false);
        gameObject.SetActive(true);
        scoreText.text = score.ToString() + " Pulpits Invaded";
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

}
