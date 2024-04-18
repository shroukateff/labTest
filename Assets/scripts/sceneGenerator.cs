using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneGenerator : MonoBehaviour
{
    [SerializeField] private Transform levelPart;
    private void Awake()
    {
        spawnParts(new Vector3(2,4));
        spawnParts(new Vector3(2, 4) + new Vector3(2, 4));
    }
    private void spawnParts(Vector3 spawnPosition)
    {
        Instantiate(levelPart, spawnPosition, Quaternion.identity);
    }
}
