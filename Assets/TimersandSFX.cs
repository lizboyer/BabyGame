using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimersandSFX : MonoBehaviour
{


    //Win Screen

    [SerializeField] GameObject winPopUpScreen;

    public void WinPopUp()
    {
        winPopUpScreen.SetActive(true);
        Time.timeScale = 0f;
    }


    // Lose Screen

    [SerializeField] GameObject LoseScreen;

    public void Lose()
    {
        LoseScreen.SetActive(true);
        Time.timeScale = 0f;

    }

    /*

    // Rocking Chair

    private void OnMouseDown()
    {
        if (GetComponent<TimersandSFX>().ailment == 1)
        {
            GetComponent<TimersandSFX>().StopCrying();
            GetComponent<TimersandSFX>().cryTimer = 0;
            GetComponent<TimersandSFX>().cooldown = 20;
        }
    }

    // Feeding Chair

    private void OnMouseDown()
    {
        if (GetComponent<TimersandSFX>().ailment == 2)
        {
            GetComponent<TimersandSFX>().StopCrying();
            GetComponent<TimersandSFX>().cryTimer = 0;
            GetComponent<TimersandSFX>().cooldown = 20;
        }
    }

    // Changing Table

    private void OnMouseDown()
    {
        if (GetComponent<TimersandSFX>().ailment == 3)
        {
            GetComponent<TimersandSFX>().StopCrying();
            GetComponent<TimersandSFX>().cryTimer = 0;
            GetComponent<TimersandSFX>().cooldown = 20;
        }
    }

    // Books

    private void OnMouseDown()
    {
        GetComponent<TimersandSFX>().StopCrying();
        GetComponent<TimersandSFX>().cryTimer = 0;
        GetComponent<TimersandSFX>().cooldown = 20;
    }

    */

    //SFX

    public AudioSource Cry1;
    public AudioSource Cry2;
    public AudioSource Cry3;
    public AudioSource Win;

    public void PlayCrying1()
    {
        Cry1.Play();
    }
    public void PlayCrying2()
    {
        Cry2.Play();
    }
    public void PlayCrying3()
    {
        Cry3.Play();
    }

    public void PlayWin()
    {
        Win.Play();
    }

    public void StopCrying()
    {
        Cry1.Stop();
        Cry2.Stop();
        Cry3.Stop();
        Win.Stop();

    }




    // Timers




   // SFX sfx;

    public float winTimer = 100;
    private bool winTimerRunning = false;

    public float cooldown = 20;
    private bool cooldownRunning = false;

    public float cryTimer = 30;

    private bool pausecooldown = false;

    //private bool cryTimerRunning = false;
    //private bool cryTimerLose = false;

    public int ailment;

    private void Start()
    {
       // sfx = GameObject.FindGameObjectWithTag("TagSFX").GetComponent<SFX>();

        Debug.Log("Starting (Timers)");
        StopCrying();
        winTimerRunning = true;
        cooldownRunning = true;



        //cryTimerRunning = false; //new
    }


    void Update()
    {

       /* if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("F Pressed");
        }

        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("R Pressed");
        }
        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log("C Pressed");
        } */



        if (winTimer > 0)
        {
            winTimer -= Time.deltaTime;
        }
        else
        {
            winTimer = 0;
            winTimerRunning = false;
        }

        if (cryTimer > 0)
        {
            cryTimer -= Time.deltaTime;
        }
        else
        {
            cryTimer = 0;
            //cryTimerRunning = false;
            //new
        }

        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
        else
        {
            cooldown = 0;
            cooldownRunning = false;
        }


        // baby starts crying
        /*
        if (ailment == 1 && Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R Pressed");

            pausecooldown = false;
            cooldownRunning = true;
            cryTimer = 30;
        }

        if (ailment == 2 && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F Pressed");

            pausecooldown = false;
            cooldownRunning = true;
            cryTimer = 30;
        }
        if (ailment == 1 && Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("C Pressed");

            pausecooldown = false;
            cooldownRunning = true;
            cryTimer = 30;
        }
        */

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R Pressed");
            if (ailment == 1)
            {
                pausecooldown = false;
                cooldownRunning = true;
                cryTimer = 50;
                cooldown = 20;
                StopCrying();
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F Pressed");
            if (ailment == 2)
            {
                pausecooldown = false;
                cooldownRunning = true;
                cryTimer = 50;
                cooldown = 20;
                StopCrying();
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("C Pressed");
            if (ailment == 3)
            {
                pausecooldown = false;
                cooldownRunning = true;
                cryTimer = 50;
                cooldown = 20;
                StopCrying();
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (ailment == 1 || ailment == 2 || ailment == 3)
            {
                pausecooldown = false;
                cooldownRunning = true;
                cryTimer = 50;
                cooldown = 20;
                StopCrying();

            }


        }

        if (cooldownRunning == false)
            if (pausecooldown == false)
            {
                { //new
                    Debug.Log("Cooldown is false, waking baby");
                    pausecooldown = true;
                    ailment = Random.Range(1, 4);
                    Debug.Log(ailment);
                    if (ailment == 1)
                    {
                        //sfx.PlayCrying1();
                        PlayCrying1();

                        Debug.Log("Ailment 1");
                        if (Input.GetKey(KeyCode.R))
                        {
                            Debug.Log("R Pressed");

                            pausecooldown = false;
                            cooldownRunning = true;
                            cryTimer = 30;
                        }
                    }
                    if (ailment == 2)
                    {
                        //sfx.PlayCrying2();
                        PlayCrying2();

                        Debug.Log("Ailment 2");
                        if (Input.GetKey(KeyCode.F))
                        {
                            Debug.Log("F Pressed");
                            pausecooldown = false;
                            cooldownRunning = true;
                            cryTimer = 30;
                        }

                    }
                    if (ailment == 3)
                    {
                        //sfx.PlayCrying3();
                        PlayCrying3();

                        Debug.Log("Ailment 3");
                        if (Input.GetKey(KeyCode.C))
                        {
                            Debug.Log("C Pressed");

                            pausecooldown = false;
                            cooldownRunning = true;
                            cryTimer = 30;
                        }
                    }



                    Debug.Log("Starting Crying");
                    cryTimer = 30;
                }
            }

        //complete objective

        
/*
       if(ailment )
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 1000, _navAgent.areaMask))
            {
                _navAgent.setDestination(hit.point);
            }
        }
*/
        // win lose screens

        if (winTimerRunning == false)
        {
            pausecooldown = true;
            StopCrying();
            WinPopUp();
            Debug.Log("Show Win");


        }

        if (cryTimer == 0)
        {
            pausecooldown = true;
            StopCrying();
            Debug.Log("Show Lose");
            Lose();
        }

    }


}
