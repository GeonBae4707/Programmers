//// https://school.programmers.co.kr/learn/courses/30/lessons/120894

//���� ����
//��� ���� �Ӿ��̴� ����� ǥ��Ǿ��ִ� ���ڸ� ���� �ٲٷ��� �մϴ�. ���ڿ� numbers�� �Ű������� �־��� ��, numbers�� ������ �ٲ� return �ϵ��� solution �Լ��� �ϼ��� �ּ���.

//���ѻ���
//numbers�� �ҹ��ڷθ� �����Ǿ� �ֽ��ϴ�.
//numbers�� "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" ���� ���� ���� ���յǾ� �ֽ��ϴ�.
//1 �� numbers�� ���� �� 50
//"zero"�� numbers�� �� �տ� �� �� �����ϴ�.
//����� ��
//numbers	result
//"onetwothreefourfivesixseveneightnine"	123456789
//"onefourzerosixseven"	14067
//����� �� ����
//����� �� #1

//"onetwothreefourfivesixseveneightnine"�� ���ڷ� �ٲ� 123456789�� return�մϴ�.
//����� �� #1

//"onefourzerosixseven"�� ���ڷ� �ٲ� 14067�� return�մϴ�.

using System;

public class Solution
{
    public long solution(string numbers)
    {
        numbers = numbers.Replace("zero", "0");
        numbers = numbers.Replace("one", "1");
        numbers = numbers.Replace("two", "2");
        numbers = numbers.Replace("three", "3");
        numbers = numbers.Replace("four", "4");
        numbers = numbers.Replace("five", "5");
        numbers = numbers.Replace("six", "6");
        numbers = numbers.Replace("seven", "7");
        numbers = numbers.Replace("eight", "8");
        numbers = numbers.Replace("nine", "9");
        return long.Parse(numbers);
    }
}