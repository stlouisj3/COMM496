using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
  /*  public GameObject objectToPool;

    public List<GameObject> thePool = new List<GameObject>();

    public int startAmount;

    // Start is called before the first frame update
    void Start()
    {
       for(int i = 0; i < startAmount; i++)
        {
            thePool.Add(Instantiate(objectToPool));
            thePool[i].setActive(false);
            thePool[i].transform.parent = transform;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject SpawnObject(Vector3 position, Quaternion rotation)
    {
        GameObject toReturn;


        toReturn = thePool[0];
        thePool.RemoveAt(0);

        toReturn.setActive(true);
        toReturn.transform.position = position;
        toReturn.transform.rotation = rotation;

        return toReturn;
    }*/
}
