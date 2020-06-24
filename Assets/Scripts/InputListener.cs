using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
class InputListener : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(!(Input.GetKey(KeyCode.Q)|| Input.GetKey(KeyCode.W)))
            {
                  RotateController.getInstance().selectNext();
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.W)))
            {
                RotateController.getInstance().selectPre();
            }
        }
    }
}

