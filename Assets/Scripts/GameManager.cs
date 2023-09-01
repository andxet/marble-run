using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject marblePrefab;

    public int marbleToSpawn = 20;

    public Transform spawnPoint;

    public List<GameObject> marbles = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        Vector3 topLeftSpawnPosition = spawnPoint.position;
        topLeftSpawnPosition.x -= 4.5f;
        for (int i = 0; i < marbleToSpawn; i++)
        {
            int row = i / 10;
            int col = i % 10;

            Vector3 spawnPos = topLeftSpawnPosition;
            spawnPos.y -= row;
            spawnPos.x += col;

            GameObject go = Instantiate(marblePrefab, spawnPos, Quaternion.identity);
            marbles.Add(go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
