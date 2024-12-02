//// https://school.programmers.co.kr/learn/courses/30/lessons/154538

//���� ����
//�ڿ��� x�� y�� ��ȯ�Ϸ��� �մϴ�. ����� �� �ִ� ������ ������ �����ϴ�.

//x�� n�� ���մϴ�
//x�� 2�� ���մϴ�.
//x�� 3�� ���մϴ�.
//�ڿ��� x, y, n�� �Ű������� �־��� ��, x�� y�� ��ȯ�ϱ� ���� �ʿ��� �ּ� ���� Ƚ���� return�ϵ��� solution �Լ��� �ϼ����ּ���. �̶� x�� y�� ���� �� ���ٸ� -1�� return ���ּ���.

//���ѻ���
//1 �� x �� y �� 1,000,000
//1 �� n < y
//����� ��
//x	y	n	result
//10	40	5	2
//10	40	30	1
//2	5	4	-1
//����� �� ����
//����� �� #1
//x�� 2�� 2�� ���ϸ� 40�� �ǰ� �̶��� �ּ� Ƚ���Դϴ�.

//����� �� #2
//x�� n�� 30�� 1�� ���ϸ� 40�� �ǰ� �̶��� �ּ� Ƚ���Դϴ�.

//����� �� #3
//x�� y�� ��ȯ�� �� ���� ������ -1�� return�մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int x, int y, int n)
    {
        int answer = 0;
        Queue<int> queue = new Queue<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();

        queue.Enqueue(x);

        while (queue.Count > 0 && queue.Peek() <= y)
        {
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                int temp = queue.Dequeue();
                if (dict.ContainsKey(temp))
                {
                    continue;
                }
                else
                {
                    dict.Add(temp, 1);
                }

                if (temp == y)
                {
                    return answer;
                }

                int k = temp + n;
                if (k <= y)
                {
                    queue.Enqueue(k);
                }
                k = temp * 2;
                if (k <= y)
                {
                    queue.Enqueue(k);
                }
                k = temp * 3;
                if (k <= y)
                {
                    queue.Enqueue(k);
                }
            }
            answer++;
        }

        return -1;
    }
}