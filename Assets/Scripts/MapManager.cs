using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MapManager
{
    private static MapManager _instance = null;
    private int id = 0;
    private int maxLevel = 6;
    private MapManager()
    {
        string scene = SceneManager.GetActiveScene().name;
        id = scene[scene.Length - 1] - 48;
    }
    public static MapManager getInstance()
    {
        if (_instance == null)
        {
            _instance = new MapManager();
        }
        return _instance;
    }

    private Vector3[] slopeVertices = new Vector3[]{
        // To create a slope with 5 surfaces
		new Vector3(-0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, -0.5f, 0.5f),
        new Vector3(-0.5f, -0.5f, 0.5f),

        new Vector3(-0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, 0.5f, -0.5f),

        new Vector3(0.5f, -0.5f, 0.5f),
        new Vector3(-0.5f, -0.5f, 0.5f),
        new Vector3(0.5f, 0.5f, 0.5f),

        new Vector3(-0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, 0.5f, -0.5f),
        new Vector3(0.5f, 0.5f, 0.5f),
        new Vector3(-0.5f, -0.5f, 0.5f),

        new Vector3(0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, -0.5f, 0.5f),
        new Vector3(0.5f, 0.5f, 0.5f),
        new Vector3(0.5f, 0.5f, -0.5f),
    };

    private int[] slopeTriangles = new int[]{
        // Index array
		0, 1, 2,
        0, 2, 3,
        4, 6, 5,
        8, 7, 9,
        10, 12, 11,
        10, 13, 12,
        14, 17, 15,
        15, 17, 16,
    };

    private GameObject makeSlope()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "Slope";

        Mesh mesh = obj.GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = slopeVertices;
        mesh.triangles = slopeTriangles;
        mesh.RecalculateNormals();

        return obj;
    }

    private void MakeMap(IMapData mapData)
    {

        GameObject[] floor = GameObject.FindGameObjectsWithTag("Floor");
        foreach (GameObject obj in floor)
            GameObject.Destroy(obj);
        GameObject[] end = GameObject.FindGameObjectsWithTag("Endpoint");
        foreach (GameObject obj in end)
            GameObject.Destroy(obj);


        foreach (Vector3 pos in mapData.CubePos)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.tag = "Floor";
            cube.name = "C" + pos.x + pos.y + pos.z;    // 'C'ube
            cube.transform.position = pos;
        }
        for (int i = 0; i < mapData.SlopePos.Length; i++)
        {
            GameObject slope = makeSlope();
            Vector3 pos = mapData.SlopePos[i];
            slope.tag = "Floor";
            slope.name = "S" + pos.x + pos.y + pos.z;   // 'S'lope
            slope.transform.position = pos;
            slope.transform.rotation = mapData.SlopeRot[i];
        }
        foreach (RotatingObject data in mapData.RotObj)
        {
            GameObject obj = GameObject.Find(data.name);
            if (obj == null) continue;
            Rotating script = obj.AddComponent<Rotating>() as Rotating;
            script.point = data.point;
            script.axis = data.axis;
            script.PlayerRot = data.playerRot;
        }
        {
            GameObject player = GameObject.Find("Player");
            player.transform.position = new Vector3(mapData.PlayerStart.x, mapData.PlayerStart.y + 1, mapData.PlayerStart.z); //
            player.GetComponent<MoveCharacter>().Init();
        }
        //关卡终点
        {
            GameObject endpoint = (GameObject)Resources.Load("Prefabs/endpoint");
            endpoint.transform.position = mapData.GameEnd;
            Object.Instantiate(endpoint);
        }
    }

    public void Load(int stage_id)
    {
        switch (stage_id)
        {
            case 1:
                MakeMap(new Map01());
                break;
            case 2:
                MakeMap(new Map02());
                break;
            case 3:
                MakeMap(new Map03());
                break;
            case 4:
                MakeMap(new Map04());
                break;
            case 5:
                MakeMap(new Map05());
                break;
            case 6:
                MakeMap(new Map06());
                break;
        }
    }

    public void nextLevel()
    {
        PlayerPrefs.SetInt("Level" + id.ToString(), 1);
        if (id == maxLevel)
        {
            Debug.Log("这已经是最后一关啦！");
            return;
        }
        else
        {
            string nextscene = "Map0" + ++id;
            GameObject.Find("LevelLoader").GetComponent<LevelLoader>().SwitchScene(nextscene);
        }
    }
}
