using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//https://www.youtube.com/watch?v=XDAYS-qYe6Y

public class CubeMover : MonoBehaviour
{
    public GameScript script;
    private GameObject gameCanvas = null;
    private GameScript gameScript = null;

    private void Start()
    {
        // initialize a GameScript instance;    
        script = GetComponent<GameScript>();
        gameCanvas = GameObject.Find("Canvas");
        //Get script from it
        gameScript = gameCanvas.GetComponent<GameScript>();
    }

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
        //SceneManager.LoadScene(0);
        gameScript.loseALife();
    }
}
