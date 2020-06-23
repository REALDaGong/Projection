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
            RotateController.getInstance().selectNext();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RotateController.getInstance().selectPre();
        }
    }
}

