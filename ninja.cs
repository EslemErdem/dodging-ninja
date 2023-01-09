using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ninja : MonoBehaviour
{
    public Animator anim;

    private CharacterController controller;
    private Vector3 playerVelocity;

    private float playerSpeed = 2.0f;
    private bool groundedPlayer;
    private float gravityValue = -8f;
    private float jumpHeight = 5.0f;

    Rigidbody rb;
    public float can = 100.0f;
    public static float su_an_can = 100.0f;
    public Image can_bari;
    public GameObject restart_button;
    public GameObject panel;
    float x, y;



    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();

    }


    void Update()
    {




        //RUN
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetInteger("kos", 1);


            Vector3 move = new Vector3(1, 0, 0);//right move for chacracter

            controller.Move(move * Time.deltaTime * playerSpeed);
            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
            }

            if (Input.GetKeyDown(KeyCode.Space) && !groundedPlayer)
            {

                playerVelocity.y = jumpHeight * 1.2f;

                anim.SetInteger("kos_zipla", 1);
                groundedPlayer = true;


            }


            else
            {

                anim.SetInteger("kos_zipla", 0);

                playerVelocity.y += gravityValue * Time.deltaTime; //drop down
                controller.Move(playerVelocity * Time.deltaTime);


            }


        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetInteger("kos", 1);


            Vector3 move = new Vector3(-1, 0, 0); // left move for character
            controller.Move(move * Time.deltaTime * playerSpeed);
            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
            }
            if (Input.GetKeyDown(KeyCode.Space) && !groundedPlayer)
            {

                playerVelocity.y = jumpHeight * 1.2f;

                anim.SetInteger("kos_zipla", 1);
                groundedPlayer = true;


            }


            else
            {

                anim.SetInteger("kos_zipla", 0);

                playerVelocity.y += gravityValue * Time.deltaTime; //drop down
                controller.Move(playerVelocity * Time.deltaTime);


            }

        }

        else
        {
            anim.SetInteger("kos", 0);
        }
        //JUMP




        if (Input.GetKeyDown(KeyCode.Space) && !groundedPlayer)
        {

            playerVelocity.y = jumpHeight * 1.2f;
            anim.SetInteger("zipla", 1);
            groundedPlayer = true;


        }
        else
        {

            anim.SetInteger("zipla", 0);

            playerVelocity.y += gravityValue * Time.deltaTime; //drop down
            controller.Move(playerVelocity * Time.deltaTime);



        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("yer"))
        {
            groundedPlayer = false;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "kure")
        {
            su_an_can -= 10.0f;
            can_bari.fillAmount = su_an_can / can;
            Debug.Log(su_an_can);
            if (su_an_can == 0)
            {

                Debug.Log("bitti");
                panel.SetActive(true);
                restart_button.SetActive(true);
                
                su_an_can = 100.0f;
            }
        }
    }
}

