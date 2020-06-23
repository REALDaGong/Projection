using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map07 : MonoBehaviour
{
    Vector3[] cubePos = new Vector3[]{

    };

    Vector3[] slopePos = new Vector3[]{
        new Vector3(-3,11,-8),
    };

    Quaternion[] slopeRot = new Quaternion[]{
        Quaternion.Euler(0,0,90),
    };

    RotatingObject[] rotObj = new RotatingObject[]{
        new RotatingObject("C0103", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C0102", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C0101", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C0100", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C090", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C080", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C070", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C060", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C050", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C040", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C030", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C-130", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C-230", new Vector3(0,0,0), new Vector3(0,1,0), true),
        new RotatingObject("C-330", new Vector3(0,0,0), new Vector3(0,1,0), true),
    };

    Vector3 playerStart = new Vector3(0, 3, 7);
    Vector3 gameEnd = new Vector3(0, 0, 0);

    public Vector3[] CubePos { get { return cubePos; } }
    public Vector3[] SlopePos { get { return slopePos; } }
    public Quaternion[] SlopeRot { get { return slopeRot; } }
    public RotatingObject[] RotObj { get { return rotObj; } }
    public Vector3 PlayerStart { get { return playerStart; } }
    public Vector3 GameEnd { get { return gameEnd; } }
}
