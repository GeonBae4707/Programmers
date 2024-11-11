//���� ����
//���ڿ� �迭 strArr�� �־����ϴ�. strArr�� ���ҵ��� ���̰� ���� ���ڿ��鳢�� �׷����� ������ �� ���� ������ ���� �׷��� ũ�⸦ return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//���ѻ���
//1 �� strArr�� ���� �� 100,000
//1 �� strArr�� ������ ���� �� 30
//strArr�� ���ҵ��� ���ĺ� �ҹ��ڷ� �̷���� ���ڿ��Դϴ�.
//����� ��
//strArr	result
//["a","bc","d","efg","hi"]	2
//����� �� ����
//����� �� #1

//�� ���ڿ����� ���̿� �°� �׷����� ������ ������ �����ϴ�.
//���ڿ� ����	���ڿ� ���	����
//1	["a","d"]	2
//2	["bc","hi"]	2
//3	["efg"]	1
//������ �ִ��� 2�̹Ƿ� 2�� return �մϴ�.���� ����
//���ڿ� �迭 strArr�� �־����ϴ�. strArr�� ���ҵ��� ���̰� ���� ���ڿ��鳢�� �׷����� ������ �� ���� ������ ���� �׷��� ũ�⸦ return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//���ѻ���
//1 �� strArr�� ���� �� 100,000
//1 �� strArr�� ������ ���� �� 30
//strArr�� ���ҵ��� ���ĺ� �ҹ��ڷ� �̷���� ���ڿ��Դϴ�.
//����� ��
//strArr	result
//["a","bc","d","efg","hi"]	2
//����� �� ����
//����� �� #1

//�� ���ڿ����� ���̿� �°� �׷����� ������ ������ �����ϴ�.
//���ڿ� ����	���ڿ� ���	����
//1	["a","d"]	2
//2	["bc","hi"]	2
//3	["efg"]	1
//������ �ִ��� 2�̹Ƿ� 2�� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[] strArr)
    {
        List<int> listStr = new List<int>();
        List<int> listCount = new List<int>();

        for (int i = 0; i < strArr.GetLength(0); i++)
        {
            if (listStr.Contains(strArr[i].Length))
            {
                listCount[listStr.IndexOf(strArr[i].Length)]++;
            }
            else
            {
                listStr.Add(strArr[i].Length);
                listCount.Add(1);
            }
        }

        listCount.Sort();

        return listCount[listCount.Count - 1];
    }
}