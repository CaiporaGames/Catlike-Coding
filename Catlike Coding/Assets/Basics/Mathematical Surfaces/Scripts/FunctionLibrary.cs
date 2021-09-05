using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;
public static class FunctionLibrary
{
    public static float Wave(float x, float t)
    {
        return Sin(PI * (x + t));
    }

    public static float MultiWave(float x, float t)
    {
        float y = Sin(PI * (x + t));
        y += Sin(2*(x+t)) / 2f;
        y = y / 1.5f;
        return y;
    }
}
