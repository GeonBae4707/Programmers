//// https://school.programmers.co.kr/learn/courses/30/lessons/120885

//���� ����
//�������� �ǹ��ϴ� �� ���� ���ڿ� bin1�� bin2�� �Ű������� �־��� ��, �� �������� ���� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//return ���� �������� �ǹ��ϴ� ���ڿ��Դϴ�.
//1 �� bin1, bin2�� ���� �� 10
//bin1�� bin2�� 0�� 1�θ� �̷���� �ֽ��ϴ�.
//bin1�� bin2�� "0"�� �����ϰ� 0���� �������� �ʽ��ϴ�.
//����� ��
//bin1	bin2	result
//"10"	"11"	"101"
//"1001"	"1111"	"11000"
//����� �� ����
//����� �� #1

//10 + 11 = 101 �̹Ƿ� "101" �� return�մϴ�.
//����� �� #2

//1001 + 1111 = 11000 �̹Ƿ� "11000"�� return�մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string bin1, string bin2)
    {
        List<int> list = new List<int>();
        int temp = 0;
        string answer = "";

        for (int i = 0; i < Math.Max(bin1.Length, bin2.Length); i++)
        {
            int a = 0;
            int b = 0;
            if (i < bin1.Length)
            {
                a = bin1[bin1.Length - 1 - i] - '0';
            }
            if (i < bin2.Length)
            {
                b = bin2[bin2.Length - 1 - i] - '0';
            }
            int c = temp + a + b;
            if (c >= 2)
            {
                temp = 1;
                c -= 2;
            }
            else
            {
                temp = 0;
            }
            list.Add(c);
        }

        if (temp == 1)
        {
            list.Add(1);
        }

        for (int i = list.Count - 1; i >= 0; i--)
        {
            answer += list[i];
        }

        return answer;
    }
}