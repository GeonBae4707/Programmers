//���� ����
//boolean ���� x1, x2, x3, x4�� �Ű������� �־��� ��, ������ ���� true/false�� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//(x1 �� x2) �� (x3 �� x4)
//����� ��
//x1	x2	x3	x4	result
//false	true	true	true	true
//true	false	false	false	false
//����� �� ����
//����� �� #1

//���� 1���� x1, x2, x3, x4�� ���� ����ϸ� ������ �����ϴ�.

//(x1 �� x2) �� (x3 �� x4) �� (F �� T) �� (T �� T) �� T �� T �� T

//���� true�� return �մϴ�.

//����� �� #2

//���� 2���� x1, x2, x3, x4�� ���� ����ϸ� ������ �����ϴ�.

//(x1 �� x2) �� (x3 �� x4) �� (T �� F) �� (F �� F) �� T �� F �� F

//���� false�� return �մϴ�.

//���� ���� ����ǥ�� ������ �����ϴ�.

//x	y	x �� y	x �� y
//T	T	T	T
//T	F	T	F
//F	T	T	F
//F	F	F	F

using System;

public class Solution
{
    public bool solution(bool x1, bool x2, bool x3, bool x4)
    {
        bool b1 = false;
        bool b2 = false;

        if (x1 == true || x2 == true)
        {
            b1 = true;
        }
        else
        {
            b1 = false;
        }

        if (x3 == true || x4 == true)
        {
            b2 = true;
        }
        else
        {
            b2 = false;
        }

        if (b1 == true && b2 == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}