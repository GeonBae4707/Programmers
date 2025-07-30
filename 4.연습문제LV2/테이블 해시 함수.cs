//// https://school.programmers.co.kr/learn/courses/30/lessons/147354

//���� ����
//��ȣ�� �����ϴ� � �����ͺ��̽��� �� ���̺��� ��� ���� Ÿ���� �÷���� �̷���� �ֽ��ϴ�. ���̺��� 2���� ��ķ� ǥ���� �� ������ ���� �÷��� ��Ÿ����, ���� Ʃ���� ��Ÿ���ϴ�.
//ù ��° �÷��� �⺻Ű�μ� ��� Ʃ�ÿ� ���� �� ���� �ߺ����� �ʵ��� ����˴ϴ�. ��ȣ�� �� ���̺� ���� �ؽ� �Լ��� ������ ���� �����Ͽ����ϴ�.

//�ؽ� �Լ��� col, row_begin, row_end�� �Է����� �޽��ϴ�.
//���̺��� Ʃ���� col��° �÷��� ���� �������� �������� ������ �ϵ�, ���� �� ���� �����ϸ� �⺻Ű�� ù ��° �÷��� ���� �������� �������� �����մϴ�.
//���ĵ� �����Ϳ��� S_i�� i ��° ���� Ʃ�ÿ� ���� �� �÷��� ���� i �� ���� ���������� ������ �����մϴ�.
//row_begin �� i �� row_end �� ��� S_i�� �����Ͽ� bitwise XOR �� ���� �ؽ� �����μ� ��ȯ�մϴ�.
//���̺��� ������ data�� �ؽ� �Լ��� ���� �Է� col, row_begin, row_end�� �־����� �� ���̺��� �ؽ� ���� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���� ����
//1 �� data�� ���� �� 2,500
//1 �� data�� ������ ���� �� 500
//1 �� data[i][j] �� 1,000,000
//data[i][j]�� i + 1 ��° Ʃ���� j + 1 ��° �÷��� ���� �ǹ��մϴ�.
//1 �� col �� data�� ������ ����
//1 �� row_begin �� row_end �� data�� ����
//����� ��
//data	col	row_begin	row_end	result
//[[2, 2, 6],[1, 5, 10],[4, 2, 9],[3, 8, 3]]	2   2   3   4
//����� �� ����
//������ ����� ���� Ʃ���� �����ϸ� {4, 2, 9}, { 2, 2, 6}, { 1, 5, 10}, { 3, 8, 3}
//�� �˴ϴ�.
//S_2 = (2 mod 2) + (2 mod 2) + (6 mod 2) = 0 �Դϴ�.
//S_3 = (1 mod 3) + (5 mod 3) + (10 mod 3) = 4 �Դϴ�.
//���� �ؽ� ���� S_2 XOR S_ 3 = 4 �Դϴ�.
//�� ���� - 2025�� 3�� 14�� �׽�Ʈ���̽��� �߰��Ǿ����ϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[,] data, int col, int row_begin, int row_end)
    {
        // ����Ʈ�� �ٲ۴�
        List<int[]> listData = new List<int[]>();
        for (int i = 0; i < data.GetLength(0); i++)
        {
            int[] row = new int[data.GetLength(1)];
            for (int j = 0; j < data.GetLength(1); j++)
            {
                row[j] = data[i, j];
            }
            listData.Add(row);
        }

        // �����Ѵ�
        listData.Sort((a, b) =>
        {
            if (a[col - 1] == b[col - 1])
            {
                return b[0].CompareTo(a[0]);
            }
            return a[col - 1].CompareTo(b[col - 1]);
        });

        // ���� �ȿ� �ִ� ���� ���� ���Ѵ�
        List<int> listValue = new List<int>();
        for (int i = row_begin - 1; i < row_end; i++)
        {
            int sum = 0;
            for (int j = 0; j < listData[i].Length; j++)
            {
                sum += listData[i][j] % (i + 1);
            }
            listValue.Add(sum);
        }

        // XOR ����
        int answer = listValue[0];
        for (int i = 1; i < listValue.Count; i++)
        {
            answer ^= listValue[i];
        }

        return answer;
    }
}