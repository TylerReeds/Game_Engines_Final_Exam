using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TilePool : MonoBehaviour
{
    public static TilePool poolInstance;

    [SerializeField]
    private GameObject pooledTile1;
    [SerializeField]
    private GameObject pooledTile2;
    [SerializeField]
    private GameObject pooledTile3;
    [SerializeField]
    private GameObject pooledTile4;
    [SerializeField]
    private GameObject pooledTile5;
    [SerializeField]
    private GameObject pooledTile6;
    [SerializeField]
    private GameObject pooledTile7;

    private GameObject pooledTile; 

    private bool notEnoughTilesInPool = true;

    private List<GameObject> tiles;

    private void Awake()
    {
        poolInstance = this;
    }

    private void Start()
    {
        tiles = new List<GameObject>();
    }

    public GameObject GetTile()
    {
        int chance = Random.Range(0, 7);
        if (tiles.Count > 0)
        {
            for (int i = 0; i < tiles.Count; i++)
            {
                if (!tiles[i].activeInHierarchy)
                {
                    return tiles[i];
                }
            }
        }

        if (notEnoughTilesInPool)
        {
            if (chance == 0)
            {
                pooledTile = pooledTile1; 
            }
            else if (chance == 1)
            {
                pooledTile = pooledTile2;
            }
            else if (chance == 2)
            {
                pooledTile = pooledTile3;
            }
            else if (chance == 3)
            {
                pooledTile = pooledTile4;
            }
            else if (chance == 4)
            {
                pooledTile = pooledTile5;
            }
            else if (chance == 5)
            {
                pooledTile = pooledTile6;
            }
            else if (chance == 6)
            {
                pooledTile = pooledTile7;
            }

            GameObject proj = Instantiate(pooledTile);
            proj.SetActive(false);
            tiles.Add(proj);
            return proj;
        }

        return null;
    }

}
