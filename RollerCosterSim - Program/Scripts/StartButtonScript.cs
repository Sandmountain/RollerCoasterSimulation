using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour {

    public Text textComponent;
    private bool pause = false;
    public Button start;
    

    // Use this for initialization
    void Start () {

        ContinueGame();
        Button strtbtn = start.GetComponent<Button>();
        strtbtn.onClick.AddListener(TaskOnClick);
        
        
    }
	
	void TaskOnClick()
    {
        if (pause == true)
        {
            ContinueGame();
            pause = false;
        }
        else
        {
            PauseGame();
            pause = true;
        }
          
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        textComponent.text = "Start";

        //Disable scripts that still work while timescale is set to 0
    }
    private void ContinueGame()
    {
        Time.timeScale = 1;
        textComponent.text = "Pause";
        //enable the scripts again
    }
}

