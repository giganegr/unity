using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    //ghgk
    //��� ������ �������� ����������
    int number1,number2;
    float num = 4555555f;
    //float -������������ �����, ���������� �����
    //string - ��� ������, �����
    //char - ��� ���� ������
    // bool- ��� ��� �������� true ��� false
    //double- ��� ������������ �����, ���������� ����� ������ � ���� ������ �������� ��� float
    //int - ������������� ��� ������
    //number - �������� ���������� ��� ����� ��������� �����
    void Start()
    {
        number1 = 5;
        number2 = 4;
        Debug.Log(number1+number2);
        print("function Start");
        
    }
    //x+5=0
    //x=-5
    // Update is called once per frame
    void Update()
    {
        Debug.Log("fucntion update");
    }
}
