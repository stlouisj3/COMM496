using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Used for coins to allow coin to disapear and add one to the counter
public class Coin : MonoBehaviour
{
    //public float collected = 0f;
    public float timer = 15f;
    public CollectableManager trophy;
    void Start()
    {
        StartCoroutine(CountDown());
    }
    void OnTriggerEnter(Collider coll)
    {
        trophy.Collected();
        Destroy(this.gameObject);
    }
    IEnumerator CountDown()
    {
        while(timer > 0)
        {
            yield return new WaitForSeconds(1);
            timer--;
        }
        if(timer == 0)
        {
            GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(0.5f);
            GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(0.5f);
            GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(0.5f);
            GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(0.5f);
            GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(0.5f);
            GetComponent<Renderer>().enabled = true;

            Destroy(this.gameObject);
        }
    }
}
