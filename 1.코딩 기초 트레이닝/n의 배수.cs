//���� ����
//���� num�� n�� �Ű� ������ �־��� ��, num�� n�� ����̸� 1�� return n�� ����� �ƴ϶�� 0�� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//2 �� num �� 100
//2 �� n �� 9
//����� ��
//num	n	result
//98	2	1
//34	3	0
//����� �� ����
//����� �� #1

//98�� 2�� ����̹Ƿ� 1�� return�մϴ�.
//����� �� #2

//32�� 3�� ����� �ƴϹǷ� 0�� return�մϴ�.

using System;

public class Solution
{
    public int solution(int num, int n)
    {

        if (num % n == 0)
        {
            return 1;
        }

        return 0;

    }
}