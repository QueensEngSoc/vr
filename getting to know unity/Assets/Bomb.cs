using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=XDAYS-qYe6Y

public class Bomb : MonoBehaviour
{
    private void OnEnable()
    {
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
            Respawn();

    }

    private void Respawn()
    {
        float randomX = UnityEngine.Random.Range(-15, 15);
        float randomY = UnityEngine.Random.Range(10, 20);

        transform.position = new Vector3(randomX, randomY);

        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
    }
}
