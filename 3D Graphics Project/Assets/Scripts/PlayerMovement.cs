using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float jumpSpeed = 7f;
    public bool isLeftTurn = false;
    public GameObject player;
<<<<<<< HEAD
    public bool isGrounded = true;
=======
>>>>>>> anh_main

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            //FIXME: Play Animation while running
<<<<<<< HEAD
            player.GetComponent<Animator>().Play("NormalAttack01_SwordShield");         
        }
        else if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //Space Bar
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(0f, jumpSpeed), ForceMode.Impulse);
            isGrounded = false;        
=======
            player.GetComponent<Animator>().Play("NormalAttack01_SwordShield");
            Debug.Log("ATTACK");
         
        }
        else if (Input.GetButtonDown("Jump"))
        {
            //Space Bar
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(0f, jumpSpeed), ForceMode.Impulse);
>>>>>>> anh_main
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            //Right Arrow
<<<<<<< HEAD
=======
            Debug.Log("POSITIVE");
>>>>>>> anh_main
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
<<<<<<< HEAD
=======
            Debug.Log("NEGATIVE");
>>>>>>> anh_main
            if (isLeftTurn == false)
            {
                transform.Rotate(0, 180, 0);
                isLeftTurn = true;
            }
            player.GetComponent<Animator>().Play("Run_SwordShield");
        }

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
<<<<<<< HEAD

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Ground")
		{
			isGrounded = true;
		}
	}
=======
>>>>>>> anh_main
}
