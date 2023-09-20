using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject player; 
    public float midheight = 0f;
    public float maxheight = 0f;
    public float spawnRate = 0.8f;
    public float buildRate = 9f;
    private float i ;
    private float j;
    private float firstSteps = 0;
    public float distanceFromPlayer = 12f;
    public float BuildingDistance = 50f;
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
    if (Time.time > j)
    {
        j += buildRate;
        int a = Random.Range(1, 3);

        if (a == 1) Instantiate(ESB, new Vector3(player.transform.position.x + BuildingDistance, -0.69f, 4), Quaternion.identity);
        else if (a == 2) Instantiate(MBuilding, new Vector3(player.transform.position.x + BuildingDistance, -1.15f, 4), Quaternion.identity);
    }

    if (player.transform.position.x - firstSteps > 10f)
    {
        if (Time.time > i)
        {
            i += spawnRate;
            int w = Random.Range(1, 7);

            if (w == 1) Instantiate(CAAD, new Vector3(player.transform.position.x + distanceFromPlayer, -1.05f, 0), Quaternion.identity);
            else if (w == 2) Instantiate(afif, new Vector3(player.transform.position.x + distanceFromPlayer, -1.05f, 0), Quaternion.identity);
            else if (w == 3) Instantiate(water, new Vector3(player.transform.position.x + distanceFromPlayer, -0.78f, 0), Quaternion.identity);
            else if (w == 4) Instantiate(workers, new Vector3(player.transform.position.x + distanceFromPlayer, -0.7f, 0), Quaternion.identity);
            else if (w == 5) Instantiate(npcs1, new Vector3(player.transform.position.x + distanceFromPlayer, 0.3f, 0), Quaternion.identity);
            else if (w == 6) Instantiate(npsc2, new Vector3(player.transform.position.x + distanceFromPlayer, -0.9f, 0), Quaternion.identity);
            else if (w == 7) Instantiate(palm, new Vector3(player.transform.position.x + distanceFromPlayer, -0.78f, 0), Quaternion.identity);
        }
    }
}

    }
