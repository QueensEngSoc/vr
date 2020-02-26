using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=XDAYS-qYe6Y

public class Balls : MonoBehaviour
{
    public float forceMult = 20;
    private Rigidbody rigidbody;
    int[] positions = new int[] { -1, 1, 3 };

    public GameObject ball;
    private const int ballCount = 2;
    public GameObject[] ballArr = new GameObject[ballCount];
    public static int currBall = 0;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * - forceMult;

        if (currBall == 0)
        {
            generateNewBall();
        }

        print("STARTING!");
    }

    private void OnEnable()
    {
        //generateNewBall();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = transform.forward * - forceMult;
        if (transform.position.z < -5)
        {
            Respawn();
        } else if (transform.position.z < 5) {
            //generateNewBall();
        }

    }

    private void generateNewBall()
    {
        int index = UnityEngine.Random.Range(0, 2);
        int randomX = positions[index];
        //ballArr[currBall % ballCount] = ball;
        print(currBall % ballCount + " -> " + currBall);

        ballArr[currBall % ballCount] = Instantiate(ball, new Vector3(randomX, 1, 30), Quaternion.identity);
        currBall++;
    }

    private void Respawn()
    {
        //int index = UnityEngine.Random.Range(0, 2);
        //int randomX = positions[index];

        var oldBall = ballArr[(currBall + 1) % ballCount];
        currBall++;
        generateNewBall();
        Destroy(oldBall);

        //transform.position = new Vector3(randomX, 1, 20);
        //Destroy(this);
        //Instantiate(ball, new Vector3(randomX, 1, 20), Quaternion.identity);
    }
}
