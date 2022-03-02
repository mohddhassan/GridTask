using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject playerPrefab;
    private int rowPosition = 0;
    private int colPosition = 0;
    private int numOfRows;
    private int numOfCols;
    public GridSpawner grid;
    private Vector3 offset = new Vector3(0, 1, 0);
    void Start()
    {
        numOfRows = grid.numOfRows;
        numOfCols = grid.numOfCols;
        Instantiate(playerPrefab, new Vector3(7, 1.5f, 5), transform.rotation);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (colPosition >= 0 && colPosition < numOfCols)
            {
                colPosition--;
            }
            playerPrefab.transform.position = grid.cells[rowPosition][colPosition].transform.position + offset;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (colPosition >= 0 && colPosition < numOfCols)
            {
                rowPosition--;
            }
            playerPrefab.transform.position = grid.cells[rowPosition][colPosition].transform.position + offset;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (colPosition >= 0 && colPosition < numOfCols)
            {
                colPosition++;
            }
            playerPrefab.transform.position = grid.cells[rowPosition][colPosition].transform.position + offset;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (colPosition >= 0 && colPosition < numOfCols)
            {
                rowPosition++;
            }
            playerPrefab.transform.position = grid.cells[rowPosition][colPosition].transform.position + offset;
        }


    }
}
