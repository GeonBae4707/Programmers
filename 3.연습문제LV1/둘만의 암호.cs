//// https://school.programmers.co.kr/learn/courses/30/lessons/155652

//���� ����
//�� ���ڿ� s�� skip, �׸��� �ڿ��� index�� �־��� ��, ���� ��Ģ�� ���� ���ڿ��� ����� �մϴ�. ��ȣ�� ��Ģ�� ������ �����ϴ�.

//���ڿ� s�� �� ���ĺ��� index��ŭ ���� ���ĺ����� �ٲ��ݴϴ�.
//index��ŭ�� ���� ���ĺ��� z�� �Ѿ ��� �ٽ� a�� ���ư��ϴ�.
//skip�� �ִ� ���ĺ��� �����ϰ� �ǳʶݴϴ�.
//���� ��� s = "aukks", skip = "wbqd", index = 5�� ��, a���� 5��ŭ �ڿ� �ִ� ���ĺ��� f���� [b, c, d, e, f] ���� 'b'�� 'd'�� skip�� ���ԵǹǷ� ���� �ʽ��ϴ�. ���� 'b', 'd'�� �����ϰ� 'a'���� 5��ŭ �ڿ� �ִ� ���ĺ��� [c, e, f, g, h] ������ ���� 'h'�� �˴ϴ�. ������ "ukks" ���� �� ��Ģ��� �ٲٸ� "appy"�� �Ǹ� ����� "happy"�� �˴ϴ�.

//�� ���ڿ� s�� skip, �׸��� �ڿ��� index�� �Ű������� �־��� �� �� ��Ģ��� s�� ��ȯ�� ����� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//5 �� s�� ���� �� 50
//1 �� skip�� ���� �� 10
//s�� skip�� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//skip�� ���ԵǴ� ���ĺ��� s�� ���Ե��� �ʽ��ϴ�.
//1 �� index �� 20
//����� ��
//s	skip	index	result
//"aukks"	"wbqd"	5	"happy"
//����� �� ����
//����� �� #1
//���� ����� ��ġ�մϴ�.


//("z", "a", 1) # "b"
//("a", "bcdefghijk", 20) # "o"
//("z", "abcdefghij", 20) # "n"
//("aukks", "wbqd", 5) # "happy"
//("abcde", "bcd", 2) # "ffffg"
//("yyyyy", "za", 2) # "ccccc"
//("ybcde", "az", 1) # "bcdef"
//("zzzzzz", "abcdefghijklmnopqrstuvwxy", 6) # "zzzzzz"
//("bcdefghijklmnopqrstuvwxyz", "a", 1) # "cdefghijklmnopqrstuvwxyzb"

using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string s, string skip, int index)
    {
        string answer = "";
        List<char> list = new List<char>(skip);

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            for (int j = 0; j < index; j++)
            {
                c = AddChar(c);
                while (list.Contains(c))
                {
                    c = AddChar(c);
                }
            }
            answer += c;
        }

        return answer;
    }

    public char AddChar(char c)
    {
        c++;
        if (c > 'z')
        {
            c -= (char)26;
        }
        return c;
    }
}