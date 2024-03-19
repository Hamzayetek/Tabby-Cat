using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    public float playerSpeed;
    public float verticalSpeed;

    private void Update()
    {
        transform.position += new Vector3(0, 0, playerSpeed * Time.deltaTime); 
        float clampedXposition = Mathf.Clamp(playerTransform.position.x, -5, 5);
        transform.position = new Vector3(clampedXposition, playerTransform.position.y, playerTransform.position.z);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3( -verticalSpeed * Time.fixedDeltaTime, 0 , 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3( verticalSpeed * Time.fixedDeltaTime, 0, 0);
        }       
    }

}
