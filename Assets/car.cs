using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition; // 點擊滑鼠時的座標
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;  // 放開滑鼠時的座標
            float swipeLength = endPos.x - this.startPos.x;
            this.speed = swipeLength / 500.0f;  // 把滑動長度轉換成初始移動速度
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);  //移動
        this.speed *= 0.91f;                    //減速
    }
}
