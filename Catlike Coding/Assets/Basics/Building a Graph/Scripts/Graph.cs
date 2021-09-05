using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Graph : MonoBehaviour
{
    [SerializeField] Transform pointPosition;
    [SerializeField, Range(10,100)] int resolution;


    Transform[] points;

    private void Awake()
    {
        points = new Transform[resolution];
        Vector3 position = Vector3.zero;
        GeneratePoints(position);
    }

    void GeneratePoints(Vector3 position)
    {
        for (int i = 0; i < resolution; i++)
        {
            position = position + Vector3.one;
            points[i] = Instantiate(pointPosition, position, Quaternion.identity);
        }
    }

    void Parabola(Vector3 position)
    {
        for (int i = 0; i < resolution; i++)
        {
            position.y = Mathf.Pow(i, 2) / resolution;
            position.x = i;
            Transform point = Instantiate(pointPosition, position, Quaternion.identity);
        }
    }


    void Update()
    {
        float time = Time.time;
        for (int i = 0; i < points.Length; i++)
        {
            Transform point = points[i];
            Vector3 position = point.localPosition;
            //position.y = FunctionLibrary.Wave(position.x, time);
            position.y = FunctionLibrary.MultiWave(position.x, time);
            point.localPosition = position;
        }
    }
}
