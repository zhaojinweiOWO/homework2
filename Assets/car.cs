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
            this.startPos = Input.mousePosition; // �I���ƹ��ɪ��y��
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;  // ��}�ƹ��ɪ��y��
            float swipeLength = endPos.x - this.startPos.x;
            this.speed = swipeLength / 500.0f;  // ��ưʪ����ഫ����l���ʳt��
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);  //����
        this.speed *= 0.91f;                    //��t
    }
}
