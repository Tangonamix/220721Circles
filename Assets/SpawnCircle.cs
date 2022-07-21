using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircle : MonoBehaviour
{
    public GameObject circlePrefab;
    public Vector3 spawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //abc
        if(Input.GetKeyDown(KeyCode.Q) == true)
        {
            float randomX = Random.Range(-0.5f, 0.5f);
            spawnLocation.x = spawnLocation.x + randomX;

            Instantiate(circlePrefab,spawnLocation,Quaternion.identity);
        }
    }
}
