//���� ����
//���ڿ� ����Ʈ str_list���� "u", "d", "l", "r" �� ���� ���ڿ��� ���� �� ����Ǿ� �ֽ��ϴ�.
//str_list���� "l"�� "r" �� ���� ������ ���ڿ��� "l"�̶�� �ش� ���ڿ��� �������� ���ʿ� �ִ� ���ڿ����� ������� ���� ����Ʈ��, ���� ������ ���ڿ��� "r"�̶�� �ش� ���ڿ��� �������� �����ʿ� �ִ� ���ڿ����� ������� ���� ����Ʈ�� return�ϵ��� solution �Լ��� �ϼ����ּ���.
//"l"�̳� "r"�� ���ٸ� �� ����Ʈ�� return�մϴ�.

//���ѻ���
//1 �� str_list�� ���� �� 20
//str_list�� "u", "d", "l", "r" �� ���� ���ڿ��� �̷���� �ֽ��ϴ�.
//����� ��
//str_list	result
//["u", "u", "l", "r"]	["u", "u"]
//["l"]	[]
//����� �� ����
//����� �� #1

//"r"���� "l"�� ���� ���Ա� ������ "l"�� ���ʿ� �ִ� ���ڿ����� ���� ����Ʈ�� ["u", "u"]�� return�մϴ�.
//����� �� #2

//"l"�� ���ʿ� ���ڿ��� ���� ������ �� ����Ʈ�� return�մϴ�.���� ����
//���ڿ� ����Ʈ str_list���� "u", "d", "l", "r" �� ���� ���ڿ��� ���� �� ����Ǿ� �ֽ��ϴ�.
//str_list���� "l"�� "r" �� ���� ������ ���ڿ��� "l"�̶�� �ش� ���ڿ��� �������� ���ʿ� �ִ� ���ڿ����� ������� ���� ����Ʈ��, ���� ������ ���ڿ��� "r"�̶�� �ش� ���ڿ��� �������� �����ʿ� �ִ� ���ڿ����� ������� ���� ����Ʈ�� return�ϵ��� solution �Լ��� �ϼ����ּ���.
//"l"�̳� "r"�� ���ٸ� �� ����Ʈ�� return�մϴ�.

//���ѻ���
//1 �� str_list�� ���� �� 20
//str_list�� "u", "d", "l", "r" �� ���� ���ڿ��� �̷���� �ֽ��ϴ�.
//����� ��
//str_list	result
//["u", "u", "l", "r"]	["u", "u"]
//["l"]	[]
//����� �� ����
//����� �� #1

//"r"���� "l"�� ���� ���Ա� ������ "l"�� ���ʿ� �ִ� ���ڿ����� ���� ����Ʈ�� ["u", "u"]�� return�մϴ�.
//����� �� #2

//"l"�� ���ʿ� ���ڿ��� ���� ������ �� ����Ʈ�� return�մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] str_list)
    {
        List<string> list = new List<string>();

        int a = Array.IndexOf(str_list, "l");
        int b = Array.IndexOf(str_list, "r");
        bool bLeft = false;

        if (a == -1 && b == -1)
        {
            return list.ToArray();
        }
        else if (a == -1)
        {
            bLeft = false;
        }
        else if (b == -1)
        {
            bLeft = true;
        }
        else if (a < b)
        {
            bLeft = true;
        }
        else
        {
            bLeft = false;
        }

        if (bLeft)
        {
            for (int i = 0; i < a; i++)
            {
                list.Add(str_list[i]);
            }
        }
        else
        {
            for (int i = b + 1; i < str_list.Length; i++)
            {
                list.Add(str_list[i]);
            }
        }

        return list.ToArray();
    }
}