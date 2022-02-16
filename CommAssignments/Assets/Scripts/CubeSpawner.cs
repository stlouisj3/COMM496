using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public delegate void CubeSpawn();
    public static CubeSpawn begin;
    bool spawnerStartered = false;

    ObjectPool objectPool; 
    // Start is called before the first frame update
   private void Start()
    {
        objectPool = ObjectPool.Instance;
        begin = TrueSpawn;
    }

    // Update is called once per frame

    public void TrueSpawn()
    {
        spawnerStartered = true;
    }
    void FixedUpdate()
    {
        if (spawnerStartered)
        {
            objectPool.SpawnFromPool("Cube", transform.position, Quaternion.identity);
        }
        
    }
}
