using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {
    public void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(onClick);
    }

    public void onClick()
    {
        SceneManager.LoadScene("Test");
    }
}
