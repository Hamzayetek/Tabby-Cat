using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class myScore : MonoBehaviour
{
    [SerializeField] private TMP_Text myText;
    [SerializeField] private GameObject cylinder1;
    [SerializeField] private GameObject cylinder2;
    public Gamemanager gamemanager;
    public GameObject gameManager;   
    public int myscore;
    private Renderer Renderer1;
    private Renderer Renderer2;

    private void Start()
    {
        Canvas canvas = gameObject.GetComponentInChildren<Canvas>();
        myText = canvas.GetComponentInChildren<TMP_Text>();
        gameManager = FindObjectOfType<Gamemanager>().gameObject;        
        gamemanager = gameManager.GetComponent<Gamemanager>();
        Renderer1 = cylinder1.GetComponentInChildren<Renderer>();
        Renderer2 = cylinder2.GetComponentInChildren<Renderer>();

        myscore = Random.Range(-5,5);
        myText.SetText(myscore.ToString());
    }
    private void Update()
    {
        if(myscore < 0)
        {
            myText.SetText(myscore.ToString());
            Renderer1.material.color = Color.red;
            Renderer2.material.color = Color.red;            
        }
        else if(myscore > 0)
        {
            myText.SetText(myscore.ToString());
            Renderer1.material.color = Color.green;
            Renderer2.material.color = Color.green;
        }
        else if (myscore == 0)
        {
            myscore = 1;
        }
    }
}
