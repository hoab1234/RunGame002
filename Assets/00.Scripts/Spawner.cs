using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    public float generateTerm = 2;
    public Transform spawnPoint;

    private float time = 0;

    public float minSpawnDelay = 2;
    public float maxSpawnDelay = 5;

    void Update()
    {
        time += Time.deltaTime;

        if(time > generateTerm)
        {
            GameObject obstacle = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length - 1)];
            
            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);

            time = 0;
            generateTerm = Random.Range(minSpawnDelay, maxSpawnDelay);
            Debug.Log("다음 생성 대기 시간 : " + generateTerm);
        }
    }
}
