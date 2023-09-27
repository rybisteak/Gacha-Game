using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text restartText;
    public bool isGameOver = false;

    Timer timerScript;

    // Start is called before the first frame update
    void Start()
    {
        //disables panel if active
        gameOverPanel.SetActive(false);
        restartText.gameObject.SetActive(false);
        timerScript = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        //trigger game over manually and check with bool so it isn't called multiple times
        if (timerScript.timeValue < 0 && !isGameOver)
        {
            isGameOver = true;

            StartCoroutine(GameOverSequence());
        }

        //if game is over
        if (isGameOver) 
        {
            //if R is hit, restart scene
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    //controls game over canvas and there's a brief delay between game over text and new scene
    private IEnumerator GameOverSequence()
    {
        gameOverPanel.SetActive(true);

        yield return new WaitForSeconds(5.0f);

        restartText.gameObject.SetActive(true);
    }
}
