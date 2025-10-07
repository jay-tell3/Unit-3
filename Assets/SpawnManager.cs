using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnpos= new Vector3(25,0,0);
    private float spawnRate = 2;
    private float spawnDelay = 2;
    private PlayerController PlayerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle",spawnDelay,spawnRate);
        PlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if (PlayerController.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnpos, obstaclePrefab.transform.rotation);
        }    }
    void Update()
    {
        
    }
}
