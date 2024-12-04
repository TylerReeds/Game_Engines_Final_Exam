using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePool : MonoBehaviour
{
    public static TilePool poolInstance;

    [SerializeField]
    private GameObject pooledTile1;
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
            GameObject proj = Instantiate(pooledTile);
            proj.SetActive(false);
            tiles.Add(proj);
            return proj;
        }

        return null;
    }

}
