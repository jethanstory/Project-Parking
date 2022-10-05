/*
    Grid Manager experimental script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePrefab;

    void Start() 
    {
    GenerateGrid();
    }
    // Start is called before the first frame update
    void GenerateGrid()
    {
        for (int x = 0; x < _width; x++) {
            for (int y = 0; y < _height; y++) {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
