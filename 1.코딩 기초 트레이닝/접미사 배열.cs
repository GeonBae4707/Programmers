//���� ����
//� ���ڿ��� ���ؼ� ���̻�� Ư�� �ε������� �����ϴ� ���ڿ��� �ǹ��մϴ�.
//���� ���, "banana"�� ��� ���̻�� "banana", "anana", "nana", "ana", "na", "a"�Դϴ�.
//���ڿ� my_string�� �Ű������� �־��� ��, my_string�� ��� ���̻縦 ���������� ������ ���ڿ� �迭�� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//my_string�� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//1 �� my_string�� ���� �� 100
//����� ��
//my_string	result
//"banana"	["a", "ana", "anana", "banana", "na", "nana"]
//"programmers"	["ammers", "ers", "grammers", "mers", "mmers", "ogrammers", "programmers", "rammers", "rogrammers", "rs", "s"]
//����� �� ����
//����� �� #1

//���� 1���� my_string�� "banana"�� ��� ���̻�� ������ ����� �����ϴ�.
//�̸� ���������� �����ϸ� "a", "ana", "anana", "banana", "na", "nana"�̹Ƿ� ["a", "ana", "anana", "banana", "na", "nana"]�� return �մϴ�.
//����� �� #2

//���� 2���� my_string�� "programmers"�̰� ��� ���̻�� "programmers", "rogrammers", "ogrammers", "grammers", "rammers", "ammers", "mmers", "mers", "ers", "rs", "s"�Դϴ�.
//�̸� ���������� ������ ���ڿ� �迭 ["ammers", "ers", "grammers", "mers", "mmers", "ogrammers", "programmers", "rammers", "rogrammers", "rs", "s"]�� return �մϴ�.���� ����
//� ���ڿ��� ���ؼ� ���̻�� Ư�� �ε������� �����ϴ� ���ڿ��� �ǹ��մϴ�. ���� ���, "banana"�� ��� ���̻�� "banana", "anana", "nana", "ana", "na", "a"�Դϴ�.
//���ڿ� my_string�� �Ű������� �־��� ��, my_string�� ��� ���̻縦 ���������� ������ ���ڿ� �迭�� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//my_string�� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//1 �� my_string�� ���� �� 100
//����� ��
//my_string	result
//"banana"	["a", "ana", "anana", "banana", "na", "nana"]
//"programmers"	["ammers", "ers", "grammers", "mers", "mmers", "ogrammers", "programmers", "rammers", "rogrammers", "rs", "s"]
//����� �� ����
//����� �� #1

//���� 1���� my_string�� "banana"�� ��� ���̻�� ������ ����� �����ϴ�.
//�̸� ���������� �����ϸ� "a", "ana", "anana", "banana", "na", "nana"�̹Ƿ� ["a", "ana", "anana", "banana", "na", "nana"]�� return �մϴ�.
//����� �� #2

//���� 2���� my_string�� "programmers"�̰� ��� ���̻�� "programmers", "rogrammers", "ogrammers", "grammers", "rammers", "ammers", "mmers", "mers", "ers", "rs", "s"�Դϴ�.
//�̸� ���������� ������ ���ڿ� �迭 ["ammers", "ers", "grammers", "mers", "mmers", "ogrammers", "programmers", "rammers", "rogrammers", "rs", "s"]�� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string my_string)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < my_string.Length; i++)
        {
            list.Add(my_string.Substring(i));
        }

        list.Sort();

        return list.ToArray();
    }
}