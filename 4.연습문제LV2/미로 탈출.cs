//// https://school.programmers.co.kr/learn/courses/30/lessons/159993

//���� ����
//1 x 1 ũ���� ĭ��� �̷���� ���簢�� ���� ������ �̷ο��� Ż���Ϸ��� �մϴ�. �� ĭ�� ��� �Ǵ� ������ �����Ǿ� ������, ������ �� ĭ�� ������ �� ���� ��η� �� ĭ���θ� �̵��� �� �ֽ��ϴ�. ��ε� �� �� ĭ���� �̷θ� ���������� ���� �ִµ�, �� ���� ������ ��ܼ��� �� �� �ֽ��ϴ�. ���� ���� ��ε� �� �� ĭ�� �ֽ��ϴ�. ����, ��� �������� ���� ������ �ִ� ĭ���� �̵��Ͽ� ������ ��� �� �̷θ� ���������� ���� �ִ� ĭ���� �̵��ϸ� �˴ϴ�. �̶� ���� ������ ����� �ʾҴ��� �ⱸ�� �ִ� ĭ�� ������ �� �ֽ��ϴ�. �̷ο��� �� ĭ�� �̵��ϴµ� 1�ʰ� �ɸ��ٰ� �� ��, �ִ��� ������ �̷θ� ���������µ� �ɸ��� �ð��� ���Ϸ� �մϴ�.

//�̷θ� ��Ÿ�� ���ڿ� �迭 maps�� �Ű������� �־��� ��, �̷θ� Ż���ϴµ� �ʿ��� �ּ� �ð��� return �ϴ� solution �Լ��� �ϼ����ּ���. ����, Ż���� �� ���ٸ� -1�� return ���ּ���.

//���ѻ���
//5 �� maps�� ���� �� 100
//5 �� maps[i]�� ���� �� 100
//maps[i]�� ���� 5���� ���ڵ�θ� �̷���� �ֽ��ϴ�.
//S : ���� ����
//E : �ⱸ
//L : ����
//O : ���
//X : ��
//���� ������ �ⱸ, ������ �׻� �ٸ� ���� �����ϸ� �� ������ �����մϴ�.
//�ⱸ�� ������ ������� �ʾƵ� ������ �� ������, ��� ���, �ⱸ, ����, �������� ���� �� ������ �� �ֽ��ϴ�.
//����� ��
//maps	result
//["SOOOL","XXXXO","OOOOO","OXXXX","OOOOE"]	16
//["LOOXS","OOOOX","OOOOO","OOOOO","EOOOO"]	-1
//����� �� ����
//����� �� #1

//�־��� ���ڿ��� ������ ���� �̷��̸�

//image1

//������ ���� �̵��ϸ� ���� ���� �ð��� Ż���� �� �ֽ��ϴ�.

//image2

//4�� �̵��Ͽ� ������ ���� �ⱸ���� �̵��ϸ� �� 16���� �ð��� �ɸ��ϴ�. ���� 16�� ��ȯ�մϴ�.

//����� �� #2

//�־��� ���ڿ��� ������ ���� �̷��Դϴ�.

//image3

//���� �������� �̵��� �� �ִ� ������ ��� Ż���� �� �����ϴ�. ���� -1�� ��ȯ�մϴ�.���� ����
//1 x 1 ũ���� ĭ��� �̷���� ���簢�� ���� ������ �̷ο��� Ż���Ϸ��� �մϴ�. �� ĭ�� ��� �Ǵ� ������ �����Ǿ� ������, ������ �� ĭ�� ������ �� ���� ��η� �� ĭ���θ� �̵��� �� �ֽ��ϴ�. ��ε� �� �� ĭ���� �̷θ� ���������� ���� �ִµ�, �� ���� ������ ��ܼ��� �� �� �ֽ��ϴ�. ���� ���� ��ε� �� �� ĭ�� �ֽ��ϴ�. ����, ��� �������� ���� ������ �ִ� ĭ���� �̵��Ͽ� ������ ��� �� �̷θ� ���������� ���� �ִ� ĭ���� �̵��ϸ� �˴ϴ�. �̶� ���� ������ ����� �ʾҴ��� �ⱸ�� �ִ� ĭ�� ������ �� �ֽ��ϴ�. �̷ο��� �� ĭ�� �̵��ϴµ� 1�ʰ� �ɸ��ٰ� �� ��, �ִ��� ������ �̷θ� ���������µ� �ɸ��� �ð��� ���Ϸ� �մϴ�.

