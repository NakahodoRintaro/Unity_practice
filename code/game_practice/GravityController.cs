using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 重力加速度
        const float Gravity = 9.81f;

        // 重力の適合具合
        public float gravityScale = 1.0f;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3();

        // キーの入力を検知してベクトルを設定
        vector.x = Input.GetAxis("Horizontal");
        vector.z = Input.GetAxis("Vertical");

        // 高さ方向の判定はキーのzとする
        if (Input.GetKey("z"))
        {
          vector.y = 1.0f;
        }
        else
        {
          vector.y = -1.0f;
        }

        // シーンを重力を入力ベクトルの方向に合わせて変化させる
        Physics.gravity = Gravity * vector.normalized * gravityScale;
    }
}
