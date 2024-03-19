using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private Vector2 startpos;
    private Vector2 endpos;
    [SerializeField] private float swipeSpeed;
    public float playerSpeed;
    public float gamespeed = 1;

    private void Update()
    {
        transform.position += new Vector3(0, 0, playerSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            startpos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            endpos = Input.mousePosition;

            if(endpos.x < startpos.x)
            {
                left();
            }
            if (endpos.x > startpos.x)
            {
                right();
            }
        }       
    }


    public void right()
    {
        Vector3 baslangýçnoktasý = transform.position;
        Vector3 bitisnoktasý = new Vector3(Mathf.Clamp(transform.position.x + swipeSpeed,-5,5), transform.position.y, transform.position.z) * gamespeed;
        transform.position = Vector3.Lerp(baslangýçnoktasý, bitisnoktasý, 0.5f);
        
    } 

    public void left()
    {
        Vector3 baslangýçnoktasý = transform.position;
        Vector3 bitisnoktasý = new Vector3(Mathf.Clamp (transform.position.x - swipeSpeed,-5,5), transform.position.y, transform.position.z) * gamespeed;
        transform.position = Vector3.Lerp(baslangýçnoktasý, bitisnoktasý, 0.5f);
        
    }
}
