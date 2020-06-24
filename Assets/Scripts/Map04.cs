using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map04 : IMapData
{
    Vector3[] cubePos = new Vector3[]{
        new Vector3(0,0,0),
        new Vector3(0,0,1),

        new Vector3(1,1,3),
        new Vector3(1,1,4),

        new Vector3(0,0,6),
        new Vector3(0,0,7),

        new Vector3(1,1,11),
        new Vector3(2,1,11),
        new Vector3(3,1,11),
        new Vector3(4,1,11),
        //new Vector3(5,1,11),

        new Vector3(9,4,11), // 左梯子部分

        new Vector3(9,1,7),
        new Vector3(10,1,7),
        new Vector3(11,1,7),
        new Vector3(12,1,7),

        new Vector3(13,-6,3),
        new Vector3(12,-6,3),
        new Vector3(11,-6,3),
        new Vector3(10,-6,3),
        new Vector3(9,-6,3),
        new Vector3(8,-6,3),
        new Vector3(7,-6,3),
        new Vector3(6,-6,3),
        new Vector3(5,-6,3),
        new Vector3(4,-6,3), // 终点

        new Vector3(9,-6,0),
        new Vector3(9,-6,1),
        new Vector3(9,-6,-1),

        // 一些多余砖块
        new Vector3(9,-6,-2),
        new Vector3(9,-6,-3),
        new Vector3(9,-6,-4),
        new Vector3(9,-6,-5),
        new Vector3(9,-6,-6),
        new Vector3(9,-6,-7),
        new Vector3(13,1,7),
        new Vector3(14,1,7),
        new Vector3(15,1,7),
        new Vector3(16,1,7),
        new Vector3(17,1,7),
        new Vector3(18,1,7),
        new Vector3(9,10,-3),
    };

    Vector3[] slopePos = new Vector3[]{
        new Vector3(1,1,10),
        new Vector3(1,0,9),
        new Vector3(1,0,10),
        new Vector3(1,-1,9),

        new Vector3(9,2,8), // 左梯子部分
        new Vector3(9,3,9),
        new Vector3(9,4,10),
        new Vector3(9,1,8),
        new Vector3(9,2,9),
        new Vector3(9,3,10),

        new Vector3(10,5,11), // 左梯子部分
        new Vector3(11,6,11),
        new Vector3(12,7,11),
        new Vector3(10,4,11),
        new Vector3(11,5,11),
        new Vector3(12,6,11),

        new Vector3(12,-4,2),
        new Vector3(12,-3,3),
        new Vector3(12,-2,4), // 右梯子部分
        new Vector3(12,-1,5),
        new Vector3(12,-0,6),
        new Vector3(12,-4,3),
        new Vector3(12,-3,4),
        new Vector3(12,-2,5),
        new Vector3(12,-1,6),
        new Vector3(12,0,7),
    };

    Quaternion[] slopeRot = new Quaternion[]{
        Quaternion.Euler(0,270,0),
        Quaternion.Euler(0,270,0),
        Quaternion.Euler(0,270,180),
        Quaternion.Euler(0,270,180),

        Quaternion.Euler(0,270,0), // 左梯子部分 
        Quaternion.Euler(0,270,0),
        Quaternion.Euler(0,270,0),
        Quaternion.Euler(0,270,180),
        Quaternion.Euler(0,270,180),
        Quaternion.Euler(0,270,180),

        Quaternion.Euler(0,0,0), // 左梯子部分
        Quaternion.Euler(0,0,0),
        Quaternion.Euler(0,0,0),
        Quaternion.Euler(0,0,180),
        Quaternion.Euler(0,0,180),
        Quaternion.Euler(0,0,180),

        Quaternion.Euler(0,270,0), // 右梯子部分
        Quaternion.Euler(0,270,0),
        Quaternion.Euler(0,270,0),
        Quaternion.Euler(0,270,0),
        Quaternion.Euler(0,270,0),
        Quaternion.Euler(0,270,180),
        Quaternion.Euler(0,270,180),
        Quaternion.Euler(0,270,180),
        Quaternion.Euler(0,270,180),
        Quaternion.Euler(0,270,180),
    };

    RotatingObject[] rotObj = new RotatingObject[]{
        new RotatingObject("C000", new Vector3(3,1,3), new Vector3(0,1,0), true, 1),
        new RotatingObject("C001", new Vector3(3,1,3), new Vector3(0,1,0), true, 1),
        new RotatingObject("C113", new Vector3(3,1,3), new Vector3(0,1,0), true, 1),
        new RotatingObject("C114", new Vector3(3,1,3), new Vector3(0,1,0), true, 1),
        new RotatingObject("C006", new Vector3(3,1,3), new Vector3(0,1,0), true, 1),
        new RotatingObject("C007", new Vector3(3,1,3), new Vector3(0,1,0), true, 1),

        new RotatingObject("C1111", new Vector3(3,1,11), new Vector3(0,1,0), true, 2),
        new RotatingObject("C2111", new Vector3(3,1,11), new Vector3(0,1,0), true, 2),
        new RotatingObject("C3111", new Vector3(3,1,11), new Vector3(0,1,0), true, 2),
        new RotatingObject("C4111", new Vector3(3,1,11), new Vector3(0,1,0), true, 2),

        // 旋转梯子
        new RotatingObject("S928", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S939", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S9410", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S918", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S929", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S9310", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("C9411", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S10511", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S11611", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S12711", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S10411", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S11511", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),
        new RotatingObject("S12611", new Vector3(9,4,11), new Vector3(0,0,1), true, 3),


        new RotatingObject("C1017", new Vector3(11,1,7), new Vector3(1,0,0), true, 4),
        new RotatingObject("C1117", new Vector3(11,1,7), new Vector3(1,0,0), true, 4),

        // 终点部分
        new RotatingObject("C8-63", new Vector3(9,0,3), new Vector3(0,1,0), true, 5),
        new RotatingObject("C9-63", new Vector3(9,0,3), new Vector3(0,1,0), true, 5),
        new RotatingObject("C10-63", new Vector3(9,0,3), new Vector3(0,1,0), true, 5),

        new RotatingObject("C9-61", new Vector3(9,-6,0), new Vector3(0,0,1), true, 6),
        new RotatingObject("C9-60", new Vector3(9,-6,0), new Vector3(0,0,1), true, 6),
    };

    Vector3 playerStart = new Vector3(0, 0, 0);
    Vector3 gameEnd = new Vector3(4, -5, 3);

    public Vector3[] CubePos { get { return cubePos; } }
    public Vector3[] SlopePos { get { return slopePos; } }
    public Quaternion[] SlopeRot { get { return slopeRot; } }
    public RotatingObject[] RotObj { get { return rotObj; } }
    public Vector3 PlayerStart { get { return playerStart; } }
    public Vector3 GameEnd { get { return gameEnd; } }

}
