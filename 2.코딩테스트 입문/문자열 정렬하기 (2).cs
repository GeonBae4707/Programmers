
//���� ����
//���� ��ҹ��ڷ� �̷���� ���ڿ� my_string�� �Ű������� �־��� ��, my_string�� ��� �ҹ��ڷ� �ٲٰ� ���ĺ� ������� ������ ���ڿ��� return �ϵ��� solution �Լ��� �ϼ��غ�����.

//���ѻ���
//0 < my_string ���� < 100
//����� ��
//my_string	result
//"Bcad"	"abcd"
//"heLLo"	"ehllo"
//"Python"	"hnopty"
//����� �� ����
//����� �� #1

//"Bcad"�� ��� �ҹ��ڷ� �ٲٸ� "bcad"�̰� �̸� ���ĺ� ������ �����ϸ� "abcd"�Դϴ�.
//����� �� #2

//"heLLo"�� ��� �ҹ��ڷ� �ٲٸ� "hello"�̰� �̸� ���ĺ� ������ �����ϸ� "ehllo"�Դϴ�.
//����� �� #3

//"Python"�� ��� �ҹ��ڷ� �ٲٸ� "python"�̰� �̸� ���ĺ� ������ �����ϸ� "hnopty"�Դϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string my_string)
    {
        string answer = "";
        List<char> list = new List<char>();

        my_string = my_string.ToLower();

        for (int i = 0; i < my_string.Length; i++)
        {
            list.Add(my_string[i]);
        }

        list.Sort();

        for (int i = 0; i < list.Count; i++)
        {
            answer += list[i];
        }

        return answer;
    }
}