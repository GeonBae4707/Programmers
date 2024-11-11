//���� ����
//���� "A"�� "B"�� �̷���� ���ڿ� myString�� pat�� �־����ϴ�. myString�� "A"�� "B"��, "B"�� "A"�� �ٲ� ���ڿ��� �����ϴ� �κ� ���ڿ� �� pat�� ������ 1�� �ƴϸ� 0�� return �ϴ� solution �Լ��� �ϼ��ϼ���.

//���ѻ���
//1 �� myString�� ���� �� 100
//1 �� pat�� ���� �� 10
//myString�� pat�� ���� "A"�� "B"�θ� �̷���� ���ڿ��Դϴ�.
//����� ��
//myString	pat	result
//"ABBAA"	"AABB"	1
//"ABAB"	"ABAB"	0
//����� �� ����
//����� �� #1

//"ABBAA"���� "A"�� "B"�� ���� �ٲٸ� "BAABB"�Դϴ�. ���⿡�� �κй��ڿ� "AABB"�� �ֱ� ������ 1�� return �մϴ�.
//����� �� #2

//"ABAB"���� "A"�� "B"�� ���� �ٲٸ� "BABA"�Դϴ�. ���⿡�� �κй��ڿ� "BABA"�� ���� ������ 0�� return �մϴ�.
//�� 2023�� 05�� 15�� ���ѻ��� �� �׽�Ʈ ���̽��� �����Ǿ����ϴ�. ������ ������ �ڵ尡 ������� ���� �� �ֽ��ϴ�.

using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;
        string str = "";

        for (int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == 'A')
            {
                str += 'B';
            }
            else if (myString[i] == 'B')
            {
                str += 'A';
            }
        }

        return str.Contains(pat) ? 1 : 0;
    }
}