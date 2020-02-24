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
    
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * - forceMult;
    }

    private void OnEnable()
    {
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = transform.forward * - forceMult;
        if (transform.position.z < -5)
        {
            Respawn();
        }

    }

    private void Respawn()
    {
        int index = UnityEngine.Random.Range(0, 2);
        int randomX = positions[index];
        

        transform.position = new Vector3(randomX, 1, 10);
    }
}
