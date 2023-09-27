
using UnityEngine;

public class Alisha : MonoBehaviour
{
    //pick random location for green space to spawn
    //load green space
    // wasdd
    // Start is called before the first frame update
    public float speed = 200f;
    
    UIManager uiScript;
    Green greenScript;
    
    void Start()
    {
        uiScript = GameObject.FindGameObjectWithTag("GUI").GetComponent<UIManager>();
        greenScript = GameObject.FindGameObjectWithTag("Green").GetComponent<Green>();
    }

    void changeSpeed()
    {
        if (greenScript.count > 15) 
        {
            speed = 350f;
        }
        else if (greenScript.count > 10)
        {
            speed = 300f;
        }
        else if (greenScript.count > 5)
        {
            speed = 250f;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if (!uiScript.isGameOver)
        {
            if (Input.GetKey(KeyCode.W)) {
                if (transform.position.y < 320)
                {
                    transform.position += new Vector3(0, speed * Time.deltaTime,0);
                }
            }
            if (Input.GetKey(KeyCode.A)) {
                if (transform.position.x > 35)
                {
                    transform.position += new Vector3(-speed * Time.deltaTime,0,0);
                }
            }
            if (Input.GetKey(KeyCode.S)) {
                if (transform.position.y > 35) 
                {
                    transform.position += new Vector3(0,-speed * Time.deltaTime,0);
                }
            }
            if (Input.GetKey(KeyCode.D)) {
                if (transform.position.x < 657f)
                {
                    transform.position += new Vector3(speed * Time.deltaTime,0,0);
                }
            }
            changeSpeed();
        }

    }
}
