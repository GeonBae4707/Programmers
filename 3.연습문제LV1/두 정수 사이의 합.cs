//// https://school.programmers.co.kr/learn/courses/30/lessons/12912

//���� ����
//�� ���� a, b�� �־����� �� a�� b ���̿� ���� ��� ������ ���� �����ϴ� �Լ�, solution�� �ϼ��ϼ���.
//���� ��� a = 3, b = 5�� ���, 3 + 4 + 5 = 12�̹Ƿ� 12�� �����մϴ�.

//���� ����
//a�� b�� ���� ���� �� �� �ƹ� ���� �����ϼ���.
//a�� b�� -10,000,000 �̻� 10,000,000 ������ �����Դϴ�.
//a�� b�� ��Ұ���� ���������� �ʽ��ϴ�.
//����� ��
//a	b	return
//3	5	12
//3	3	3
//5	3	12

using System;

public class Solution
{
    public long solution(int a, int b)
    {
        long answer = 0;
        for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
        {
            answer += i;
        }
        return answer;
    }
}