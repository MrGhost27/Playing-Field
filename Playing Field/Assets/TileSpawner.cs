using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public int width = 1;
    public int depth = 1;

    GameObject TilePrefab;

    public void SpawnTiles()
    {
        Debug.Log("Spawning the tiles. Width: " + width + " depth: " + depth);
    }

    public void ResetSize(int newWidth, int newDepth)
    {
        width = newWidth;
        depth = newDepth;
    }

    public void SetPrefab(GameObject GO) {
        TilePrefab = GO;
    }
}
