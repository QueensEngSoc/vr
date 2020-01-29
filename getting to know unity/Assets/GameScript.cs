using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    private int score = 0;
    private GameObject scoreGameObject = null;
    private GameObject livesGameObject = null;
    private GameObject uiCanvas = null;

    private GameScript scoreScript;
    private int lives = 3;
    private List<GameObject> liveImages = new List<GameObject>();
    private Sprite heartImage = null;

    // Start is called before the first frame update
    void Start()
    {
        scoreGameObject = GameObject.Find("ScoreText");
        livesGameObject = GameObject.Find("HeartImage");
        uiCanvas = GameObject.Find("Canvas");

        heartImage = Resources.Load<Sprite>("Sprites/heart");

        //Get script from it
        scoreScript = scoreGameObject.GetComponent<GameScript>();
        print("STarting game!");
        scoreGameObject.GetComponent<Text>().text = "Score: " + score.ToString();
        initializeLivesUI();
    }

    void initializeLivesUI()
    {
        for (int i = 0; i < lives; i++)
        {
            GameObject go = new GameObject("gameobject");
            RectTransform rectTransform = go.AddComponent<RectTransform>();
            rectTransform.SetParent(uiCanvas.transform);
            rectTransform.anchorMin = new Vector2(1, 1);
            rectTransform.anchorMax = new Vector2(1, 1);
            rectTransform.pivot = new Vector2(0.5f, 0.5f);
            rectTransform.localScale = new Vector2(0.25f, 0.25f);
            //rectTransform.sizeDelta = new Vector2(heartImage.bounds.size.x * 100, heartImage.bounds.size.y * 100);

            Image image = go.gameObject.AddComponent<Image>();
            image.sprite = heartImage;
            image.overrideSprite = heartImage;

            liveImages.Add(go);

            Debug.Log("width " + rectTransform.rect.width + "height " + rectTransform.rect.height);

            go.transform.SetParent(rectTransform, false);
            go.GetComponent<RectTransform>().anchoredPosition = new Vector3(30 * -i - 25, -25, 0);

        }

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void updateScore(int diff = 1)
    {
        score += diff;
        scoreGameObject.GetComponent<Text>().text = "Score: " + score.ToString();
    }

    int getScore()
    {
        return score;
    }

    public void loseALife()
    {
        lives--;

        if (lives <= 0)
        {
            SceneManager.LoadScene(0);
            return;
        }


        GameObject imageToRemove = liveImages[liveImages.Count - 1];
        Destroy(imageToRemove);
        liveImages.RemoveAt(liveImages.Count - 1);
    }

}
