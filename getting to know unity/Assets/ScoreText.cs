using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    public Text scoreVal;
    private GameObject scoreGameObject = null;

    // Start is called before the first frame update
    void Start()
    {
        scoreGameObject = (GameObject)GameObject.FindWithTag("ScoreText");
        scoreVal = scoreGameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateScore(int score)
    {
        scoreVal.text = "Score: " + score.ToString();
        print("Score: " + score);
    }
}
