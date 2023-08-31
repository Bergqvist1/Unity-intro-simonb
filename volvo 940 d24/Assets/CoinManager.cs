using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public GameObject prefab;
    public GameObject coin;


    void Start()
    {
        coin = GameObject.FindGameObjectWithTag("Coin");
    }


    // Update is called once per frame
    void Update()
    {
        if(coin == null){
            SpawnCoin();
        }
    }

    private void SpawnCoin(){
        float x = Random.Range(-10f,10f);
        float z = Random.Range(-10f,10f); 
        Vector3 position = new Vector3(x,1.5f,z);

        coin = Instantiate(prefab);
        coin.transform.position = position;
    }
}
