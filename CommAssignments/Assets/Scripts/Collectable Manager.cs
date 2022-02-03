using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Keeps track of coins and spawns in a trophy after a while
public class CollectableManager : MonoBehaviour
{
    public GameObject trophy;
    public Transform pos;
    public float collected = 0f;
    public float totalCoins = 5f;
    // Is more of a collectable manager
    void Start()
    {
        collected = 0f; 
    }

    // Update is called once per frame
    public void Collected() //A coin is collected
    {
        collected++;
    }
   
    void Update() //Spawns in a trophy after all coins are collected
    {
        if(collected == totalCoins)
        {
           Instantiate(trophy, pos.position, pos.rotation);
            collected = 0f;
        }
    }
    
}
