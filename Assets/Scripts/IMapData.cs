﻿using UnityEngine;
using System.Collections;

public struct RotatingObject {
	public string name;
	public Vector3 point;
	public Vector3 axis;
	public bool playerRot;
    public int groupId;
	
	public RotatingObject(string name, Vector3 point, Vector3 axis ,bool playerRot = false,int groupId=1) {
		this.name = name;
		this.point = point;
		this.axis = axis;
		this.playerRot = playerRot;
        this.groupId = groupId;
	}
};

public interface IMapData {
	Vector3[] CubePos{ get; }
	Vector3[] SlopePos{ get; }
	Quaternion[] SlopeRot{ get; }
	RotatingObject[] RotObj{ get; }
	Vector3 PlayerStart{ get; }
    Vector3 GameEnd { get; }
}
