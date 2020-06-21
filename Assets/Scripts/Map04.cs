using UnityEngine;
using System.Collections;

public class Map04 : IMapData {
	Vector3[] cubePos = new Vector3[]{
		new Vector3(3,0,10),
		new Vector3(3,0,9),
		new Vector3(3,0,8),
		new Vector3(3,0,7),
		new Vector3(3,0,6),
		new Vector3(3,0,5),
		new Vector3(3,0,4),
		new Vector3(3,0,3),

		new Vector3(7,3,3),

		new Vector3(7,6,7),
		new Vector3(6,6,7),
		new Vector3(5,6,7),
		new Vector3(4,6,7),
		new Vector3(3,6,7),
		new Vector3(2,6,7),
		new Vector3(1,6,7),
		new Vector3(0,6,7),
		new Vector3(-1,6,7),
		new Vector3(-2,6,7),
		new Vector3(-3,6,7),
		new Vector3(-3,6,6),
		new Vector3(-3,6,5),
	};
	
	Vector3[] slopePos = new Vector3[]{
		new Vector3(4,1,3),
		new Vector3(5,2,3),
		new Vector3(6,3,3),

		new Vector3(4,0,3),
		new Vector3(5,1,3),
		new Vector3(6,2,3),

        new Vector3(-3,6,4),

        /*
		new Vector3(7,4,4),
		new Vector3(7,5,5),
		new Vector3(7,6,6),

		new Vector3(7,3,4),
		new Vector3(7,4,5),
		new Vector3(7,5,6),

		new Vector3(-3,6,4),
        */
	};
	
	Quaternion[] slopeRot = new Quaternion[]{
		Quaternion.Euler(0,0,0),
		Quaternion.Euler(0,0,0),
		Quaternion.Euler(0,0,0),

		Quaternion.Euler(0,0,180),
		Quaternion.Euler(0,0,180),
		Quaternion.Euler(0,0,180),

        Quaternion.Euler(0,270,90),

        /*
		Quaternion.Euler(0,270,0),
		Quaternion.Euler(0,270,0),
		Quaternion.Euler(0,270,0),

		Quaternion.Euler(0,270,180),
		Quaternion.Euler(0,270,180),
		Quaternion.Euler(0,270,180),

		Quaternion.Euler(0,270,90),
        */
	};
	
	RotatingObject[] rotObj = new RotatingObject[]{
        new RotatingObject("C309", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C308", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C307", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C306", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C305", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C304", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C303", new Vector3(5,2,5), new Vector3(0,1,0), true),

        new RotatingObject("C733", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C667", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C567", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C467", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C367", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C267", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C167", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C067", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C-167", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C-267", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C-367", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C-366", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C-365", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("C3010", new Vector3(5,2,5), new Vector3(0,1,0), true),


        new RotatingObject("S413", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("S523", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("S633", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("S403", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("S513", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("S623", new Vector3(5,2,5), new Vector3(0,1,0), true),
        new RotatingObject("S-364", new Vector3(5,2,5), new Vector3(0,1,0), true),


    };
	
	Vector3 playerStart = new Vector3(3, 0, 3);
    Vector3 gameEnd = new Vector3(0, 0, 0);

    public Vector3[] CubePos{ get{ return cubePos; } }
	public Vector3[] SlopePos{ get{ return slopePos; } }
	public Quaternion[] SlopeRot{ get{ return slopeRot; } }
	public RotatingObject[] RotObj{ get{ return rotObj; } }
	public Vector3 PlayerStart{ get{ return playerStart; } }
    public Vector3 GameEnd { get { return gameEnd; } }
}
