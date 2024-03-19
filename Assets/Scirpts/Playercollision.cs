using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public Gamemanager gamemanager;
    public myScore  myScore;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fish"))
        {
            myScore = other.GetComponent<myScore>();
            gamemanager.score += myScore.myscore;
            gamemanager.increasescore();
            Destroy(other.gameObject);
        }



        if (other.CompareTag("Dog"))
        {
            gamemanager.isgamegoing = false;
        }



        if (other.CompareTag("finish"))
        {
            gamemanager.isfinished = true;
        }
    }
}
