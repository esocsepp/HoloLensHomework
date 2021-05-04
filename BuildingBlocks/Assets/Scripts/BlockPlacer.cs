using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPlacer : MonoBehaviour
{
    public Transform spawnPoint;

    private GameObject prefab;
    private Material activeColor;
    private GameObject activeObject;

    public void SetActiveMaterial(Material color)
    {
        activeColor = color;
    }

    public void SetActiveGameObject(GameObject block)
    {
          prefab = block;
    }
    public void PlaceBlock()
    {
        activeObject = Instantiate(prefab, spawnPoint);
        Material m = new Material(activeColor);
        activeObject.GetComponent<Renderer>().sharedMaterial = m;
    }

    public void SetParentToNull()
    {
        activeObject.GetComponent<Rigidbody>().isKinematic = false;
        activeObject.GetComponent<Rigidbody>().useGravity = true;
        activeObject.transform.parent = null;
    }
}
