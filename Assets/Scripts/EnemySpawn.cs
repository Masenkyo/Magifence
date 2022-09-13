using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    Waves waves;
    
    void Start()
    {
        StartCoroutine(SpawnEnemyOvertime());
    }

    
    void Update()
    {
        
    }
    IEnumerator SpawnEnemyOvertime()
    {
        
        while (true)
        {
            for (int i = 0; i < waves.Enemies.Length; i++)
            {
                for (int j = 0; j < waves.Amounts[i]; j++)
                {
                    Instantiate(waves.Enemies[i], this.transform.position, Quaternion.identity);
                    yield return new WaitForSeconds(1f);
                }
            }
            break;
        }
    }
}
