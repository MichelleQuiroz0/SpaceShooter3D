using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    //For when I want to add additional space objects to the spawner
    [SerializeField]
    public List<GameObject> obstacles = new List<GameObject>();

    //boundaries
    public float rangeXPointA;
    public float rangeXPointB;
    public float rangeYPointA;
    public float rangeYPointB;
    public float positionZ;

    int randomObstacle;
    int randomObstacleAmount;
    private Vector3 spawnPosition;

    public float spawnStart;
    public float spawnMaxDelay;
    public float spawnMinDelay;
    public float spawnDelay;

    bool stopSpawn = false;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SpawnObstacles());
    }

    // Update is called once per frame
    void Update()
    {
        spawnDelay = Random.Range(spawnMinDelay, spawnMaxDelay);
        randomObstacle = Random.Range(0, obstacles.Count);
        randomObstacleAmount = Random.Range(0, 3);

    }

    IEnumerator SpawnObstacles()
    {
        yield return new WaitForSeconds(spawnStart);

        while (!stopSpawn)
        {

            for (int i = 0; i < randomObstacleAmount; i++)
            {
                spawnPosition = new Vector3(Random.Range(rangeXPointA, rangeXPointB), Random.Range(rangeYPointA, rangeYPointB), positionZ);

                Instantiate(obstacles[randomObstacle], spawnPosition, Quaternion.identity);
            }

            yield return new WaitForSeconds(spawnDelay);

        }
    }
}
