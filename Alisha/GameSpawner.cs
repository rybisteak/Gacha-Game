using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    public Transform spawnpos;// the position where I wanted to clone my sphere
    public GameObject coin;// gameobject you want to spawn
    Green greenScript;
    private int spawnCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        greenScript = GameObject.FindGameObjectWithTag("Green").GetComponent<Green>();
    }

    // Update is called once per frame
    void Update()
    {
        if (greenScript.count == 20 && spawnCount == 0) {
            GameObject obj = Instantiate(coin, spawnpos.position, spawnpos.rotation);
            spawnCount++;
        }
    }
}
