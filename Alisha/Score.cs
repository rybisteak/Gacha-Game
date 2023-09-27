using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Green greenScript;
    public Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        greenScript = GameObject.FindGameObjectWithTag("Green").GetComponent<Green>();
    }

    // Update is called once per frame
    void Update()
    {
       DisplayTime (greenScript.count);
    }

    void DisplayTime (int timeToDisplay)
    {
        timeText.text = string.Format("{0:000}", timeToDisplay);
    }
}
