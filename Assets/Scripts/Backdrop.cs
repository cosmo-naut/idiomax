using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backdrop : MonoBehaviour
{
    public GameObject tile;
    int tileSize = 10;
    int width = 600;
    int height = 800;

    public List<List<Transform>> Tiles;
}
