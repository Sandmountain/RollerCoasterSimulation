using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour {

    public Button restart;
    

    void Start()
    {
  
        Button btn = restart.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }
    void TaskOnClick()
    {
        Application.LoadLevel("Ihopslag");
    }
}
