using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    ObjectPool objectPool; 
    // Start is called before the first frame update
   private void Start()
    {
        objectPool = ObjectPool.Instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        objectPool.SpawnFromPool("Cube", transform.position, Quaternion.identity);
    }
}
