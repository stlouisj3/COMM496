using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Acts like the red coin from mario and will spawn other coins
public class RedCoin : MonoBehaviour
{
    public GameObject coin;
    public Transform[] pos;

    //private int numPos;

    void OnTriggerEnter(Collider coll)
    {
        Trophy.RedCoinCollected();
        for(int i = 0; i < pos.Length; i++)
        {
            GameObject newCoin = Instantiate(coin, pos[i].position, pos[1].rotation);
        }
        
        Destroy(this.gameObject);
    }
}
