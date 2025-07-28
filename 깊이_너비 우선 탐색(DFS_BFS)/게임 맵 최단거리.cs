//// https://school.programmers.co.kr/learn/courses/30/lessons/1844

//���� ����
//ROR ������ �� ������ ����� �����ϸ�, ��� �� ������ ���� �ı��ϸ� �̱�� �����Դϴ�. ����, �� ���� ��� �� ������ �ִ��� ���� �����ϴ� ���� �����մϴ�.

//���ݺ��� ����� �� ���� ������ �Ǿ� ������ �����Ϸ��� �մϴ�. ������ 5 x 5 ũ���� �ʿ�, ����� ĳ���Ͱ� (��: 1, ��: 1) ��ġ�� �ְ�, ��� �� ������ (��: 5, ��: 5) ��ġ�� �ִ� ����� �����Դϴ�.

//�ִܰŸ�1_sxuruo.png

//�� �׸����� ������ �κ��� ������ �����־� �� �� ���� ���̸�, ��� �κ��� �� �� �ִ� ���Դϴ�. ĳ���Ͱ� ������ ���� ��, ��, ��, �� �������� �� ĭ�� �̵��ϸ�, ���� ���� ��� ���� �� �� �����ϴ�.
//�Ʒ� ���ô� ĳ���Ͱ� ��� �� �������� ���� �� ���� ����� ��Ÿ���� �ֽ��ϴ�.

//ù ��° ����� 11���� ĭ�� ������ ��� �� ������ �����߽��ϴ�.
//�ִܰŸ�2_hnjd3b.png

//�� ��° ����� 15���� ĭ�� ������ ����� ������ �����߽��ϴ�.
//�ִܰŸ�3_ntxygd.png

//�� ���ÿ����� ù ��° ������� �� ������ ����� ������ �����ϴ� ����� �����Ƿ�, �� ����� ��� �� �������� ���� ���� ���� ����Դϴ�.

//����, ��� ���� �ڽ��� �� ���� ������ ���� �����ξ��ٸ� ��� �� ������ �������� ���� ���� �ֽ��ϴ�. ���� ���, ������ ���� ��쿡 ����� ĳ���ʹ� ��� �� ������ ������ �� �����ϴ�.

//�ִܰŸ�4_of9xfg.png

//���� ���� ���� maps�� �Ű������� �־��� ��, ĳ���Ͱ� ��� �� ������ �����ϱ� ���ؼ� �������� �ϴ� ĭ�� ������ �ּڰ��� return �ϵ��� solution �Լ��� �ϼ����ּ���. ��, ��� �� ������ ������ �� ���� ���� -1�� return ���ּ���.

//���ѻ���
//maps�� n x m ũ���� ���� ���� ���°� ����ִ� 2���� �迭��, n�� m�� ���� 1 �̻� 100 ������ �ڿ����Դϴ�.
//n�� m�� ���� ���� ����, �ٸ� ���� ������, n�� m�� ��� 1�� ���� �Է����� �־����� �ʽ��ϴ�.
//maps�� 0�� 1�θ� �̷���� ������, 0�� ���� �ִ� �ڸ�, 1�� ���� ���� �ڸ��� ��Ÿ���ϴ�.
//ó���� ĳ���ʹ� ���� ���� ���� ����� (1, 1) ��ġ�� ������, ���� ������ ���� ���� ���� �ϴ��� (n, m) ��ġ�� �ֽ��ϴ�.
//����� ��
//maps	answer
//[[1, 0, 1, 1, 1],[1, 0, 1, 0, 1],[1, 0, 1, 1, 1],[1, 1, 1, 0, 1],[0, 0, 0, 0, 1]]	11
//[[1, 0, 1, 1, 1], [1, 0, 1, 0, 1], [1, 0, 1, 1, 1], [1, 1, 1, 0, 0], [0, 0, 0, 0, 1]] - 1
//����� �� ����
//����� �� #1
//�־��� �����ʹ� ������ �����ϴ�.

//�ִܰŸ�6_lgjvrb.png

//ĳ���Ͱ� �� ���� �������� �̵��ϴ� ���� ���� ���� ���� �׸��� �����ϴ�.

//�ִܰŸ�2_hnjd3b (1).png

//���� �� 11ĭ�� ĳ���Ͱ� ���������Ƿ� 11�� return �ϸ� �˴ϴ�.

//����� �� #2
//������ ���ÿ� ������, ��� �� ������ ������ ����� �����ϴ�. ���� -1�� return �մϴ�.


using System;
using System.Collections.Generic;

class Solution
{
    struct Position
    {
        public int x;
        public int y;
        public int count;
        public Position(int _x, int _y, int _count)
        {
            this.x = _x;
            this.y = _y;
            this.count = _count;
        }
    }

    
    public int solution(int[,] maps)
    {
        bool[,] arrayVisit = new bool[maps.GetLength(0), maps.GetLength(1)];
        int answer = -1;       

        Queue<Position> queuePosition = new Queue<Position>();
        queuePosition.Enqueue(new Position(0, 0, 1));

        // �ʺ�Ž������ �ִܰŸ� ���ϱ�
        while (queuePosition.Count > 0)
        {
            Position currentPosition = queuePosition.Dequeue();

            if( currentPosition.x < 0 || currentPosition.y < 0 || 
                currentPosition.x >= maps.GetLength(0) || currentPosition.y >= maps.GetLength(1)) // ��������
            {
                continue;
            }

            if( maps[currentPosition.x, currentPosition.y] == 0) // ���� ����
            {
                continue;
            }

            if (arrayVisit[currentPosition.x, currentPosition.y] == true) // �湮��
            {
                continue;
            }
            arrayVisit[currentPosition.x, currentPosition.y] = true; // �湮üũ

            if ( currentPosition.x == maps.GetLength(0) - 1 && currentPosition.y == maps.GetLength(1) - 1) // ������
            {
                answer = currentPosition.count;
                break;
            }

            // �̵���
            int nextCount = currentPosition.count + 1;
            queuePosition.Enqueue(new Position(currentPosition.x + 1, currentPosition.y, nextCount));
            queuePosition.Enqueue(new Position(currentPosition.x - 1, currentPosition.y, nextCount));
            queuePosition.Enqueue(new Position(currentPosition.x, currentPosition.y + 1, nextCount));
            queuePosition.Enqueue(new Position(currentPosition.x, currentPosition.y - 1, nextCount));
        }

        return answer;
    }

    // ����Ž���� ȿ������ ������ �ʺ�Ž������ �ٲ����
    //private void Move(int[,] maps, int x, int y, int count)
    //{
    //    if (x < 0 || y < 0 || x >= maps.GetLength(0) || y >= maps.GetLength(1)) // ��������
    //    {
    //        return;
    //    }
    //    if (maps[x, y] == 0 || arrayVisit[x, y] == true)    // �湮��
    //    {
    //        return;
    //    }
    //    if (x == maps.GetLength(0) - 1 && y == maps.GetLength(1) - 1)   // ������
    //    {
    //        if (answer == -1 || answer > count)
    //        {
    //            answer = count;
    //        }
    //        return;
    //    }

    //    arrayVisit[x, y] = true;    // �湮üũ
    //    Move(maps, x + 1, y, count + 1);
    //    Move(maps, x - 1, y, count + 1);
    //    Move(maps, x, y + 1, count + 1);
    //    Move(maps, x, y - 1, count + 1);
    //    arrayVisit[x, y] = false;   // �湮����
    //}
}