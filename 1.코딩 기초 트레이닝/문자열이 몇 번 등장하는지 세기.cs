//���� ����
//���ڿ� myString�� pat�� �־����ϴ�. myString���� pat�� �����ϴ� Ƚ���� return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//���ѻ���
//1 �� myString �� 1000
//1 �� pat �� 10
//����� ��
//myString	pat	result
//"banana"	"ana"	2
//"aaaa"	"aa"	3
//����� �� ����
//����� �� #1

//"banana"���� 1 ~ 3�� �ε������� �� ��, 3 ~ 5�� �ε������� �� �� �� "ana"�� �����ؼ� �� �� �� �����մϴ�. ���� 2�� return �մϴ�.
//����� �� #2

//"aaaa"���� 0 ~ 2�� �ε������� �� ��, 1 ~ 3�� �ε������� �� ��, 2 ~ 4�� �ε������� �� �� "aa"�� �����ؼ� �� �� �� �����մϴ�. ���� 3�� return �մϴ�.

using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;

        for (int i = 0; i < myString.Length - pat.Length + 1; i++)
        {
            if (myString.Substring(i, pat.Length) == pat)
            {
                answer++;
            }
        }

        return answer;
    }
}