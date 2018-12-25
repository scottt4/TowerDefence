using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    #region Public Properties
    public GameObject[] backgroundTiles;
    public GameObject[] floorTiles;
    public GameObject[] foregroundTiles;
    public GameObject[] enemies;
    public GameObject exit;

    public List<Vector3> createdBackground;
    public List<Vector3> createdFloor;
    public List<Vector3> createdForeground;
    public List<Vector3> createdEnemies;

    public float rockTileSize;
    public float rockBorderSize;

    #endregion


    #region Private Properties
    private static int Width = 45;
    private static int Height = 45;
    private int RockHeight = Height / 6;
    #endregion

    void Start()
    {
        StartCoroutine(GenerateBoard());
    }

    #region Generate Level
    IEnumerator GenerateBoard()
    {
        #region Generate Rocks Floor
        for (int j = 0; j < RockHeight; j++)
        {
            for (int i = 0; i < Width; i++)
            {
                transform.position = new Vector3(rockTileSize * i, rockTileSize * j, 0);
                CreateRockFloor();
            }
        }
        #endregion

        #region Generate Rocks Border
        for (int i = 0; i < Width; i++)
        {
            transform.position = new Vector3(rockTileSize * i, 0, 0);
            CreateRockBorder();
        }

        for (int i = 0; i < Width; i++)
        {
            transform.position = new Vector3(rockTileSize * i, rockTileSize * (RockHeight - 1), 0);
            CreateRockBorder();
        }
        #endregion
        yield return 0;
    }

    #region Create Tiles
    void CreateRockFloor()
    {
        GameObject rockFloor;
        rockFloor = Instantiate(floorTiles[0], transform.position, transform.rotation) as GameObject;

        createdFloor.Add(rockFloor.transform.position);
    }

    void CreateRockBorder()
    {
        GameObject rockBorder;
        rockBorder = Instantiate(floorTiles[1], transform.position, transform.rotation) as GameObject;

        createdFloor.Add(rockBorder.transform.position);
    }
    #endregion
    #endregion
}
