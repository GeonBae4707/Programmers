//// https://school.programmers.co.kr/learn/courses/30/lessons/120904

//���� ����
//���� num�� k�� �Ű������� �־��� ��, num�� �̷�� ���� �߿� k�� ������ num�� �� ���ڰ� �ִ� �ڸ� ���� return�ϰ� ������ -1�� return �ϵ��� solution �Լ��� �ϼ��غ�����.

//���ѻ���
//0 < num < 1,000,000
//0 �� k < 10
//num�� k�� ���� �� ������ ���� ó�� ��Ÿ���� �ڸ��� return �մϴ�.
//����� ��
//num	k	result
//29183	1	3
//232443	4	4
//123456	7	-1
//����� �� ����
//����� �� #1

//29183���� 1�� 3��°�� �ֽ��ϴ�.
//����� �� #2

//232443���� 4�� 4��°�� ó�� �����մϴ�.
//����� �� #3

//123456�� 7�� �����Ƿ� -1�� return �մϴ�.

using System;

public class Solution
{
    public int solution(int num, int k)
    {
        int answer = num.ToString().IndexOf(k.ToString());
        if (answer != -1)
        {
            answer++;
        }
        return answer;
    }
}