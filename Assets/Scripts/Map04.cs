using UnityEngine;
using System.Collections;

public class Map04 : IMapData {
	Vector3[] cubePos = new Vector3[]{
        new Vector3(4,7,4),
        new Vector3(3,7,4),
        new Vector3(2,7,4),
        new Vector3(1,7,4),
        new Vector3(0,7,4),
        new Vector3(0,7,3),
        new Vector3(0,7,2),
        new Vector3(0,7,1),
        new Vector3(0,7,0),
        new Vector3(1,7,0),
        new Vector3(2,7,0),
        new Vector3(3,7,0),
        new Vector3(4,7,0),
        new Vector3(4,7,1),
        new Vector3(4,7,2),
        new Vector3(4,7,3),

        

        new Vector3(4,4,-6),
        new Vector3(-5,3,-1),
        new Vector3(-4,3,-1),
        new Vector3(-3,3,-1),
        new Vector3(-2,3,-1),

        new Vector3(-5,3,-2),
        new Vector3(-5,3,-3),
        new Vector3(-5,3,-4),
        new Vector3(-5,3,-5),

        new Vector3(-4,3,-5),
        new Vector3(-3,3,-5),
        new Vector3(-2,3,-5),
        new Vector3(-1,3,-5),

        new Vector3(-1,3,-4),
        new Vector3(-1,3,-3),
        new Vector3(-1,3,-2),

        new Vector3(0,6,0),
        new Vector3(0,5,0),
        new Vector3(0,4,0),
        new Vector3(0,3,0),

        new Vector3(-5,12,-1),
        new Vector3(-5,11,-1),
        new Vector3(-5,10,-1),
        new Vector3(-5,9,-1),
        new Vector3(-5,8,-1),
        new Vector3(-5,7,-1),
        new Vector3(-5,6,-1),
        new Vector3(-5,5,-1),
        new Vector3(-5,4,-1),
       // new Vector3(0,-1,4),

        new Vector3(4,6,0),

        new Vector3(4,7,5),

        new Vector3(4,5,2),
        new Vector3(4,3,1),
        new Vector3(4,2,1),
        
        /*
        //new Vector3(2,0,4),
        new Vector3(1,0,4),
        new Vector3(0,0,4),
        new Vector3(0,0,3),
        new Vector3(0,0,2),
        new Vector3(0,0,1),
        new Vector3(0,0,0),
        new Vector3(1,0,0),
        new Vector3(2,0,0),
        new Vector3(3,0,0),
        new Vector3(4,0,0),
        new Vector3(4,0,1),
        new Vector3(4,0,2),
        new Vector3(4,0,3),*/
    };

    Vector3[] slopePos = new Vector3[]{
        new Vector3(-5,12,-2),
	};
	
	Quaternion[] slopeRot = new Quaternion[]{
		Quaternion.Euler(0,-90,90),
		
	};
	
	RotatingObject[] rotObj = new RotatingObject[]{
        new RotatingObject("C-512-1", new Vector3(-5,12,-1), new Vector3(1,0,0), true),
        new RotatingObject("C374", new Vector3(3,7,4), new Vector3(1,0,0), true),
        new RotatingObject("C-54-1", new Vector3(-5,4,-1), new Vector3(0,1,0), true),
        new RotatingObject("C-53-5", new Vector3(-5,3,-5), new Vector3(0,0,1), true),
    };
	
	Vector3 playerStart = new Vector3(0, 7, 0);
    Vector3 gameEnd = new Vector3(-1, 4, -5);

    public Vector3[] CubePos{ get{ return cubePos; } }
	public Vector3[] SlopePos{ get{ return slopePos; } }
	public Quaternion[] SlopeRot{ get{ return slopeRot; } }
	public RotatingObject[] RotObj{ get{ return rotObj; } }
	public Vector3 PlayerStart{ get{ return playerStart; } }
    public Vector3 GameEnd { get { return gameEnd; } }
}
