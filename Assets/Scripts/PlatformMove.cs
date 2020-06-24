using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections;

class PlatformMove:MonoBehaviour
{
    bool entered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player"&&entered==false)
        {
            entered = true;
            Vector3 distance = new Vector3(0, 3, 0);
            var group = RotateController.getInstance().getRotatingGroup(1);
            foreach (Rotating r in group)
            {
                Vector3 target = r.transform.localPosition + distance;
                StartCoroutine(MoveToPosition(r,target));
            }
        }
    }


    IEnumerator MoveToPosition(Rotating r,Vector3 target)
    {
        while (r.transform.localPosition != target)
        {
            r.transform.localPosition = Vector3.MoveTowards(r.transform.localPosition, target, 10 * Time.deltaTime);
            yield return 0;
        }
    }
}

