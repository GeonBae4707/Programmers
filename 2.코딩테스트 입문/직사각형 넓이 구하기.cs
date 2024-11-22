//// https://school.programmers.co.kr/learn/courses/30/lessons/120860

//���� ����
//2���� ��ǥ ��鿡 ���� ��� ������ ���簢���� �ֽ��ϴ�. ���簢�� �� �������� ��ǥ [[x1, y1], [x2, y2], [x3, y3], [x4, y4]]�� ����ִ� �迭 dots�� �Ű������� �־��� ��, ���簢���� ���̸� return �ϵ��� solution �Լ��� �ϼ��غ�����.

//���ѻ���
//dots�� ���� = 4
//dots�� ������ ���� = 2
//-256 < dots[i] �� ����< 256
//�߸��� �Է��� �־����� �ʽ��ϴ�.
//����� ��
//dots	result
//[[1, 1], [2, 1], [2, 2], [1, 2]]	1
//[[-1, -1], [1, 1], [1, -1], [-1, 1]]    4
//����� �� ����
//����� �� #1

//��ǥ [[1, 1], [2, 1], [2, 2], [1, 2]] �� ���������� ���� ���簢���� ����, ���� ���̴� ���� 1, 1�̹Ƿ� ���簢���� ���̴� 1 x 1 = 1�Դϴ�.
//����� �� #2

//��ǥ [[-1, -1], [1, 1], [1, -1], [-1, 1]]�� ���������� ���� ���簢���� ����, ���� ���̴� ���� 2, 2�̹Ƿ� ���簢���� ���̴� 2 x 2 = 4�Դϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[,] dots)
    {
        List<int> listx = new List<int>();
        List<int> listy = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            listx.Add(dots[i, 0]);
            listy.Add(dots[i, 1]);
        }
        listx.Sort();
        listy.Sort();
        return (listx[3] - listx[0]) * (listy[3] - listy[0]);
    }
}