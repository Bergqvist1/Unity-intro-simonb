using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsUI : MonoBehaviour
{

    private Player player;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        int p = player.Points;
        text.text = "Zubrowka : " + p; 
    }
}
