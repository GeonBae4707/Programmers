//���� ����
//���ڿ� my_string�� �� ���� m, c�� �־����ϴ�. my_string�� �� �ٿ� m ���ھ� ���η� ������ �� ���ʺ��� ���η� c��° ���� ���� ���ڵ��� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//my_string�� ���ҹ��ڷ� �̷���� �ֽ��ϴ�.
//1 �� m �� my_string�� ���� �� 1,000
//m�� my_string ������ ����θ� �־����ϴ�.
//1 �� c �� m
//����� ��
//my_string	m	c	result
//"ihrhbakrfpndopljhygc"	4	2	"happy"
//"programmers"	1	1	"programmers"
//����� �� ����
//����� �� #1

//���� 1���� my_string�� �� �ٿ� 4 ���ھ� ���� ������ ǥ�� �����ϴ�.
//|1��|2��|3��|4��|

//|---|---|---|---|

//|i|h|r|h|

//|b|a|k|r|

//|f|p|n|d|

//|o|p|l|j|

//|h|y|g|c|

//2���� ���� ���ڸ� ���η� ������ happy�̹Ƿ� "happy"�� return �մϴ�.
//����� �� #2

//���� 2���� my_string�� m�� 1�̹Ƿ� ���η� "programmers"�� ���� �Ͱ� ���� ���� 1���� ���� ���ڸ� ���η� ������ programmers�Դϴ�. ���� "programmers"�� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string my_string, int m, int c)
    {
        string answer = "";
        List<string> list = new List<string>();

        for (int i = 0; i < my_string.Length; i = i + m)
        {
            list.Add(my_string.Substring(i, m));
        }

        for (int i = 0; i < list.Count; i++)
        {
            answer += list[i][c - 1];
        }

        return answer;
    }
}