using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMove : MonoBehaviour
{
    PlayerMovement playerMovement;
    public float ObstaclesSpeed;
    
    void Start()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    
    void Update()
    {
        if (!playerMovement.isGameOver)
        {
            transform.Translate(Vector3.left * ObstaclesSpeed * Time.deltaTime);
        }
       
    }
}
