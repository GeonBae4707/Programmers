//���� ����
//�� �ڸ� ������ �̷���� ���ڿ� num_str�� �־��� ��, �� �ڸ����� ���� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//3 �� num_str �� 100
//����� ��
//num_str	result
//"123456789"	45
//"1000000"	1
//����� �� ����
//����� �� #1

//���ڿ� ���� ��� ���ڸ� ���ϸ� 45�� �˴ϴ�.
//����� �� #2

//���ڿ� ���� ��� ���ڸ� ���ϸ� 1�� �˴ϴ�.

using System;

public class Solution
{
    public int solution(string num_str)
    {
        int answer = 0;
        for (int i = 0; i < num_str.Length; i++)
        {
            answer += int.Parse(num_str[i].ToString());
        }
        return answer;
    }
}