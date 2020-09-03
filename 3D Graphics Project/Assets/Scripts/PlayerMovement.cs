using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float jumpSpeed = 7f;
    public bool isLeftTurn = false;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown(/*INSERT KEY NAME*/))
        //{
        //    player.GetComponent<Animator>().Play(/*INSERT ANIMATION NAME*/);
        //}
        if (Input.GetButtonDown("Fire1"))
        {
            player.GetComponent<Animator>().Play("NormalAttack01_SwordShield");
            Debug.Log("ATTACK");
        }
        else if (Input.GetButtonDown("Jump"))
        {
            //Space Bar
            Jump();
            //player.GetComponent<Animator>().Play("Die_SwordShield");
            //gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(0f, jumpSpeed), ForceMode.Impulse);
        }        
        else if (Input.GetAxis("Horizontal") > 0)
        {
            //Right Arrow
            Debug.Log("POSITIVE");
            if (isLeftTurn)
            {
                transform.Rotate(0, 180, 0);
                isLeftTurn = false;
            }
            player.GetComponent<Animator>().Play("Run_SwordShield");

        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            //Left Arrow
            Debug.Log("NEGATIVE");
            if (isLeftTurn == false)
            {
                transform.Rotate(0, 180, 0);
                isLeftTurn = true;
            }
            player.GetComponent<Animator>().Play("Run_SwordShield");
        }
        else
        {
            //Idle, no input
            player.GetComponent<Animator>().Play("Idle_SwordShield");
        }
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
    
    void Jump()
    {
        //Space Bar
        player.GetComponent<Animator>().Play("Die_SwordShield");
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(0f, jumpSpeed), ForceMode.Impulse);
    }
}
