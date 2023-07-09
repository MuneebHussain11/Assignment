using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameStarted = false;
    private float rotationSpeed = 100f;
    private float scaleSpeed = 0.5f;
    private Vector3 initialScale = new Vector3(1, 1, 1);

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
  
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (!isGameStarted)
            {
                StartGame();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isGameStarted)
            {
                EndGame();
            }
        }

        if (isGameStarted)
        {
        

             float rotationX = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
             float rotationY = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
             transform.Rotate(rotationX, rotationY, 0f);


            if (Input.GetKey(KeyCode.Space))
            {
                        
                 transform.localScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime;
            }

            else 

            {        
                transform.localScale = initialScale;
            }

                
        }

        else 
        {
           EndGame(); 
        }
        
    }


   void StartGame()
    {
        isGameStarted = true;
        Debug.Log("Game started!");
    }


    private void EndGame()
    {
        isGameStarted = false;
        Debug.Log("Game ended!");
    }
 }


