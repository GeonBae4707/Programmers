//// https://school.programmers.co.kr/learn/courses/30/lessons/120896

//���� ����
//���ڿ� s�� �Ű������� �־����ϴ�. s���� �� ���� �����ϴ� ���ڸ� ���� ������ ������ ���ڿ��� return �ϵ��� solution �Լ��� �ϼ��غ�����. �� ���� �����ϴ� ���ڰ� ���� ��� �� ���ڿ��� return �մϴ�.

//���ѻ���
//0 < s�� ���� < 1,000
//s�� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//����� ��
//s	result
//"abcabcadc"	"d"
//"abdc"	"abcd"
//"hello"	"eho"
//����� �� ����
//����� �� #1

//"abcabcadc"���� �ϳ��� �����ϴ� ���ڴ� "d"�Դϴ�.
//����� �� #2

//"abdc"���� ��� ���ڰ� �� ���� �����ϹǷ� ���� ������ ������ "abcd"�� return �մϴ�.
//����� �� #3

//"hello"���� �� ���� ������ ���ڴ� "heo"�̰� �̸� ���� ������ ������ "eho"�� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        List<char> listChar = new List<char>();
        List<int> listCount = new List<int>();
        List<char> list = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (listChar.Contains(s[i]))
            {
                listCount[listChar.IndexOf(s[i])]++;
            }
            else
            {
                listChar.Add(s[i]);
                listCount.Add(1);
            }
        }

        for (int i = 0; i < listCount.Count; i++)
        {
            if (listCount[i] == 1)
            {
                list.Add(listChar[i]);
            }
        }

        list.Sort();
        for (int i = 0; i < list.Count; i++)
        {
            answer += list[i];
        }

        return answer;
    }
}