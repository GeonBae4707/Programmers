//// https://school.programmers.co.kr/learn/courses/30/lessons/120862

//���� ����
//���� �迭 numbers�� �Ű������� �־����ϴ�. numbers�� ���� �� �� ���� ���� ���� �� �ִ� �ִ��� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//-10,000 �� numbers�� ���� �� 10,000
//2 �� numbers �� ���� �� 100
//����� ��
//numbers	result
//[1, 2, -3, 4, -5]	15
//[0, -31, 24, 10, 1, 9]	240
//[10, 20, 30, 5, 5, 20, 5]	600
//����� �� ����
//����� �� #1

//�� ���� ���� �ִ��� -3 * -5 = 15 �Դϴ�.
//����� �� #2

//�� ���� ���� �ִ��� 10 * 24 = 240 �Դϴ�.
//����� �� #3

//�� ���� ���� �ִ��� 20 * 30 = 600 �Դϴ�.���� ����
//���� �迭 numbers�� �Ű������� �־����ϴ�. numbers�� ���� �� �� ���� ���� ���� �� �ִ� �ִ��� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//-10,000 �� numbers�� ���� �� 10,000
//2 �� numbers �� ���� �� 100
//����� ��
//numbers	result
//[1, 2, -3, 4, -5]	15
//[0, -31, 24, 10, 1, 9]	240
//[10, 20, 30, 5, 5, 20, 5]	600
//����� �� ����
//����� �� #1

//�� ���� ���� �ִ��� -3 * -5 = 15 �Դϴ�.
//����� �� #2

//�� ���� ���� �ִ��� 10 * 24 = 240 �Դϴ�.
//����� �� #3

//�� ���� ���� �ִ��� 20 * 30 = 600 �Դϴ�.

using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int answer = numbers[0] * numbers[1];
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int temp = numbers[i] * numbers[j];
                if (temp > answer)
                {
                    answer = temp;
                }
            }
        }
        return answer;
    }
}