//// https://school.programmers.co.kr/learn/courses/30/lessons/120913

//���� ����
//���ڿ� my_str�� n�� �Ű������� �־��� ��, my_str�� ���� n�� �߶� ������ �迭�� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� my_str�� ���� �� 100
//1 �� n �� my_str�� ����
//my_str�� ���ĺ� �ҹ���, �빮��, ���ڷ� �̷���� �ֽ��ϴ�.
//����� ��
//my_str	n	result
//"abc1Addfggg4556b"	6	["abc1Ad", "dfggg4", "556b"]
//"abcdef123"	3	["abc", "def", "123"]
//����� �� ����
//����� �� #1

//"abc1Addfggg4556b" �� ���� 6�� �߶� �迭�� ������ ["abc1Ad", "dfggg4", "556b"]�� return�ؾ� �մϴ�.
//����� �� #2

//"abcdef123" �� ���� 3�� �߶� �迭�� ������ ["abc", "def", "123"]�� return�ؾ� �մϴ�.
//���ǻ���
//����� �� #1�� ��� "abc1Addfggg4556b"�� ���� 6�� �ڸ��� "abc1Ad", "dfggg4" �ΰ��� ������ "556b"�� �����ϴ�. �̷� ��� ���� ���ڿ��� �״�� �迭�� �����մϴ�.���� ����
//���ڿ� my_str�� n�� �Ű������� �־��� ��, my_str�� ���� n�� �߶� ������ �迭�� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� my_str�� ���� �� 100
//1 �� n �� my_str�� ����
//my_str�� ���ĺ� �ҹ���, �빮��, ���ڷ� �̷���� �ֽ��ϴ�.
//����� ��
//my_str	n	result
//"abc1Addfggg4556b"	6	["abc1Ad", "dfggg4", "556b"]
//"abcdef123"	3	["abc", "def", "123"]
//����� �� ����
//����� �� #1

//"abc1Addfggg4556b" �� ���� 6�� �߶� �迭�� ������ ["abc1Ad", "dfggg4", "556b"]�� return�ؾ� �մϴ�.
//����� �� #2

//"abcdef123" �� ���� 3�� �߶� �迭�� ������ ["abc", "def", "123"]�� return�ؾ� �մϴ�.
//���ǻ���
//����� �� #1�� ��� "abc1Addfggg4556b"�� ���� 6�� �ڸ��� "abc1Ad", "dfggg4" �ΰ��� ������ "556b"�� �����ϴ�. �̷� ��� ���� ���ڿ��� �״�� �迭�� �����մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string my_str, int n)
    {
        List<string> list = new List<string>();
        for (int i = 0; i < my_str.Length; i += n)
        {
            if (i + n < my_str.Length)
            {
                list.Add(my_str.Substring(i, n));
            }
            else
            {
                list.Add(my_str.Substring(i));
            }
        }
        return list.ToArray();
    }
}