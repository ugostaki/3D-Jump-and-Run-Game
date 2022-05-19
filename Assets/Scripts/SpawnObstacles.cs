using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    Vector3 pos = new Vector3(25, 0, -9);
    PlayerMovement playerMovement;
    
    void Start()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        InvokeRepeating("Obstacles", 2, 2);
    }

   
    void Update()
    {
        
    }
    
    public void Obstacles()
    {
        if (!playerMovement.isGameOver)
        { 
        Instantiate(obstacle, pos, transform.rotation);
        }
    }
}
