using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class Green : MonoBehaviour
{
    Timer timerScript;

    public int count = 0;
    public int modCount = 0;

    // Start is called before the first frame update
    void createNew() {
        transform.position = new Vector3(Random.Range(30,650), 
        Random.Range(30,300),0);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) 
        {
            createNew();
            Debug.Log("hit");
            count++;
            
            if (count > 20) {
                modCount++;
                if (modCount % 2 == 0) 
                {
                    timerScript.ResetTimer();
                }
            }
            else 
            {
                timerScript.ResetTimer();
            }
            CurrencyManager.Instance.Currency += 1;
        }
    }
    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) 
        {
            createNew();
            Debug.Log("hit");
            count++;
            
            if (count > 20) {
                modCount++;
                if (modCount % 2 == 0) 
                {
                    timerScript.ResetTimer();
                    modCount = 0;
                }
            }
            else 
            {
                timerScript.ResetTimer();
            }
            CurrencyManager.Instance.Currency += 1;
        }
    }
    void Start()
    {
        timerScript = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        createNew();

    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
