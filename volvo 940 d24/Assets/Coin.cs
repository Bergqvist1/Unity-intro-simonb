using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update

    float time = 0;

    void Update()
    {
        float startYpos = 1.5f;
        float yPos = startYpos + (float)Math.Sin(time);
        Vector3 position = transform.position;
        position.y = yPos;
        transform.position = position;

        time += Time.deltaTime *20;
    }

     void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            other.GetComponent<Player>().AddPoints(UnityEngine.Random.Range(1,100));
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
   
}
