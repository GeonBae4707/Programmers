//// https://school.programmers.co.kr/learn/courses/30/lessons/86971

//���� ����
//n���� ����ž�� ������ ���� �ϳ��� Ʈ�� ���·� ����Ǿ� �ֽ��ϴ�. ����� �� ������ �� �ϳ��� ��� ������ ���¸� ��Ʈ��ũ�� 2���� �����Ϸ��� �մϴ�. �̶�, �� ���¸��� ���� �Ǵ� ����ž�� ������ �ִ��� ����ϰ� ���߰��� �մϴ�.

//����ž�� ���� n, �׸��� ���� ���� wires�� �Ű������� �־����ϴ�. ������ �� �ϳ��� ��� ����ž ������ ������ ����ϵ��� �� ���¸����� �������� ��, �� ���¸��� ������ �ִ� ����ž ������ ����(���밪)�� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//n�� 2 �̻� 100 ������ �ڿ����Դϴ�.
//wires�� ���̰� n-1�� ������ 2���� �迭�Դϴ�.
//wires�� �� ���Ҵ� [v1, v2] 2���� �ڿ����� �̷���� ������, �̴� ���¸��� v1�� ����ž�� v2�� ����ž�� �������� ����Ǿ� �ִٴ� ���� �ǹ��մϴ�.
//1 �� v1 < v2 �� n �Դϴ�.
//���¸� ��Ʈ��ũ�� �ϳ��� Ʈ�� ���°� �ƴ� ���� �Է����� �־����� �ʽ��ϴ�.
//����� ��
//n	wires	result
//9	[[1, 3],[2, 3],[3, 4],[4, 5],[4, 6],[4, 7],[7, 8],[7, 9]]	3
//4[[1, 2], [2, 3], [3, 4]] 0
//7[[1, 2], [2, 7], [3, 7], [3, 4], [4, 5], [6, 7]]   1
//����� �� ����
//����� �� #1

//���� �׸��� �־��� �Է��� �ذ��ϴ� ��� �� �ϳ��� ��Ÿ�� ���Դϴ�.
//ex1.png
//4���� 7���� �����ϴ� ������ ������ �� ���¸��� �� 6���� 3���� ����ž�� ������, �̺��� �� ����� ������ ���¸��� ���� �� �����ϴ�.
//�� �ٸ� ������δ� 3���� 4���� �����ϴ� ������ ��� �ּ��� ������ ������ �� �ֽ��ϴ�.
//����� �� #2

//���� �׸��� �־��� �Է��� �ذ��ϴ� ����� ��Ÿ�� ���Դϴ�.
//ex2.png
//2���� 3���� �����ϴ� ������ ������ �� ���¸��� ��� 2���� ����ž�� ������ �Ǹ�, �� ����� �ּ��Դϴ�.
//����� �� #3

//���� �׸��� �־��� �Է��� �ذ��ϴ� ����� ��Ÿ�� ���Դϴ�.
//ex3.png
//3���� 7���� �����ϴ� ������ ������ �� ���¸��� ���� 4���� 3���� ����ž�� ������ �Ǹ�, �� ����� �ּ��Դϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n, int[,] wires)
    {
        int answer = n;
        Dictionary<int, List<int>> dictWires = new Dictionary<int, List<int>>();

        for (int i = 0; i < wires.GetLength(0); i++)
        {
            int v1 = wires[i, 0];
            int v2 = wires[i, 1];
            if (!dictWires.ContainsKey(v1))
            {
                dictWires[v1] = new List<int>();
            }
            if (!dictWires.ContainsKey(v2))
            {
                dictWires[v2] = new List<int>();
            }
            dictWires[v1].Add(v2);
            dictWires[v2].Add(v1);
        }

        for (int i = 0; i < wires.GetLength(0); i++)
        {
            int v1 = wires[i, 0];
            int v2 = wires[i, 1];

            int count1 = GetCount(v1, v2, dictWires);
            int count2 = GetCount(v2, v1, dictWires);

            answer = Math.Min(answer, Math.Abs(count1 - count2));
        }
        return answer;
    }

    private int GetCount(int _start, int _ban, Dictionary<int, List<int>> _dictWires)
    {
        List<int> listVisit = new List<int>();
        Queue<int> queueNext = new Queue<int>();

        queueNext.Enqueue(_start);

        while (queueNext.Count > 0)
        {
            int current = queueNext.Dequeue();
            if (listVisit.Contains(current))
            {
                continue;
            }
            else
            {
                listVisit.Add(current);
            }

            for (int k = 0; k < _dictWires[current].Count; k++)
            {
                int next = _dictWires[current][k];
                if (next != _ban && listVisit.Contains(next) == false)
                {
                    queueNext.Enqueue(next);
                }
            }
        }
        return listVisit.Count;
    }
}