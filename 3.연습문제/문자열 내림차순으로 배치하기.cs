//// https://school.programmers.co.kr/learn/courses/30/lessons/12917

//���� ����
//���ڿ� s�� ��Ÿ���� ���ڸ� ū�ͺ��� ���� ������ ������ ���ο� ���ڿ��� �����ϴ� �Լ�, solution�� �ϼ����ּ���.
//s�� ���� ��ҹ��ڷθ� �����Ǿ� ������, �빮�ڴ� �ҹ��ں��� ���� ������ �����մϴ�.

//���� ����
//str�� ���� 1 �̻��� ���ڿ��Դϴ�.
//����� ��
//s	return
//"Zbcdefg"	"gfedcbZ"

using System.Collections.Generic;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        List<char> list = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            list.Add(s[i]);
        }
        list.Sort();
        list.Reverse();
        for (int i = 0; i < list.Count; i++)
        {
            answer += list[i];
        }
        return answer;
    }
}