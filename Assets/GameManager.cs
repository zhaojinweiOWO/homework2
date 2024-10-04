using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // �ϥ� UI ����A�����W�[���B�z�{��

public class GameManager : MonoBehaviour
{
    GameObject car;              // �Ψ��x�s�T������
    GameObject flag;             // �Ψ��x�s�X�l����
    GameObject distance;         // �Ψ��x�sUI��r����

    void Start() // �N��������������w�ŧi���U�Ӫ���
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }

    void Update()
    {
        // �p��X�l�P�T�����Z��
        float length = flag.transform.position.x - car.transform.position.x;
        // �N�X�l�P�T�����Z����ܦbUI�W��
        distance.GetComponent<Text>().text = "�Z���ؼ��٦� " + length.ToString("F2") + "m";
    }
}