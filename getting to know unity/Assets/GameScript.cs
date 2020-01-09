using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    private int score = 0;
    public Text scoreVal;
    private GameObject scoreGameObject = null;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreGameObject = (GameObject)GameObject.FindWithTag("ScoreVal");
        scoreVal = scoreGameObject.GetComponent<Text>();
        print("STarting game!");
    }

    // Update is called once per frame
    void Update()
    {
        scoreVal.text = score.ToString();
        print("Score: " + score);
    }
    public void updateScore(int diff = 1)
    {
        score += diff;
    }

    int getScore()
    {
        return score;
    }

}
