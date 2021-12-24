using System;
using System.Numerics;

public class Asteroid
{
    Vector2 position;

    float radius = 3;

    public Vector2 GetPosition()
    {
        return position;
    }

    public float GetSize()
    {
        return radius;
    }

}