using UnityEngine;
using System.Collections;

public class Map03 : IMapData {
	Vector3[] cubePos = new Vector3[]{
        //旋转部分
		new Vector3(1,0,5),
		new Vector3(2,0,5),
		new Vector3(3,0,5),
		new Vector3(4,0,5),
		new Vector3(5,0,5),
		new Vector3(5,0,6),
		new Vector3(5,0,7),
		new Vector3(5,0,8),
		new Vector3(5,0,9),


        new Vector3(3,5,-1),
        new Vector3(3,5,-2),
        new Vector3(5,0,10),
        new Vector3(0,0,5),
        //上面部分
		new Vector3(9,3,5),
        new Vector3(10,3,5),
        new Vector3(10,3,6),
		new Vector3(10,3,7),
		new Vector3(10,3,8),
		new Vector3(10,3,9),
		new Vector3(10,3,10),
		new Vector3(9,3,10),
		new Vector3(8,3,10),
		new Vector3(7,3,10),
		new Vector3(6,3,10),
        new Vector3(5,3,10),
        new Vector3(5,3,9),
        /*
		new Vector3(1,4,6),
		new Vector3(1,4,5),
		new Vector3(1,4,4),
		new Vector3(1,4,3),
		new Vector3(1,4,2),
		new Vector3(1,4,1),
		new Vector3(1,4,0),
		new Vector3(1,4,-1),
		new Vector3(1,4,-2),
		new Vector3(1,4,-3),
		new Vector3(1,4,-4),
        */
        new Vector3(1,4,-4),
        new Vector3(0,4,-4),
		new Vector3(-1,4,-4),
		new Vector3(-2,4,-4),
		new Vector3(-3,4,-4),
		new Vector3(-4,4,-4),
		new Vector3(-4,4,-3),
		new Vector3(-4,4,-2),
		new Vector3(-4,4,-1),
		new Vector3(-4,4,0),
	};
	
	Vector3[] slopePos = new Vector3[]{
	};
	
	Quaternion[] slopeRot = new Quaternion[]{
	};
	
	RotatingObject[] rotObj = new RotatingObject[]{
        new RotatingObject("C205", new Vector3(5,0,5), new Vector3(0,1,0), true),
        new RotatingObject("C305", new Vector3(5,0,5), new Vector3(0,1,0), true),
        new RotatingObject("C405", new Vector3(5,0,5), new Vector3(0,1,0), true),
        new RotatingObject("C505", new Vector3(5,0,5), new Vector3(0,1,0), true),
        new RotatingObject("C506", new Vector3(5,0,5), new Vector3(0,1,0), true),
        new RotatingObject("C507", new Vector3(5,0,5), new Vector3(0,1,0), true),
        new RotatingObject("C508", new Vector3(5,0,5), new Vector3(0,1,0), true),
    };
	
	Vector3 playerStart = new Vector3(5, 0, 10);
    Vector3 gameEnd = new Vector3(5, 4, 9);
    Vector3 movePoint = new Vector3(3,6,-2);

    public Vector3[] CubePos{ get{ return cubePos; } }
	public Vector3[] SlopePos{ get{ return slopePos; } }
	public Quaternion[] SlopeRot{ get{ return slopeRot; } }
	public RotatingObject[] RotObj{ get{ return rotObj; } }
	public Vector3 PlayerStart{ get{ return playerStart; } }
    public Vector3 GameEnd { get { return gameEnd; } }
    public Vector3 MovePoint { get { return movePoint; } }
}
