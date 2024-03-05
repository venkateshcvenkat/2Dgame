using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;
public class uimanager : MonoBehaviour
{
    public Image lifeimage;
    public Sprite[] lifesprite;
    private int life = 3;
    public static uimanager instance;
    public TextMeshProUGUI scoretext;
    private int score;
    public GameObject endpanel;

    //highscore

    int highscore = 0;
    public TextMeshProUGUI highscoretext;
   
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void updatelife()
    {
        life--;
        lifeimage.sprite = lifesprite[life];
        if (life == 0)
        {
            soundeffect.instance.over();
            soundeffect.instance.stopmusic();
            endpanel.SetActive(true);
            setHighscore();
            Time.timeScale = 0f;
        }
    }

    void setHighscore()
    {
        if ((int)score>highscore)
        {
            PlayerPrefs.SetInt("Highscore",(int)score);
            highscoretext.text = "Highscore "+(int)score;
        }
        else
        {
            highscoretext.text = "Highscore: " + highscore;
        }
    }
    public void updatescore()
    {
        score++;
        scoretext.text = "" + score;
    }
    public void retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void quit()
    {
        SceneManager.LoadScene(0);
    }

   
}
