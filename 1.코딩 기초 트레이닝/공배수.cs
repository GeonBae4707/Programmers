//���� ����
//���� number�� n, m�� �־����ϴ�. number�� n�� ����̸鼭 m�� ����̸� 1�� �ƴ϶�� 0�� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//10 �� number �� 100
//2 �� n, m < 10
//����� ��
//number	n	m	result
//60	2	3	1
//55	10	5	0
//����� �� ����
//����� �� #1

//60�� 2�� ����̸鼭 3�� ����̱� ������ 1�� return�մϴ�.
//����� �� #2

//55�� 5�� ��������� 10�� ����� �ƴϱ� ������ 0�� return�մϴ�.

using System;

public class Solution
{
    public int solution(int number, int n, int m)
    {
        if (number % n == 0 && number % m == 0)
        {
            return 1;
        }
        return 0;
    }
}