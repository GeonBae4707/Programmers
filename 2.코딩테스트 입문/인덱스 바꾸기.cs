//// https://school.programmers.co.kr/learn/courses/30/lessons/120895

//���� ����
//���ڿ� my_string�� ���� num1, num2�� �Ű������� �־��� ��, my_string���� �ε��� num1�� �ε��� num2�� �ش��ϴ� ���ڸ� �ٲ� ���ڿ��� return �ϵ��� solution �Լ��� �ϼ��غ�����.

//���ѻ���
//1 < my_string�� ���� < 100
//0 �� num1, num2 < my_string�� ����
//my_string�� �ҹ��ڷ� �̷���� �ֽ��ϴ�.
//num1 �� num2
//����� ��
//my_string	num1	num2	result
//"hello"	1	2	"hlelo"
//"I love you"	3	6	"I l veoyou"
//����� �� ����
//����� �� #1

//"hello"�� 1��° �ε����� "e"�� 2��° �ε����� "l"�� �ٲٸ� "hlelo"�Դϴ�.
//����� �� #2

//"I love you"�� 3��° �ε��� "o"�� " "(����)�� �ٲٸ� "I l veoyou"�Դϴ�.

using System;

public class Solution
{
    public string solution(string my_string, int num1, int num2)
    {
        char[] strArray = my_string.ToCharArray();
        char temp = strArray[num1];
        strArray[num1] = strArray[num2];
        strArray[num2] = temp;
        return new string(strArray);
    }
}