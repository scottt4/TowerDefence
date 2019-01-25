using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    #region Public Properties

    public float axeDamage;

    // Public Gameobjects defined for our board
    public GameObject[] floorTiles;
    public GameObject[] enemies;
    public GameObject weapon;

    // Keep track of all objects
    public List<Vector3> createdFloor;
    public List<Vector3> createdEnemies;
    public List<Vector3> createdWeapons;

    // Define size of blocks
    public float rockTileSize = 32;
    public float rockBorderSize = 32;

    #endregion

    #region Private Properties
    private static int Width = 50;
    private static int Height = 45;
    private static int RockHeight = Height / 6;
    public static int offset = 583;
    #endregion

    private static BoardManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Every reference to this class uses the same instance
    public static BoardManager GetInstance()
    {
        return Instance;
    }

    // Start a coroutine, non-blocking
    private void Start()
    {
        StartCoroutine(GenerateBoard());
    }

    #region Generate Board
    private IEnumerator GenerateBoard()
    {
        #region Generate Rocks Floor
        for (int j = 0; j < RockHeight; j++)
        {
            for (int i = 0; i < Width; i++)
            {
                transform.position = new Vector3(rockTileSize * i - offset, rockTileSize * j, 0);
                CreateRockFloor();
            }
        }
        #endregion

        #region Generate Rocks Border
        for (int i = 0; i < Width; i++)
        {
            transform.position = new Vector3(rockTileSize * i - offset, 0, 0);
            CreateRockBorder();
        }

        for (int i = 0; i < Width; i++)
        {
            transform.position = new Vector3(rockTileSize * i - offset, rockTileSize * (RockHeight - 1), 0);
            CreateRockBorder();
        }
        #endregion

        //Spawns our weapon. subject to change.
        DamageEnemies.SetupWeapon(Instance, weapon);

        // Yield allows this to be non-blocking. This is the preferred method in Unity, over async functions
        yield return 0;
    }

    #region Create Tiles
    private void CreateRockFloor()
    {
        GameObject rockFloor;
        rockFloor = Instantiate(floorTiles[0], transform.position, transform.rotation) as GameObject;

        createdFloor.Add(rockFloor.transform.position);
    }

    private void CreateRockBorder()
    {
        GameObject rockBorder;
        rockBorder = Instantiate(floorTiles[1], transform.position, transform.rotation) as GameObject;

        createdFloor.Add(rockBorder.transform.position);
    }

    public int GetOffset()
    {
        return offset;
    }
    #endregion
    #endregion
}
