using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hazardPrefab;
    public Vector3 spawnValues;
    public int waveSize = 5;
    public float startDelay = 1.0f;
    public float hazardDelay = 0.5f;
    public float waveDelay = 3.0f;

    public void SpawnHazard()
    {
        var spawnPos = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        Instantiate(hazardPrefab, spawnPos, Quaternion.identity);
    }

    public IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startDelay);
        while (true)
        {
            for (var i = 0; i < waveSize; i++)
            {
                SpawnHazard();
                yield return new WaitForSeconds(hazardDelay);
            }
            yield return new WaitForSeconds(waveDelay);
        }
    }

    private void Awake()
    {
        StartCoroutine(SpawnWaves());
    }
}