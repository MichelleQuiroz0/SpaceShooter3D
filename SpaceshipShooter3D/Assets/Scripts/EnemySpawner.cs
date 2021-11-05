using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   [SerializeField]
    public List<GameObject> enemyShips = new List<GameObject>();

    public float rangeXPointA;
    public float rangeXPointB;
    public float rangeYPointA;
    public float rangeYPointB;
    public float positionZ;

    int randomShip;
    int randomShipAmount;
    private Vector3 spawnPosition;

    public float spawnStart;
    public float spawnMaxDelay;
    public float spawnMinDelay;
    public float spawnDelay;

    bool stopSpawn = false;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnShips());
    }

    // Update is called once per frame
    void Update()
    {
        spawnDelay = Random.Range(spawnMinDelay, spawnMaxDelay);
        randomShip = Random.Range(0, enemyShips.Count);
        randomShipAmount = Random.Range(0, 5);
        
    }

    IEnumerator SpawnShips()
    {
        yield return new WaitForSeconds(spawnStart); 

        while (!stopSpawn)
        {
            
            for (int i = 0; i < randomShipAmount; i++)
            {            
                spawnPosition = new Vector3(Random.Range(rangeXPointA, rangeXPointB), Random.Range(rangeYPointA, rangeYPointB), positionZ);

                Instantiate(enemyShips[randomShip], spawnPosition, Quaternion.identity);
            }
            
            yield return new WaitForSeconds(spawnDelay);

        }
    }
}
