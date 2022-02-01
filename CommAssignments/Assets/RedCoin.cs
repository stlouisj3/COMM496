using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour
{
    public GameObject coin;
    public Transform[] pos;
    public Trophy trophy;
    //private int numPos;

    void OnTriggerEnter(Collider coll)
    {
        trophy.Collected();
        for(int i = 0; i < pos.Length; i++)
        {
            GameObject newCoin = Instantiate(coin, pos[i].position, pos[1].rotation);
        }
        
        Destroy(this.gameObject);
    }
}
