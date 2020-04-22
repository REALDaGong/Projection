using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public static ObjectManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ObjectManager>();
                if (instance == null)
                {
                    instance = new GameObject(" ObjectManager").AddComponent<ObjectManager>();
                }
            }
            return instance;
        }
    }

    private static ObjectManager instance;
    // Start is called before the first frame update
    private List<Projector> gameObjectScripts = new List<Projector>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReCalcObject()
    {
        foreach(var instance in gameObjectScripts)
        {
            instance.Reset();
            instance.MakeProjection();
        }
    }

    public void ResetObjectPlace()
    {
        foreach (var instance in gameObjectScripts)
        {
            instance.Reset();
        }
    }

    public void RegisterObject(Projector projector)
    {
        gameObjectScripts.Add(projector);
    }
}
