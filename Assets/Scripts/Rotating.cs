using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {

	bool rotating = false;
	float m_Angle = 0;
	public Vector3 point;
	public Vector3 axis;
	bool playerRot = false;

    bool selected = false;

    public void changeSelect(bool select)
    {
        this.selected = select;
    }

	public bool PlayerRot {
		set {
			playerRot = value;
			//renderer.material.color = new Color(0.75f, 0.75f, (playerRot ? 1 : 0.75f));
		}
	}


    // Change the material color of rotatable part
	void Start () {
        GetComponent<Renderer>().material.color = Color.grey;
	}


    void Update()
    {
        if (selected)
        {
            GetComponent<Renderer>().material.color = Color.cyan;

            float angle = 0;
            bool player_stand;
            bool player_stand_this;

            GameObject player = GameObject.Find("Player");
            MoveCharacter script = player.GetComponent("MoveCharacter") as MoveCharacter;
            player_stand = (script.StandingFloor.GetComponent("Rotating") != null);
            player_stand_this = (script.StandingFloor == gameObject);

            if (!playerRot && player_stand) return;

            if (Input.GetKey(KeyCode.Q))
                angle = -Time.deltaTime * 128;
            else if (Input.GetKey(KeyCode.W))
                angle = Time.deltaTime * 128;
            else
            {
                // 修正旋转的位置
                float dst = Mathf.Floor((m_Angle + 45) / 90) * 90;
                angle = dst - m_Angle;
                if (Mathf.Abs(angle) > 1) angle *= 0.125f;
                if (rotating && angle == 0)
                {
                    rotating = false;
                    Vector3 pos = transform.position;
                    transform.position = new Vector3(Mathf.Round(pos.x), Mathf.Round(pos.y), Mathf.Round(pos.z));
                    if (player_stand_this)
                    {
                        script.RecalcPlayerPos();
                    }
                }
            }

            m_Angle += angle;
            while (m_Angle > 360)
                m_Angle -= 360;
            while (m_Angle < 0)
                m_Angle += 360;


            // 判断玩家位置是否重叠(还没实现)


            transform.RotateAround(point, axis, angle);

            if (angle != 0)
            {
                rotating = true;

                script.StopMoving();
                if (!player_stand)
                    script.RecalcPlayerPos();

                if (player_stand_this)
                {
                    player.transform.RotateAround(point, axis, angle);
                }
            }
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.grey;
        }
    }
}
