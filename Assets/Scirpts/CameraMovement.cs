using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform playertrasnform;
    [SerializeField] private Vector3 difference;


    private void Update()
    {
        transform.position = new Vector3 (transform.position.x,playertrasnform.position.y - difference.y , playertrasnform.position.z - difference.z);
    }
}
