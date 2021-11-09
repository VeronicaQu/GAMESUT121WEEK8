using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class LevelGen : MonoBehaviour
{
    
    public GameObject[] rooms;

   public enum SeedType { RANDOM, CUSTOM }
    [Header("Random Related Stuff")]
    public SeedType seedType = SeedType.RANDOM;
    System.Random random;
    public int seed = 0;

    [Space]
   
    public List<MyGridCell> gridCellList = new List<MyGridCell>();
    public int pathLength = 10;
    public int rows = 2;
    public int columns = 2;
    private GameObject currentRoom;
    [Range(1.0f, 10.0f)]
    public float cellSize = 1.0f;
    public GameObject[] collective;


    // Start is called before the first frame update
    void Start() {
         DrawGrid();
        DateTime epochStart = new System.DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        random = new System.Random( (int)(DateTime.Now - epochStart).TotalSeconds);


    }

    void DrawGrid() {
        Debug.Log("draw");
        float startX = ((-columns / 2.0f) * cellSize) + (cellSize / 2.0f);
        float startY = ((-rows/ 2.0f) * cellSize) + (cellSize / 2.0f);

        for(int i = 0; i < rows; i++) {
            //Debug.Log($"Hey this is number #{i}");
            for(int j = 0; j < columns; j++) {
                gridCellList.Add(
                    new MyGridCell(
                         startX + (j * cellSize),
                         startY + (i * cellSize)
                         )
                    );
            }
        }
    }

    void DrawRoom(){
        Debug.Log("room");

        for (int i = 0; i < gridCellList.Count; i++) {
            int RoomNumber = UnityEngine.Random.Range(0,4);
            Debug.Log("roomnumber" + RoomNumber);
            currentRoom = rooms[RoomNumber];

            Instantiate(currentRoom, gridCellList[i].location, Quaternion.identity);
            currentRoom.transform.position = gridCellList[i].location;
        }
    
  



    }

    void SetSeed() {
        if (seedType == SeedType.RANDOM) {
            random = new System.Random();
        }
        else if (seedType == SeedType.CUSTOM) {
            random = new System.Random(seed);
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SetSeed();
            DrawRoom();
            for (int i = 0; i < 5; i++)
            {
                Instantiate(collective[i], new Vector3(UnityEngine.Random.Range(-5f, 5f), UnityEngine.Random.Range(-5f, 5f),0), Quaternion.identity);
            }
        }

       
    }

}
