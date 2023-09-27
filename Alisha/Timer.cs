using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 5;
    public Text timeText;

    Green greenScript;


    // Start is called before the first frame update
    void Start()
    {
        greenScript = GameObject.FindGameObjectWithTag("Green").GetComponent<Green>();
    }
    public void ResetTimer() {
        if (greenScript.count > 30)
        {
            timeValue = 2;
        }
        else if (greenScript.count > 20) 
        {
            timeValue = 4;
        }
        else if (greenScript.count > 15) 
        {
            timeValue = 2;
        }
        else if (greenScript.count > 10)
        {
            timeValue = 3;
        }
        else if (greenScript.count > 5)
        {
            timeValue = 4;
        } 
        else 
        {
            timeValue = 5;
        }
    }

    // Update is called once per frame
    void Update() 
    {
        
        if (timeValue > 0) 
        {
            timeValue -= Time.deltaTime;
        } 
        DisplayTime(timeValue);
        
    }

    void DisplayTime (float timeToDisplay)
     {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float seconds = Mathf.FloorToInt(timeToDisplay);

        timeText.text = string.Format("{0:00}", seconds);
     }
}