//�̷θ� ��Ÿ�� ���ڿ� �迭 maps�� �Ű������� �־��� ��, �̷θ� Ż���ϴµ� �ʿ��� �ּ� �ð��� return �ϴ� solution �Լ��� �ϼ����ּ���. ����, Ż���� �� ���ٸ� -1�� return ���ּ���.

//���ѻ���
//5 �� maps�� ���� �� 100
//5 �� maps[i]�� ���� �� 100
//maps[i]�� ���� 5���� ���ڵ�θ� �̷���� �ֽ��ϴ�.
//S : ���� ����
//E : �ⱸ
//L : ����
//O : ���
//X : ��
//���� ������ �ⱸ, ������ �׻� �ٸ� ���� �����ϸ� �� ������ �����մϴ�.
//�ⱸ�� ������ ������� �ʾƵ� ������ �� ������, ��� ���, �ⱸ, ����, �������� ���� �� ������ �� �ֽ��ϴ�.
//����� ��
//maps	result
//["SOOOL","XXXXO","OOOOO","OXXXX","OOOOE"]	16
//["LOOXS","OOOOX","OOOOO","OOOOO","EOOOO"]	-1
//����� �� ����
//����� �� #1

//�־��� ���ڿ��� ������ ���� �̷��̸�

//image1

//������ ���� �̵��ϸ� ���� ���� �ð��� Ż���� �� �ֽ��ϴ�.

//image2

//4�� �̵��Ͽ� ������ ���� �ⱸ���� �̵��ϸ� �� 16���� �ð��� �ɸ��ϴ�. ���� 16�� ��ȯ�մϴ�.

//����� �� #2

//�־��� ���ڿ��� ������ ���� �̷��Դϴ�.

//image3

//���� �������� �̵��� �� �ִ� ������ ��� Ż���� �� �����ϴ�. ���� -1�� ��ȯ�մϴ�.


using System;
using System.Collections.Generic;

public class Solution
{
    struct Position
    {
        public int x;
        public int y;
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public int solution(string[] maps)
    {
        int startX = 0, startY = 0, leverX = 0, leverY = 0, endX = 0, endY = 0;
        for (int i = 0; i < maps.Length; i++)
        {
            for (int j = 0; j < maps[i].Length; j++)
            {
                if (maps[i][j] == 'S')
                {
                    startX = i;
                    startY = j;
                }
                else if (maps[i][j] == 'L')
                {
                    leverX = i;
                    leverY = j;
                }
                else if (maps[i][j] == 'E')
                {
                    endX = i;
                    endY = j;
                }
            }
        }

        int a = BFS(startX, startY, leverX, leverY, maps);
        int b = BFS(leverX, leverY, endX, endY, maps);

        if (a == -1 || b == -1)
        {
            return -1;
        }

        return a + b;
    }

    private int BFS(int _startX, int _startY, int _endX, int _endY, string[] _maps)
    {
        Queue<Position> queue = new Queue<Position>();
        int[,] arrayVisit = new int[_maps.Length, _maps[0].Length];

        queue.Enqueue(new Position(_startX, _startY));
        arrayVisit[_startX, _startY] = 0;

        while (queue.Count > 0)
        {
            Position current = queue.Dequeue();
            int count = arrayVisit[current.x, current.y];
            if (current.x == _endX && current.y == _endY)
            {
                return count;
            }

            if (CheckPosition(current.x + 1, current.y, _maps, arrayVisit))
            {
                arrayVisit[current.x + 1, current.y] = count + 1;
                queue.Enqueue(new Position(current.x + 1, current.y));
            }
            if (CheckPosition(current.x - 1, current.y, _maps, arrayVisit))
            {
                arrayVisit[current.x - 1, current.y] = count + 1;
                queue.Enqueue(new Position(current.x - 1, current.y));
            }
            if (CheckPosition(current.x, current.y + 1, _maps, arrayVisit))
            {
                arrayVisit[current.x, current.y + 1] = count + 1;
                queue.Enqueue(new Position(current.x, current.y + 1));
            }
            if (CheckPosition(current.x, current.y - 1, _maps, arrayVisit))
            {
                arrayVisit[current.x, current.y - 1] = count + 1;
                queue.Enqueue(new Position(current.x, current.y - 1));
            }
        }

        return -1;
    }

    private bool CheckPosition(int _x, int _y, string[] _maps, int[,] _arrayVisit)
    {
        if (_x < 0 || _x >= _maps.Length ||
            _y < 0 || _y >= _maps[0].Length ||
            _arrayVisit[_x, _y] != 0 ||
            _maps[_x][_y] == 'X')
        {
            return false;
        }
        return true;
    }
}