using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Board : MonoBehaviour
{
    private List<Cell> grid = new List<Cell>();

private Renderer backgroundRenderer;
private int minX = 0;
private int maxX = 0;
private int minY = 0;
private int maxY = 0;

    // Start is called before the first frame update
    void Start()
    {
        InitializeGrid();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Reset()
    {
        InitializeGrid();
    }
    private void InitializeGrid()
    {
          backgroundRenderer = GetComponent<Renderer>();
        if (backgroundRenderer == null)
        {
            Debug.LogError("Error: Backgropund Renderer couldn't be found");
        }

    Debug.Log("Initilaize grid");

//for editor only, remove old cells before creating new ones
    grid.Clear();

    maxX = Mathf.CeilToInt(backgroundRenderer.bounds.max.x);
    minX = Mathf.CeilToInt(backgroundRenderer.bounds.min.x + 0.5f);
    maxY = Mathf.CeilToInt(backgroundRenderer.bounds.max.y);
    minY = Mathf.CeilToInt(backgroundRenderer.bounds.min.y + 0.5f);
    for (int y = minY; y < maxY; y++)
    {
        for (int x = minX; x < maxX; x++)
        {
            Cell currentCell = new Cell(x, y, true);
            grid.Add(currentCell);
        }
    }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        
        foreach (Cell item in grid)
        {
            Gizmos.DrawWireCube(new Vector3(item.x, item.y), Vector3.one);
        }
    }
}