//���ҹ��ڷ� �̷���� ���ڿ� my_string�� ���ҹ��� 1���ڷ� �̷���� ���ڿ� alp�� �Ű������� �־��� ��, my_string���� alp�� �ش��ϴ� ��� ���ڸ� �빮�ڷ� �ٲ� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� my_string�� ���� �� 1,000
//����� ��
//my_string	alp	result
//"programmers"	"p"	"Programmers"
//"lowercase"	"x"	"lowercase"
//����� �� ����
//����� �� #1

//���� 1���� my_string�� "programmers"�̰� alp�� "p"�̹Ƿ� my_string�� ��� p�� �빮���� P�� �ٲ� ���ڿ� "Programmers"�� return �մϴ�.
//����� �� #2

//���� 2���� alp�� "x"�̰� my_string�� x�� �����ϴ�. ���� "lowercase"�� return �մϴ�.

using System;

public class Solution
{
    public string solution(string my_string, string alp)
    {
        return my_string.Replace(alp, alp.ToUpper());
    }
}