//// https://school.programmers.co.kr/learn/courses/30/lessons/120888

//���� ����
//���ڿ� my_string�� �Ű������� �־����ϴ�. my_string���� �ߺ��� ���ڸ� �����ϰ� �ϳ��� ���ڸ� ���� ���ڿ��� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� my_string �� 110
//my_string�� �빮��, �ҹ���, �������� �����Ǿ� �ֽ��ϴ�.
//�빮�ڿ� �ҹ��ڸ� �����մϴ�.
//����(" ")�� �ϳ��� ���ڷ� �����մϴ�.
//�ߺ��� ���� �� ���� �տ� �ִ� ���ڸ� ����ϴ�.
//����� ��
//my_string	result
//"people"	"peol"
//"We are the world"	"We arthwold"
//����� �� ����
//����� �� #1

//"people"���� �ߺ��� ���� "p"�� "e"�� ������ "peol"�� return�մϴ�.
//����� �� #2

//"We are the world"���� �ߺ��� ���� "e", " ", "r" ���� ������ "We arthwold"�� return�մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string my_string)
    {
        string answer = "";
        for (int i = 0; i < my_string.Length; i++)
        {
            if (answer.Contains(my_string[i]) == false)
            {
                answer += my_string[i];
            }
        }
        return answer;
    }
}