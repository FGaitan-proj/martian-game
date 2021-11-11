using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bombPrefab;
    [SerializeField] private Score scoreboard;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      if (scoreboard.bombs > 0){
        if (Input.GetKeyDown(KeyCode.Space))
        {
          SpawnBomb();
          scoreboard.bombs--;
        }
      }
      //else{Debug.Log("No more Bombs!");}

    }
    void SpawnBomb()
    {
      Instantiate(bombPrefab, transform.position, Quaternion.identity);
    }
}
