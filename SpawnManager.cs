using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    // Start is called before the first frame update
    [SerializeField]
    private GameObject _enemyContainer;
    
    void Start()
    {
        StartCoroutine(SpawnRoutine());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //spawn game object every 5 sec
    // create a coroutine of type IEnumerator -- yiled events
    //while loop
    IEnumerator SpawnRoutine()
    {
        while(true)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-8f, 8f), 7, 0);
            GameObject newEnemy = Instantiate(_enemyPrefab, posToSpawn, Quaternion.identity);
            newEnemy.transform.parent = _enemyContainer.transform;
            yield return new WaitForSeconds(5.0f);

        }
        //while loop(infinte loop)
        //Instantiate enemy prefab
        //yield wait for 5 seconds
    }
}
