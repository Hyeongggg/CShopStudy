using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

/// <summary>
/// �ڷ����� ����ȯ�� ���� ���͵� Ŭ���� �Դϴ�.
/// </summary>


public class DataTypeStudy : MonoBehaviour
{
    //��(Value)�� ����
    //�ڷ���  ������      ��
    bool    isEnable    = false; // 1Byte, True/False�� ��
    int     number      = 100; // 4Byte(32bit), ������ �ڷ��� �ִ� 0~4, 294, 967, 295 or -2, 147, 483, 648~2, 147, 483, 647
    uint    numberUInt  = 4294967285; // 4Byte(32bit), ��ȣ�� ���� ������ �ڷ���, �ִ� 0~4, 294, 967, 295
    float   number2     = 35.3f; // 4Byte, �Ǽ��� �ڷ���
    double  number3     = 35.5; // 8Byte(64bit), �Ǽ��� �ڷ���
    char    data        = 'c'; // 1Byte, 1���� ���ڸ� �����ϴ� �ڷ���
    string  name        = "Hyeongmin"; // ���ڿ�, ������ ũ�⿡ ���� ũ�Ⱑ ���ϴ� �ڷ���

    int number4; // ���� �Ҵ����� ������ �ڵ����� 0���� �ʱ�ȭ

    const int age = 20; // ���: �б�����, runtime�� ���� �������� ���� 

    // Start is called before the first frame update
    void Start()
    {
        print(isEnable);
        print(typeof(bool));
        print(number4);

        // age = 60; // ����� runtime�� ���� �������� ����

// ����ȯ = Type Casting
        int myInt = 10;
        double myDouble = 55.4;

// ���1. �Ͻ���, ����� ����ȯ
        myDouble = myInt;           // �Ͻ��� ����ȯ
        // myInt = myDouble;        // �Ͻ��� ����ȯ �Ұ�: myDouble�� ũ�Ⱑ �� ũ�� ������
        myInt = (int)myDouble;      // ����� ����ȯ: ũ�Ⱑ ū ������ ũ�Ⱑ ���� ������ ��ȯ

// ���2. ����ȯ ���� �޼���
        myInt.ToString();       // int�� ���� -> string�� ������ ��ȯ
        string age = "30";
        age.ToIntArray();       // string -> int�� �迭�� ��ȯ
        int.Parse(age);         // string -> int������ ��ȯ
        print(int.MaxValue);    // int�� �ִ밪
        float.Parse(age);       // string -> float������ ��ȯ
        double.Parse(age);      // string -> double������ ��ȯ
        bool.Parse(age);        // string -> bool������ ��ȯ
    }
}
