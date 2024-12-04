using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Spawning : MonoBehaviour
{
    public Tile_Behaviour TilePrefab;
    public Transform LaunchOffset;

    public float spawnTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnTiles");
    }

    private void Fire()
    {
        Vector2 projDirection = new Vector2(0, -1);
        GameObject proj = TilePool.poolInstance.GetTile();
        proj.transform.position = LaunchOffset.transform.position;
        proj.transform.rotation = LaunchOffset.transform.rotation;
        proj.SetActive(true);
        proj.GetComponent<Tile_Behaviour>().SetMoveDirection(projDirection);
    }

    IEnumerator SpawnTiles()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            Fire();
        }
    }
}