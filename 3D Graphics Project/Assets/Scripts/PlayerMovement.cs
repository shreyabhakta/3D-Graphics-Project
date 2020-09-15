using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float jumpSpeed = 7f;
    public bool isLeftTurn = false;
    public GameObject player;
    public bool isGrounded = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            //FIXME: Play Animation while running
            player.GetComponent<Animator>().Play("NormalAttack01_SwordShield");         
        }
        else if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //Space Bar
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(0f, jumpSpeed), ForceMode.Impulse);
            isGrounded = false;        
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            //Right Arrow
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

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Ground")
		{
			isGrounded = true;
		}
	}
}
