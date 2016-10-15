using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hazardPrefab;
    public Vector3 spawnValues;

    public void SpawnHazard()
    {
        var spawnPos = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        Instantiate(hazardPrefab, spawnPos, Quaternion.identity);
    }


    private void Awake()
    {
        SpawnHazard();
    }
}