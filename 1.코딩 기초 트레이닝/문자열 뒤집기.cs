//���� ����
//���ڿ� my_string�� ���� s, e�� �Ű������� �־��� ��, my_string���� �ε��� s���� �ε��� e������ ������ ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//my_string�� ���ڿ� ���ĺ����θ� �̷���� �ֽ��ϴ�.
//1 �� my_string�� ���� �� 1,000
//0 �� s �� e < my_string�� ����
//����� ��
//my_string	s	e	result
//"Progra21Sremm3"	6	12	"ProgrammerS123"
//"Stanley1yelnatS"	4	10	"Stanley1yelnatS"
//����� �� ����
//����� �� #1

//���� 1���� my_string���� �ε��� 6���� �ε��� 12������ ������ ���ڿ��� "ProgrammerS123"�̹Ƿ� "ProgrammerS123"�� return �մϴ�.
//����� �� #2

//���� 2���� my_string���� �ε��� 4���� �ε��� 10������ �������� ���� ���ڿ��� ���� "Stanley1yelnatS"�̹Ƿ� "Stanley1yelnatS"�� return �մϴ�.

using System;

public class Solution
{
    public string solution(string my_string, int s, int e)
    {
        string temp = my_string.Substring(s, e - s + 1);
        string reverse = "";
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            reverse += temp[i];
        }
        return my_string.Replace(temp, reverse);
    }
}