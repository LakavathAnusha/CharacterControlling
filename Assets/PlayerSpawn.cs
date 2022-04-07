using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public Transform playerSpawnPoint;
     Transform[] spawnPositions;
    public bool isRespawn = false;
    public bool respawnToggle = false;
    int k;
    // Start is called before the first frame update
    void Start()
    {
        spawnPositions = playerSpawnPoint.GetComponentsInChildren<Transform>();
       // RandomSpawn();
       // Debug.Log(spawnPositions.Length);
    }


    // Update is called once per frame
    void Update()
    {
       /* if(respawnToggle!=isRespawn)
        {
            RandomSpawn();
            isRespawn = false;
        }
        else
        {
            respawnToggle = isRespawn;
        }*/
       if(Input.GetKeyDown(KeyCode.Space))
        {
            k = RandomSpawn();
        }
        this.transform.position = spawnPositions[k].transform.position;
    }
    private int RandomSpawn()
    {
        int i = UnityEngine.Random.Range(1, spawnPositions.Length);
        Debug.Log(i);
        this.transform.position = spawnPositions[i].transform.position;
        return (i);
    }

}
