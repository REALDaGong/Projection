using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MapMaker : MonoBehaviour {
	// Use this for initialization
	void Start () {
        string scene = SceneManager.GetActiveScene().name;
        int id = scene[scene.Length - 1] - 48;
        // Debug.Log(id);
        MapManager.getInstance().Load(id);
    }
}
