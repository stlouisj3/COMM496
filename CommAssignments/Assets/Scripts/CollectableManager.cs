using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{

    public float collected = 0f;
    public float totalCoins = 5f;
    
    // 1. Declare a delegate: 
    public delegate void CollectionEvent(int val);
    // 2. Declare a Specific Event
    public static CollectionEvent RedCoinCollected;
    //public static CollectionEvent spawnTrophy;

    //public static event CollectionEvent RedCoinCollected;



    // Is more of a collectable manager
    void Start()
    {
        collected = 0f;
        RedCoinCollected = Collected;
    }

    // Update is called once per frame
    void Collected(int val) //A coin is collected
    {
        collected+= val;
       if(collected == totalCoins)
        {
            CubeSpawner.begin();
           
            collected = 0f;
        }
    }
   
   
    
}
