using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LeftMove : MonoBehaviour
{
    public GameObject player;

    public void Left()
    {
        player.transform.position += new Vector3(-1, 0, 0);
    }
}
