//// https://school.programmers.co.kr/learn/courses/30/lessons/120887

//���� ����
//1���� 13������ ������, 1�� 1, 10, 11, 12, 13 �̷��� �� 6�� �����մϴ�. ���� i, j, k�� �Ű������� �־��� ��, i���� j���� k�� �� �� �����ϴ��� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� i < j �� 100,000
//0 �� k �� 9
//����� ��
//i	j	k	result
//1	13	1	6
//10	50	5	5
//3	10	2	0
//����� �� ����
//����� �� #1

//������ �����մϴ�.
//����� �� #2

//10���� 50���� 5�� 15, 25, 35, 45, 50 �� 5�� �����մϴ�. ���� 5�� return �մϴ�.
//����� �� #3

//3���� 10���� 2�� �� ���� �������� �����Ƿ� 0�� return �մϴ�.

using System;

public class Solution
{
    public int solution(int i, int j, int k)
    {
        int answer = 0;
        for (int x = i; x <= j; x++)
        {
            string str = x.ToString();
            for (int y = 0; y < str.Length; y++)
            {
                if (str[y] == k.ToString()[0])
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}