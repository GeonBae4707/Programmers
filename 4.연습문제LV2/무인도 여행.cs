//// https://school.programmers.co.kr/learn/courses/30/lessons/154540

//���� ����
//�޸��� ������ �¾� ���ε��� ������ ���� ���� ������ ���� �ֽ��ϴ�. �������� �ٴٿ� ���ε��鿡 ���� ������ ǥ�õ� �ֽ��ϴ�. ������ 1 x 1ũ���� �簢����� �̷���� ���簢�� ���� �����̸�, ������ �� ĭ���� 'X' �Ǵ� 1���� 9 ������ �ڿ����� �����ֽ��ϴ�. ������ 'X'�� �ٴٸ� ��Ÿ����, ���ڴ� ���ε��� ��Ÿ���ϴ�. �̶�, ��, ��, ��, ��� ����Ǵ� ������ �ϳ��� ���ε��� �̷�ϴ�. ������ �� ĭ�� ���� ���ڴ� �ķ��� ��Ÿ���µ�, ��, ��, ��, ��� ����Ǵ� ĭ�� ���� ���ڸ� ��� ���� ���� �ش� ���ε����� �ִ� ��ĥ���� �ӹ� �� �ִ����� ��Ÿ���ϴ�. � ������ � ���� �� ���� �޸��� �켱 �� ������ �ִ� ��ĥ�� �ӹ� �� �ִ��� �˾ƺ� �� ��� ���� �����Ϸ� �մϴ�.

//������ ��Ÿ���� ���ڿ� �迭 maps�� �Ű������� �־��� ��, �� ������ �ִ� ��ĥ�� �ӹ��� �� �ִ��� �迭�� ������������ ��� return �ϴ� solution �Լ��� �ϼ����ּ���. ���� ���� �� �ִ� ���ε��� ���ٸ� -1�� �迭�� ��� return ���ּ���.

//���ѻ���
//3 �� maps�� ���� �� 100
//3 �� maps[i]�� ���� �� 100
//maps[i]�� 'X' �Ǵ� 1 �� 9 ������ �ڿ����� �̷���� ���ڿ��Դϴ�.
//������ ���簢�� �����Դϴ�.
//����� ��
//maps	result
//["X591X","X1X5X","X231X", "1XXX1"]	[1, 1, 27]
//["XXX","XXX","XXX"]	[-1]
//����� �� ����
//����� �� #1

//�� ���ڿ��� ������ ���� ������ ��Ÿ���ϴ�.

//image1

//����� ������ ���� ��ġ�� ������ ������

//image2

//�̸� ������������ �����ϸ� [1, 1, 27]�� �˴ϴ�.

//����� �� #2

//�� ���ڿ��� ������ ���� ������ ��Ÿ���ϴ�.

//image3

//���� �������� �ʱ� ������ -1�� �迭�� ��� ��ȯ�մϴ�.���� ����
//�޸��� ������ �¾� ���ε��� ������ ���� ���� ������ ���� �ֽ��ϴ�. �������� �ٴٿ� ���ε��鿡 ���� ������ ǥ�õ� �ֽ��ϴ�. ������ 1 x 1ũ���� �簢����� �̷���� ���簢�� ���� �����̸�, ������ �� ĭ���� 'X' �Ǵ� 1���� 9 ������ �ڿ����� �����ֽ��ϴ�. ������ 'X'�� �ٴٸ� ��Ÿ����, ���ڴ� ���ε��� ��Ÿ���ϴ�. �̶�, ��, ��, ��, ��� ����Ǵ� ������ �ϳ��� ���ε��� �̷�ϴ�. ������ �� ĭ�� ���� ���ڴ� �ķ��� ��Ÿ���µ�, ��, ��, ��, ��� ����Ǵ� ĭ�� ���� ���ڸ� ��� ���� ���� �ش� ���ε����� �ִ� ��ĥ���� �ӹ� �� �ִ����� ��Ÿ���ϴ�. � ������ � ���� �� ���� �޸��� �켱 �� ������ �ִ� ��ĥ�� �ӹ� �� �ִ��� �˾ƺ� �� ��� ���� �����Ϸ� �մϴ�.

//������ ��Ÿ���� ���ڿ� �迭 maps�� �Ű������� �־��� ��, �� ������ �ִ� ��ĥ�� �ӹ��� �� �ִ��� �迭�� ������������ ��� return �ϴ� solution �Լ��� �ϼ����ּ���. ���� ���� �� �ִ� ���ε��� ���ٸ� -1�� �迭�� ��� return ���ּ���.

//���ѻ���
//3 �� maps�� ���� �� 100
//3 �� maps[i]�� ���� �� 100
//maps[i]�� 'X' �Ǵ� 1 �� 9 ������ �ڿ����� �̷���� ���ڿ��Դϴ�.
//������ ���簢�� �����Դϴ�.
//����� ��
//maps	result
//["X591X","X1X5X","X231X", "1XXX1"]	[1, 1, 27]
//["XXX","XXX","XXX"]	[-1]
//����� �� ����
//����� �� #1

//�� ���ڿ��� ������ ���� ������ ��Ÿ���ϴ�.

//image1

//����� ������ ���� ��ġ�� ������ ������

//image2

//�̸� ������������ �����ϸ� [1, 1, 27]�� �˴ϴ�.

//����� �� #2

//�� ���ڿ��� ������ ���� ������ ��Ÿ���ϴ�.

//image3

//���� �������� �ʱ� ������ -1�� �迭�� ��� ��ȯ�մϴ�.


using System;
using System.Collections.Generic;

public class Solution
{
    struct Position
    {
        public int x;
        public int y;
        public Position(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }

    bool[,] arrayVisit;
    public int[] solution(string[] maps)
    {
        List<int> listAnswer = new List<int>();
        arrayVisit = new bool[maps.GetLength(0), maps[0].Length];

        for (int i = 0; i < maps.GetLength(0); i++)
        {
            for (int j = 0; j < maps[i].Length; j++)
            {
                if (maps[i][j] == 'X' || arrayVisit[i, j] == true)
                {
                    arrayVisit[i, j] = true;
                    continue;
                }

                listAnswer.Add(BFS(i, j, maps));
            }
        }

        if (listAnswer.Count == 0)
        {
            listAnswer.Add(-1);
        }
        listAnswer.Sort();
        return listAnswer.ToArray();
    }

    public int BFS(int _startX, int _startY, string[] _maps)
    {
        int sum = 0;

        Queue<Position> queue = new Queue<Position>();
        queue.Enqueue(new Position(_startX, _startY));

        while (queue.Count > 0)
        {
            Position current = queue.Dequeue();

            if (current.x < 0 || current.y < 0 || current.x >= _maps.GetLength(0) || current.y >= _maps[0].Length ||
                arrayVisit[current.x, current.y] == true ||
                _maps[current.x][current.y] == 'X')
            {
                continue;
            }

            sum += int.Parse(_maps[current.x][current.y].ToString());
            arrayVisit[current.x, current.y] = true;

            queue.Enqueue(new Position(current.x - 1, current.y));
            queue.Enqueue(new Position(current.x + 1, current.y));
            queue.Enqueue(new Position(current.x, current.y - 1));
            queue.Enqueue(new Position(current.x, current.y + 1));
        }
        return sum;
    }
}