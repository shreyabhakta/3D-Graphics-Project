using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float jumpSpeed = 7f;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetButtonDown(/*INSERT KEY NAME*/))
        //{
        //    player.GetComponent<Animator>().Play(/*INSERT ANIMATION NAME*/);
        //}
        //if (Input.GetButtonDown(/*INSERT KEY NAME*/))
        //{
        //    player.GetComponent<Animator>().Play(/*INSERT ANIMATION NAME*/);
        //}
        //if (Input.GetButtonDown(/*INSERT KEY NAME*/))
        //{
        //    player.GetComponent<Animator>().Play(/*INSERT ANIMATION NAME*/);
        //}
        //if (Input.GetButtonDown(/*INSERT KEY NAME*/))
        //{
        //    player.GetComponent<Animator>().Play(/*INSERT ANIMATION NAME*/);
        //}
        if (Input.GetButtonDown("Jump"))
        {
            player.GetComponent<Animator>().Play("Die_SwordShield");
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(0f, jumpSpeed), ForceMode.Impulse);
        }
        //Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    //void Jump()
    //{
    //    if (Input.GetButtonDown("Jump"))
    //    {
    //        gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(0f, jumpSpeed), ForceMode.Impulse);
    //    }
    //}
}
