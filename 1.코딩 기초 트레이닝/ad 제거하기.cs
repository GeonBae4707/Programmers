//���� ����
//���ڿ� �迭 strArr�� �־����ϴ�. �迭 ���� ���ڿ� �� "ad"��� �κ� ���ڿ��� �����ϰ� �ִ� ��� ���ڿ��� �����ϰ� ���� ���ڿ��� ������ �����Ͽ� �迭�� return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//���ѻ���
//1 �� strArr�� ���� �� 1,000
//1 �� strArr�� ������ ���� �� 20
//strArr�� ���Ҵ� ���ĺ� �ҹ��ڷ� �̷���� ���ڿ��Դϴ�.
//����� ��
//strArr	result
//["and","notad","abcd"]	["and","abcd"]
//["there","are","no","a","ds"]	["there","are","no","a","ds"]
//����� �� ����
//����� �� #1

//1�� �ε����� ���ڿ��� "notad"�� �κ� ���ڿ��� "ad"�� �����ϴ�. ���� �ش� ���ڿ��� �����ϰ� �������� ������ �����Ͽ� ["and","abcd"]�� return �մϴ�.
//����� �� #2

//"ad"�� �κ� ���ڿ��� �� ���ڿ��� �������� �ʽ��ϴ�. ���� ���� �迭�� �״�� return �մϴ�.���� ����
//���ڿ� �迭 strArr�� �־����ϴ�. �迭 ���� ���ڿ� �� "ad"��� �κ� ���ڿ��� �����ϰ� �ִ� ��� ���ڿ��� �����ϰ� ���� ���ڿ��� ������ �����Ͽ� �迭�� return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//���ѻ���
//1 �� strArr�� ���� �� 1,000
//1 �� strArr�� ������ ���� �� 20
//strArr�� ���Ҵ� ���ĺ� �ҹ��ڷ� �̷���� ���ڿ��Դϴ�.
//����� ��
//strArr	result
//["and","notad","abcd"]	["and","abcd"]
//["there","are","no","a","ds"]	["there","are","no","a","ds"]
//����� �� ����
//����� �� #1

//1�� �ε����� ���ڿ��� "notad"�� �κ� ���ڿ��� "ad"�� �����ϴ�. ���� �ش� ���ڿ��� �����ϰ� �������� ������ �����Ͽ� ["and","abcd"]�� return �մϴ�.
//����� �� #2

//"ad"�� �κ� ���ڿ��� �� ���ڿ��� �������� �ʽ��ϴ�. ���� ���� �迭�� �״�� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] strArr)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < strArr.GetLength(0); i++)
        {
            if (strArr[i].Contains("ad"))
            {
                continue;
            }
            list.Add(strArr[i]);
        }

        return list.ToArray();
    }
}