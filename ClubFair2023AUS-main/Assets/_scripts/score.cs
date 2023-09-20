using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI points;
    public GameObject player;
    private float steps;
    
    void Update()
    {
        if(player)
        {
        if(Time.time<1f) steps = player.transform.position.x;
        points.text = ((int)((player.transform.position.x*10-steps*10))).ToString();
        }
    }
}
