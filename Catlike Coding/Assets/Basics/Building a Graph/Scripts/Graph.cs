using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField] Transform pointPosition;
    [SerializeField, Range(10,100)] int resolution;

    private void Awake()
    {
        Vector3 position = new Vector3();
        for (int i = 0; i < resolution; i++)
        {
            position.y = Mathf.Pow(i,2)/resolution;
            position.x = i;
            Transform point = Instantiate(pointPosition, position, Quaternion.identity);            
        }
    }
}
