using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public Transform[] spawnPositions;
    public Transform currentLocation;
    public Transform nextLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("bullet"))
        {
            changeLocation();
        }
    }
    void changeLocation()
    {
        nextLocation = spawnPositions[Random.Range(0,9)];
        transform.position = nextLocation.position;
        currentLocation = nextLocation;
    }
}
