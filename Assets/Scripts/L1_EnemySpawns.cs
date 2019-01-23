using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1_EnemySpawns : MonoBehaviour
{
    private SpawnEnemies spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = SpawnEnemies.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
