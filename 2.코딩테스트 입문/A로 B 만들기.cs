//// https://school.programmers.co.kr/learn/courses/30/lessons/120886

//���� ����
//���ڿ� before�� after�� �Ű������� �־��� ��, before�� ������ �ٲپ� after�� ���� �� ������ 1��, ���� �� ������ 0�� return �ϵ��� solution �Լ��� �ϼ��غ�����.

//���ѻ���
//0 < before�� ���� == after�� ���� < 1,000
//before�� after�� ��� �ҹ��ڷ� �̷���� �ֽ��ϴ�.
//����� ��
//before	after	result
//"olleh"	"hello"	1
//"allpe"	"apple"	0
//����� �� ����
//����� �� #1

//"olleh"�� ������ �ٲٸ� "hello"�� ���� �� �ֽ��ϴ�.
//����� �� #2

//"allpe"�� ������ �ٲ㵵 "apple"�� ���� �� �����ϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string before, string after)
    {
        Dictionary<char, int> beforeDic = new Dictionary<char, int>();
        for (int i = 0; i < before.Length; i++)
        {
            if (beforeDic.ContainsKey(before[i]))
            {
                beforeDic[before[i]]++;
            }
            else
            {
                beforeDic.Add(before[i], 1);
            }
        }
        for (int i = 0; i < after.Length; i++)
        {
            if (beforeDic.ContainsKey(after[i]))
            {
                beforeDic[after[i]]--;
            }
            else
            {
                return 0;
            }
        }
        foreach (var item in beforeDic)
        {
            if (item.Value != 0)
            {
                return 0;
            }
        }
        return 1;
    }
}