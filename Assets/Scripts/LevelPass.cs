using UnityEngine;
using System.Collections;

public class LevelPass:MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            MapManager.getInstance().nextLevel();
        }
    }
}
