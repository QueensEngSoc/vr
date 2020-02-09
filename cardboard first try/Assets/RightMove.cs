using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RightMove : MonoBehaviour
{
    public GameObject player;

    public void Right()
    { 
        player.transform.position += new Vector3(1, 0, 0);
    }
}
