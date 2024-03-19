using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] public TMP_Text scoreText2;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject scoreScreen;
    [SerializeField] private GameObject loseScreen;
    [SerializeField] private TMP_Text finishScoreText;
    [SerializeField] private GameObject finishScoreScreen;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject resetbutton;
    [SerializeField] private GameObject background;
    [SerializeField] private Animator animator;

    public int randomScore;
    public int score;
    public bool isgamegoing = true;
    public bool isfinished = false;
    public playerMovement playerMovement;
    public playerRaycast playerRaycast;
    public Swipe swipe;
    public myScore[] myScore;

    public void increasescore()
    {        
        scoreText.SetText("Score :" + score);
    }

    public void resetThegame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        if (isgamegoing == false)
        {
            playerMovement.playerSpeed = 0;
            playerMovement.verticalSpeed = 0;
            swipe.playerSpeed = 0;
            swipe.gamespeed = 0;
            scoreScreen.SetActive(false);
            loseScreen.SetActive(true);
            finishScoreScreen.SetActive(true);
            finishScoreText.SetText("Score :" + score);
            resetbutton.SetActive(true);
            background.SetActive(true);
            animator.speed = 0;
        }


        if (isfinished)
        {
            playerMovement.playerSpeed = 0;
            playerMovement.verticalSpeed = 0;
            swipe.playerSpeed = 0;
            swipe.gamespeed = 0;
            scoreScreen.SetActive(false);
            finishScoreScreen.SetActive(true);
            winScreen.SetActive(true);
            finishScoreText.SetText("Score :" + score);
            resetbutton.SetActive(true);
            background.SetActive(true);
            animator.speed = 0;
        }
    }
    
}
