//// https://school.programmers.co.kr/learn/courses/30/lessons/42839

//���� ����
//���ڸ� ���ڰ� ���� ���� ������ ������ֽ��ϴ�. ����� ���� ������ �ٿ� �Ҽ��� �� �� ���� �� �ִ��� �˾Ƴ��� �մϴ�.

//�� ���� ������ ���� ���ڰ� ���� ���ڿ� numbers�� �־����� ��, ���� �������� ���� �� �ִ� �Ҽ��� �� ������ return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//numbers�� ���� 1 �̻� 7 ������ ���ڿ��Դϴ�.
//numbers�� 0~9���� ���ڸ����� �̷���� �ֽ��ϴ�.
//"013"�� 0, 1, 3 ���ڰ� ���� ���� ������ ������ִٴ� �ǹ��Դϴ�.
//����� ��
//numbers	return
//"17"	3
//"011"	2
//����� �� ����
//���� #1
//[1, 7]���δ� �Ҽ� [7, 17, 71]�� ���� �� �ֽ��ϴ�.

//���� #2
//[0, 1, 1]���δ� �Ҽ� [11, 101]�� ���� �� �ֽ��ϴ�.

//11�� 011�� ���� ���ڷ� ����մϴ�.���� ����
//���ڸ� ���ڰ� ���� ���� ������ ������ֽ��ϴ�. ����� ���� ������ �ٿ� �Ҽ��� �� �� ���� �� �ִ��� �˾Ƴ��� �մϴ�.

//�� ���� ������ ���� ���ڰ� ���� ���ڿ� numbers�� �־����� ��, ���� �������� ���� �� �ִ� �Ҽ��� �� ������ return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//numbers�� ���� 1 �̻� 7 ������ ���ڿ��Դϴ�.
//numbers�� 0~9���� ���ڸ����� �̷���� �ֽ��ϴ�.
//"013"�� 0, 1, 3 ���ڰ� ���� ���� ������ ������ִٴ� �ǹ��Դϴ�.
//����� ��
//numbers	return
//"17"	3
//"011"	2
//����� �� ����
//���� #1
//[1, 7]���δ� �Ҽ� [7, 17, 71]�� ���� �� �ֽ��ϴ�.

//���� #2
//[0, 1, 1]���δ� �Ҽ� [11, 101]�� ���� �� �ֽ��ϴ�.

//11�� 011�� ���� ���ڷ� ����մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    bool[] bVisit;
    bool[] bPrime;
    List<int> listNumbers = new List<int>();

    public int solution(string numbers)
    {
        int answer = 0;
        bVisit = new bool[numbers.Length];
        bPrime = new bool[(int)Math.Pow(10, numbers.Length)];

        for (int i = 0; i < numbers.Length; i++)
        {
            DFS(numbers, "", i);
        }

        for (int i = 2; i < bPrime.Length; i++)
        {
            if (bPrime[i] == true)
            {
                continue;
            }

            if (listNumbers.Contains(i))
            {
                answer++;
            }

            for (int j = i; j < bPrime.Length; j = j + i)
            {
                bPrime[j] = true;
            }
        }

        return answer;
    }

    public void DFS(string numbers, string str, int index)
    {
        if (numbers.Length == index)
        {
            return;
        }
        if (bVisit[index])
        {
            return;
        }

        str += numbers[index];
        int num = int.Parse(str);

        if (listNumbers.Contains(num) == false)
        {
            listNumbers.Add(num);
        }

        bVisit[index] = true;
        for (int i = 0; i < numbers.Length; i++)
        {
            DFS(numbers, str, i);
        }
        bVisit[index] = false;
    }
}