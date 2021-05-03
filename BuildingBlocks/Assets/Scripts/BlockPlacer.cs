using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPlacer : MonoBehaviour
{
    public GameObject prefab;
    public void PlaceBlock()
    {
        Instantiate(prefab, new Vector3(1f,1f,0f), Quaternion.identity);
    }
}
