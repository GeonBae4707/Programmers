//���� ����
//���� start_num�� end_num�� �־��� ��, start_num���� end_num������ ���ڸ� ���ʷ� ���� ����Ʈ�� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//0 �� start_num �� end_num �� 50
//����� ��
//start_num	end_num	result
//3	10	[3, 4, 5, 6, 7, 8, 9, 10]
//����� �� ����
//����� �� #1

//3���� 10������ ���ڵ��� ���� ����Ʈ [3, 4, 5, 6, 7, 8, 9, 10]�� return�մϴ�.���� ����
//���� start_num�� end_num�� �־��� ��, start_num���� end_num������ ���ڸ� ���ʷ� ���� ����Ʈ�� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//0 �� start_num �� end_num �� 50
//����� ��
//start_num	end_num	result
//3	10	[3, 4, 5, 6, 7, 8, 9, 10]
//����� �� ����
//����� �� #1

//3���� 10������ ���ڵ��� ���� ����Ʈ [3, 4, 5, 6, 7, 8, 9, 10]�� return�մϴ�.

using System;

public class Solution
{
    public int[] solution(int start_num, int end_num)
    {
        int[] answer = new int[end_num - start_num + 1];
        for (int i = start_num; i <= end_num; i++)
        {
            answer[i - start_num] = i;
        }
        return answer;
    }
}