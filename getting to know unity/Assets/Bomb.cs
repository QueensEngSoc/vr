using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=XDAYS-qYe6Y

public class Bomb : MonoBehaviour
{
    private GameScript script;
    private GameObject scoreGameObject = null;
    private ScoreText scoreText;
    private GameScript scoreScript;

    private void Start()
    {
        print("Starting Bomb routine");
        script = GetComponent<GameScript>();
        scoreGameObject = GameObject.Find("Canvas");
        //Get script from it
        scoreScript = scoreGameObject.GetComponent<GameScript>();
    }
    private void OnEnable()
    {
        print("enabling bomb");
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5) {
            Respawn();
            //script.updateScore();
            scoreScript.updateScore(1);
        }

    }

    private void Respawn()
    {
        float randomX = UnityEngine.Random.Range(-15, 15);
        float randomY = UnityEngine.Random.Range(10, 25);

        transform.position = new Vector3(randomX, randomY);

        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
    }
}
