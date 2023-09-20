using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject player; 
    public float midheight = 0f;
    public float maxheight = 0f;
    public float spawnRate = 1f;
    private float i ;
    private float firstSteps = 0;
    public float distanceFromPlayer = 10f;
    private float firstStage;
    private float secondStage;
    private float thirdStage;

    public GameObject CAAD;
    public GameObject afif;
    public GameObject water;
    public GameObject workers;
    public GameObject palm;
    public GameObject npcs1;
    public GameObject npsc2;
    public GameObject crow;
    public GameObject MBuilding;
    public GameObject ESB;
    // Update is called once per frame
    void Start()
    {
        i = spawnRate;
        firstSteps = player.transform.position.x;
        firstStage = spawnRate - 0.15f;
        secondStage = spawnRate - 0.25f;
        thirdStage = spawnRate - 0.35f;
    }
    void Update()
    {
        
        if((Time.time>30f) && (Time.time <50f)&& spawnRate!=firstStage) spawnRate= firstStage;
        else if((Time.time>50f) && (Time.time <70f) && spawnRate!=secondStage) spawnRate= secondStage;
        //else if((Time.time>70f) && (Time.time <90f)) spawnRate = spawnRate - 0.2f;
        else if(Time.time>70f && spawnRate!=thirdStage) spawnRate = thirdStage;

        if(player.transform.position.x-firstSteps>10)
        {
            if(Time.time>i)
            {
                i+=spawnRate;
            int w = Random.Range(1,6);

        }
        }
        }
    }
