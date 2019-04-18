using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    float MoveSpeed = 0.1f;

    public List<Vector3> Player_Histry = new List<Vector3>();
    int Capa =10;

    ~PlayerController()
    {
        // 配列削除
        Player_Histry.Clear();
    }

	// Use this for initialization
	void Start () {

       // えんどうまもる


        for(int i=0;i<Capa;i++)
        {
            // 10こつくる
            Player_Histry.Add(new Vector3(0.0f, 0.0f, 0.0f));
        }

	}
	
	// Update is called once per frame
	void Update () {

        // 一番後ろの要素を削除
        Player_Histry.RemoveAt(Capa - 1);

        // 先頭に今の座標を入れる
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        Player_Histry.Insert(0, new Vector3(x,y,z));
          
        // 上
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0.0f,MoveSpeed,0.0f);
        }
        // 下
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.0f, -MoveSpeed, 0.0f);
        }
        // 左
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-MoveSpeed, 0.0f, 0.0f);
        }
        // 右
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(MoveSpeed, 0.0f, 0.0f);
        }
    }

    public Vector3 Get_PlayerHistry(int No)
    {
        Vector3 Vec = new Vector3(0.0f, 0.0f, 0.0f);
        for (int i = 0; i < Player_Histry.Count; ++i)
        {
            if(No==i)
            {
                Vec = Player_Histry[No];
                return Vec;
            }
        }

        return Vec;
    }
}
