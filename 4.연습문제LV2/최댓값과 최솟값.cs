//// https://school.programmers.co.kr/learn/courses/30/lessons/12939

//���� ����
//���ڿ� s���� �������� ���е� ���ڵ��� ����Ǿ� �ֽ��ϴ�. str�� ��Ÿ���� ���� �� �ּҰ��� �ִ밪�� ã�� �̸� "(�ּҰ�) (�ִ밪)"������ ���ڿ��� ��ȯ�ϴ� �Լ�, solution�� �ϼ��ϼ���.
//������� s�� "1 2 3 4"��� "1 4"�� �����ϰ�, "-1 -2 -3 -4"��� "-4 -1"�� �����ϸ� �˴ϴ�.

//���� ����
//s���� �� �̻��� ������ �������� ���еǾ� �ֽ��ϴ�.
//����� ��
//s	return
//"1 2 3 4"	"1 4"
//"-1 -2 -3 -4"	"-4 -1"
//"-1 -1"	"-1 -1"

using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        string[] str = s.Split(' ');
        int min = int.Parse(str[0]);
        int max = int.Parse(str[0]);

        for (int i = 1; i < str.Length; i++)
        {
            min = Math.Min(min, int.Parse(str[i]));
            max = Math.Max(max, int.Parse(str[i]));
        }

        answer = min + " " + max;

        return answer;
    }
}