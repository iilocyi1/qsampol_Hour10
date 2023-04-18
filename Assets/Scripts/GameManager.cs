using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GoalScript blue, green, red, orange;
    private bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    private void StartGame()
    {
        isGameOver = false;
    }
    // Update is called once per frame
    void Update()
    {
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
    }
    void OnGUI()
    {
        if (isGameOver)
        {
            string message;

            if(isGameOver)
            {
                message = "Click or Press Enter to Play Again";
            }
            else
            {
                message = "Click or Press Enter to Play";
            }

            Rect startButton = new Rect(Screen.width / 2 - 120, Screen.height / 2, 240, 30);

            if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
            {
                
                StartGame();
            }
        }

    }
}
