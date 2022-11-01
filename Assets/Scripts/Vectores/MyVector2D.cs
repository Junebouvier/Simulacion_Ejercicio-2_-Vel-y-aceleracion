using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
struct MyVector
{
    public float x;
    public float y;
    
    public MyVector(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public void Draw(Color color)
    {
        Vector3 start = Vector3.zero;
        Vector3 end = new Vector3(x, y);
        Debug.DrawLine(start, end, color);

    }
    public void Draw(MyVector newOrigin, Color color)
    {
        Vector3 start = new Vector3(newOrigin.x, newOrigin.y);
        Vector3 end = new Vector3(newOrigin.x + x, newOrigin.y + y);
        Debug.DrawLine(start, end, color);
    }

    public static MyVector operator +(MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y);
    }
    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y);
    }
    public static MyVector operator *(MyVector a, float b)
    {
        return new MyVector(a.x * b, a.y * b);
    }
    public static MyVector operator *(float b, MyVector a)
    {
        return new MyVector(a.x * b, a.y * b);
    }
   
}