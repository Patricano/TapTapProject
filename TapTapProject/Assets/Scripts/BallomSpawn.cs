using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallomSpawn : MonoBehaviour
{
   public Transform[] spawnPoint;
    public GameObject[] baloons;

    private void Start()
    {
        StartCoroutine(SpawnStart());
    }

    IEnumerator SpawnStart()
    {
        yield return new WaitForSeconds(4);

        for (int i = 0; i < 3; i++)
        {
            Instantiate(baloons[i], spawnPoint[i].position, Quaternion.identity);
        }

        StartCoroutine(SpawnStart());

    }
}
