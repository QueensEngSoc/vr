using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    private int score = 0;
    private GameObject scoreGameObject = null;
    private ScoreText scoreText;
    private GameScript scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        scoreGameObject = GameObject.Find("ScoreText");
        //Get script from it
        scoreScript = scoreGameObject.GetComponent<GameScript>();
        print("STarting game!");
        scoreGameObject.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void updateScore(int diff = 1)
    {
        score += diff;
        scoreGameObject.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
    }

    int getScore()
    {
        return score;
    }

}
