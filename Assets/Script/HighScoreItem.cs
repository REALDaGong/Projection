using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

namespace MoleMole
{
	public class HighScoreItem : MonoBehaviour {
        private int scene_num;

	    public void Init(int index)
        {
            transform.Find("Text").GetComponent<Text>().text = "Level " + (index+1).ToString();
            Image image = this.GetComponent<Image>();
            scene_num = index + 1;
            this.GetComponent<Button>().onClick.AddListener(Onclick);
            if(PlayerPrefs.GetInt("Level"+scene_num.ToString())==1)
            {
                image.sprite = Resources.Load("Image/Passed", typeof(Sprite)) as Sprite;
            }
        }

        public void Onclick()
        {
            GameObject.Find("LevelLoader").GetComponent<LevelLoader>().SwitchScene("Map0"+scene_num.ToString());
        }
    }
}
