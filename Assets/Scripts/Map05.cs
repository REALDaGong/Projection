using UnityEngine;
using System.Collections;

public class Map05 : IMapData
{
    Vector3[] cubePos = new Vector3[]{
        new Vector3(-1,0,0),
        new Vector3(-1,1,0),
        new Vector3(-1,2,0),
        new Vector3(-1,3,0),

        new Vector3(0,0,5),
        new Vector3(0,1,5),
        new Vector3(0,2,5),
        new Vector3(0,3,5),
        new Vector3(0,4,5),
        new Vector3(0,5,5),
        new Vector3(0,6,5),
        new Vector3(0,7,5),

        new Vector3(-3,0,3),
        new Vector3(-3,1,3),

        new Vector3(2,0,2),
        new Vector3(2,1,2),
        new Vector3(2,2,2),
        new Vector3(2,3,2),
        new Vector3(2,4,2),
        new Vector3(2,5,2),

        new Vector3(5,7,1),
        new Vector3(5,7,2),
        new Vector3(5,7,3),
        new Vector3(5,7,4),
        new Vector3(5,7,5),

        new Vector3(5,7,6), //拐角
        new Vector3(5,7,7),
        new Vector3(6,7,7),
    };

    Vector3[] slopePos = new Vector3[]{

    };

    Quaternion[] slopeRot = new Quaternion[]{
        Quaternion.Euler(0,270,0),
    };

    RotatingObject[] rotObj = new RotatingObject[]{
        new RotatingObject("C-303", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C-313", new Vector3(0,0,3), new Vector3(0,1,0), true),

        new RotatingObject("C-100", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C-110", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C-120", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C-130", new Vector3(0,0,3), new Vector3(0,1,0), true),

        new RotatingObject("C202", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C212", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C222", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C232", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C242", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C252", new Vector3(0,0,3), new Vector3(0,1,0), true),

        new RotatingObject("C005", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C015", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C025", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C035", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C045", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C055", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C065", new Vector3(0,0,3), new Vector3(0,1,0), true),
        new RotatingObject("C075", new Vector3(0,0,3), new Vector3(0,1,0), true),

        new RotatingObject("C571", new Vector3(5,7,3), new Vector3(0,1,0), true, 2),
        new RotatingObject("C572", new Vector3(5,7,3), new Vector3(0,1,0), true, 2),
        new RotatingObject("C573", new Vector3(5,7,3), new Vector3(0,1,0), true, 2),
        new RotatingObject("C574", new Vector3(5,7,3), new Vector3(0,1,0), true, 2),
        new RotatingObject("C575", new Vector3(5,7,3), new Vector3(0,1,0), true, 2),

        new RotatingObject("C576", new Vector3(5,7,6), new Vector3(0,0,1), true, 3),
        new RotatingObject("C577", new Vector3(5,7,6), new Vector3(0,0,1), true, 3),
        new RotatingObject("C677", new Vector3(5,7,6), new Vector3(0,0,1), true, 3),
    };

    Vector3 playerStart = new Vector3(-3, 1, 3);
    Vector3 gameEnd = new Vector3(-3, 0, 4);

    public Vector3[] CubePos { get { return cubePos; } }
    public Vector3[] SlopePos { get { return slopePos; } }
    public Quaternion[] SlopeRot { get { return slopeRot; } }
    public RotatingObject[] RotObj { get { return rotObj; } }
    public Vector3 PlayerStart { get { return playerStart; } }
    public Vector3 GameEnd { get { return gameEnd; } }
}
