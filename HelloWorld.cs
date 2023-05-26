using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    //ghgk
    //тип данных название переменной
    int number1,number2;
    float num = 4555555f;
    //float -вещественные числа, десятичные числа
    //string - это строка, текст
    //char - это один символ
    // bool- это два значения true или false
    //double- это вещественные числа, десятичные числа хранит в себе больше значений чем float
    //int - целочисленный тип данных
    //number - название переменной где можем сохранить число
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
