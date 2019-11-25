﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//https://www.youtube.com/watch?v=XDAYS-qYe6Y

public class CubeMover : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;
    private float MINIMUM_HORIZONTAL = 0;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical);

        transform.position += movement * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(0);
    }
}
