//// https://school.programmers.co.kr/learn/courses/30/lessons/120912

//���� ����
//�Ӿ��̴� ����� ���� 7�� ���� �����մϴ�. ���� �迭 array�� �Ű������� �־��� ��, 7�� �� �� �� �ִ��� return �ϵ��� solution �Լ��� �ϼ��غ�����.

//���ѻ���
//1 �� array�� ���� �� 100
//0 �� array�� ���� �� 100,000
//����� ��
//array	result
//[7, 77, 17]	4
//[10, 29]	0
//����� �� ����
//����� �� #1

//[7, 77, 17]���� 7�� 4�� �����Ƿ� 4�� return �մϴ�.
//����� �� #2

//[10, 29]���� 7�� �����Ƿ� 0�� return �մϴ�.���� ����
//�Ӿ��̴� ����� ���� 7�� ���� �����մϴ�. ���� �迭 array�� �Ű������� �־��� ��, 7�� �� �� �� �ִ��� return �ϵ��� solution �Լ��� �ϼ��غ�����.

//���ѻ���
//1 �� array�� ���� �� 100
//0 �� array�� ���� �� 100,000
//����� ��
//array	result
//[7, 77, 17]	4
//[10, 29]	0
//����� �� ����
//����� �� #1

//[7, 77, 17]���� 7�� 4�� �����Ƿ� 4�� return �մϴ�.
//����� �� #2

//[10, 29]���� 7�� �����Ƿ� 0�� return �մϴ�.

using System;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;
        for (int i = 0; i < array.Length; i++)
        {
            string str = array[i].ToString();
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == '7')
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}