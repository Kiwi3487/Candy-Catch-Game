using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnCandy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Candy1Prefab;
    [SerializeField] private Rigidbody2D Candy2Prefab;
    [SerializeField] private Rigidbody2D Candy3Prefab;
    [SerializeField] private Rigidbody2D Candy4Prefab;
    [SerializeField] private Rigidbody2D Candy5Prefab;
    private Rigidbody2D rb;
    private float nextExecutionTime;
    private float minInterval = 1f;
    private float maxInterval = 3f;
    public float radius = 8;
    public Vector3 origin = Vector3.zero;

    public int totalCandy;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetNextExecutionTime();
    }

    private void Update()
    {
        // Check if it's time to execute the method
        if (Time.time >= nextExecutionTime)
        {
            // Execute the method
            spawnCandy();

            // Calculate the next random execution time
            SetNextExecutionTime();
        }
    }

    private void SetNextExecutionTime()
    {
        nextExecutionTime = Time.time + Random.Range(minInterval, maxInterval);
    }

    public void spawnCandy()
    {
        if (totalCandy != 15)
        {
            int randomNumber = Random.Range(1, 11);
            //Debug.Log("RanNum chosen: " + randomNumber);
            if (randomNumber == 1 || randomNumber == 2 || randomNumber == 3 || randomNumber == 4)
            {
                Vector3 randomPosition = origin + Random.insideUnitSphere * radius;
                Instantiate(Candy1Prefab, randomPosition, Quaternion.identity);
                totalCandy++;
            }
            if (randomNumber == 5 || randomNumber == 6 || randomNumber == 7)
            {
                Vector3 randomPosition = origin + Random.insideUnitSphere * radius;
                Instantiate(Candy2Prefab, randomPosition, Quaternion.identity);
                totalCandy++;
            }
            if (randomNumber == 8 || randomNumber == 9)
            {
                Vector3 randomPosition = origin + Random.insideUnitSphere * radius;
                Instantiate(Candy3Prefab, randomPosition, Quaternion.identity);
                totalCandy++;
            }
            if (randomNumber == 10)
            {
                Vector3 randomPosition = origin + Random.insideUnitSphere * radius;
                Instantiate(Candy4Prefab, randomPosition, Quaternion.identity);
                totalCandy++;
            }
            if (randomNumber == 11)
            {
                Vector3 randomPosition = origin + Random.insideUnitSphere * radius;
                Instantiate(Candy5Prefab, randomPosition, Quaternion.identity);
                totalCandy++;
            }
        }
    }
}