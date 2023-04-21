using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

        CreatePrefab(10);
    }
    void CreatePrefab(int dist)
    {
            for (int i = 1; i < dist ; i++)
        {
           
            Instantiate(prefab, new Vector3 (spawnPoint.transform.position.x, spawnPoint.transform.position.y, i*3f), Quaternion.Euler(90.0f ,90.0f, 0f));
            

           //  Vector3 spawnpositon = new Vector3(spawnValues.x, 1f, spawnValues.z + 5);
           //new Vector3 (spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z + 1f)
        
         }

    }

    // Update is called once per frame
    void Update()
    {
        //Whenever we hit the B key we will generate a prefab at the position of the original prefab
        //Whenever we hit the space key, we will generate a prefab at the position of the spawn object that this script is attached to 

        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }

    }
}
