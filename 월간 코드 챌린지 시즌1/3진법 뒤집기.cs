//// https://school.programmers.co.kr/learn/courses/30/lessons/68935

//���� ����
//�ڿ��� n�� �Ű������� �־����ϴ�. n�� 3���� �󿡼� �յڷ� ������ ��, �̸� �ٽ� 10�������� ǥ���� ���� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//n�� 1 �̻� 100,000,000 ������ �ڿ����Դϴ�.
//����� ��
//n	result
//45	7
//125	229
//����� �� ����
//����� �� #1

//���� �����ϴ� ������ ������ �����ϴ�.
//n (10����)	n (3����)	�յ� ����(3����)	10�������� ǥ��
//45	1200	0021	7
//���� 7�� return �ؾ� �մϴ�.
//����� �� #2

//���� �����ϴ� ������ ������ �����ϴ�.
//n (10����)	n (3����)	�յ� ����(3����)	10�������� ǥ��
//125	11122	22111	229
//���� 229�� return �ؾ� �մϴ�.


using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        string tri = "";

        while (n > 0)
        {
            tri += n % 3;
            n /= 3;
        }

        for (int i = 0; i < tri.Length; i++)
        {
            answer += (int)(int.Parse(tri[i].ToString()) * Math.Pow(3, tri.Length - i - 1));
        }

        return answer;
    }
}