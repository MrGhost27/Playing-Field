using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    // The manager doesn't care about spawning tiles.
    TileSpawner TS;
    
    // Which tile prefab will be passed to the spawner.
    [SerializeField] private GameObject Tile;

    // Start is called before the first frame update
    void Start()
    {
        // Adding it, you can't customise it.
        //TS = gameObject.AddComponent<TileSpawner>();
        TS = gameObject.GetComponent<TileSpawner>();
        if (TS==null) 
        {
            Debug.Log("There is no TileSpawner attached to this gameobject: " + gameObject.name);
        }
        InitialiseSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitialiseSpawner()
    {
        TS.ResetSize(3, 3);
        if (Tile== null)
        {
            Debug.Log("You don't have a tile!");
        }
        else {
            TS.SetPrefab(Tile);
            TS.SpawnTiles();
        }
    }
}
