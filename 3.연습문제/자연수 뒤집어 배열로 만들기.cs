//// https://school.programmers.co.kr/learn/courses/30/lessons/12932

//���� ����
//�ڿ��� n�� ������ �� �ڸ� ���ڸ� ���ҷ� ������ �迭 ���·� �������ּ���. ������� n�� 12345�̸� [5,4,3,2,1]�� �����մϴ�.

//���� ����
//n�� 10,000,000,000������ �ڿ����Դϴ�.
//����� ��
//n	return
//12345	[5,4,3,2,1]���� ����
//�ڿ��� n�� ������ �� �ڸ� ���ڸ� ���ҷ� ������ �迭 ���·� �������ּ���. ������� n�� 12345�̸� [5,4,3,2,1]�� �����մϴ�.

//���� ����
//n�� 10,000,000,000������ �ڿ����Դϴ�.
//����� ��
//n	return
//12345	[5,4,3,2,1]

using System.Collections.Generic;

public class Solution
{
    public int[] solution(long n)
    {
        List<int> list = new List<int>();
        while (n > 0)
        {
            list.Add((int)(n % 10));
            n /= 10;
        }
        return list.ToArray();
    }
}