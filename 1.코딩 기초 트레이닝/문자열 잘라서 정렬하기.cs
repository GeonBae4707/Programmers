//���� ����
//���ڿ� myString�� �־����ϴ�. "x"�� �������� �ش� ���ڿ��� �߶� �迭�� ���� �� ���������� ������ �迭�� return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//��, �� ���ڿ��� ��ȯ�� �迭�� ���� �ʽ��ϴ�.

//���ѻ���
//1 �� myString �� 100,000
//myString�� ���ĺ� �ҹ��ڷ� �̷���� ���ڿ��Դϴ�.
//����� ��
//myString	result
//"axbxcxdx"	["a","b","c","d"]
//"dxccxbbbxaaaa"	["aaaa","bbb","cc","d"]
//����� �� ����
//����� �� #1

//myString�� "x"�� �������� �ڸ� �迭�� ["a","b","c","d"]�̸�, �� �迭�� �̹� ���������� ���ĵ� �����Դϴ�. ���� �ش� �迭�� return �մϴ�.
//����� �� #2

//myString�� "x"�� �������� �ڸ� �迭�� ["d","cc","bbb","aaaa"]�̸�, �� �迭�� ���������� �����ϸ� ["aaaa","bbb","cc","d"]�Դϴ�. ���� �ش� �迭�� return �մϴ�.���� ����
//���ڿ� myString�� �־����ϴ�. "x"�� �������� �ش� ���ڿ��� �߶� �迭�� ���� �� ���������� ������ �迭�� return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//��, �� ���ڿ��� ��ȯ�� �迭�� ���� �ʽ��ϴ�.

//���ѻ���
//1 �� myString �� 100,000
//myString�� ���ĺ� �ҹ��ڷ� �̷���� ���ڿ��Դϴ�.
//����� ��
//myString	result
//"axbxcxdx"	["a","b","c","d"]
//"dxccxbbbxaaaa"	["aaaa","bbb","cc","d"]
//����� �� ����
//����� �� #1

//myString�� "x"�� �������� �ڸ� �迭�� ["a","b","c","d"]�̸�, �� �迭�� �̹� ���������� ���ĵ� �����Դϴ�. ���� �ش� �迭�� return �մϴ�.
//����� �� #2

//myString�� "x"�� �������� �ڸ� �迭�� ["d","cc","bbb","aaaa"]�̸�, �� �迭�� ���������� �����ϸ� ["aaaa","bbb","cc","d"]�Դϴ�. ���� �ش� �迭�� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string myString)
    {
        List<string> answer = new List<string>(myString.Split("x", StringSplitOptions.RemoveEmptyEntries));
        answer.Sort();
        return answer.ToArray();
    }
}