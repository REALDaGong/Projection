using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Orthographic
// 将物体移至平面
public class Projector : MonoBehaviour
{
    private Vector3 oriPos;
    private Quaternion oriDir;
    [SerializeField]
    private GameObject projectionPlane;
    [SerializeField]
    private GameObject perspectiveOrigin;
    [SerializeField]
    private bool isOrthographic = false;
    private Vector3 oriScale;
    private ObjectManager planeEventHandler;
    // Start is called before the first frame update
    void Start()
    {
        oriPos = transform.position;
        oriDir = transform.rotation;
        oriScale = transform.localScale;
        MakeProjection();
        planeEventHandler = ObjectManager.Instance;
        planeEventHandler.RegisterObject(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeProjection()
    {
        if(projectionPlane != null)
        {
            var planePos = projectionPlane.transform.position;
            var goDir = - GetNormal(); //平面初始化时法向量是正y
            var d = - Vector3.Dot(goDir,planePos);
            var dis = Mathf.Abs(d + Vector3.Dot(goDir, oriPos))/goDir.sqrMagnitude;
            transform.position += dis * goDir;
            if (!isOrthographic) //目前没实装
            {
                if (perspectiveOrigin != null)
                {
                    var perPos = perspectiveOrigin.transform.position;
                    var perDis = Mathf.Abs(d + Vector3.Dot(goDir, perPos)) / goDir.sqrMagnitude;
                    transform.localScale = perDis / (perDis - dis) * transform.localScale;
                }
            }
        }
    }
    public Vector3 GetNormal()
    {
        return projectionPlane.transform.rotation * new Vector3(0, 1.0f, 0);
    }

    public void Reset()
    {
        if (!isOrthographic)
        {
            if (perspectiveOrigin != null)
            {
                transform.localScale = oriScale;
            }
        }
        transform.position = oriPos;
        transform.rotation = oriDir;
    }
}
