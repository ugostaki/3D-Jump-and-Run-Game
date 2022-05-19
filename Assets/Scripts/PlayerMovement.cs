using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private bool isOnGround=true;
    public float jumpforce;
    public float playerSpeed;
    public float gravityModify;
    public GameObject background;
    public float backgroundSpeed;
    public bool isGameOver;
    private Vector3 startPos;
    void Start()
    {
        startPos = background.transform.position;
        rb =transform.GetComponent<Rigidbody>();
        Physics.gravity *= gravityModify;
    }

    
    void Update()
    {
        if(background.transform.position.x < startPos.x - 100)
        {
            background.transform.position = startPos;
        }
        if (isGameOver == false)
        { 
            background.transform.Translate(Vector3.left * backgroundSpeed);
        }
        if (Input.GetKeyDown(KeyCode.Space)&&isOnGround==true)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isOnGround = false;
            transform.GetComponent<Animator>().SetBool("Jump", true);

        }
      

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ground")
        {
            isOnGround = true;
            transform.GetComponent<Animator>().SetBool("Jump", false);

        }
        if (collision.transform.tag == "Obstacles")
        {
            isGameOver = true;
            Debug.Log("GameOver");
        }
    }
}
