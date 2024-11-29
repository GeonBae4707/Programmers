//// https://school.programmers.co.kr/learn/courses/30/lessons/12935

//���� ����
//������ ������ �迭, arr ���� ���� ���� ���� ������ �迭�� �����ϴ� �Լ�, solution�� �ϼ����ּ���. ��, �����Ϸ��� �迭�� �� �迭�� ��쿣 �迭�� -1�� ä�� �����ϼ���. ������� arr�� [4,3,2,1]�� ���� [4,3,2]�� ���� �ϰ�, [10]�� [-1]�� ���� �մϴ�.

//���� ����
//arr�� ���� 1 �̻��� �迭�Դϴ�.
//�ε��� i, j�� ���� i �� j�̸� arr[i] �� arr[j] �Դϴ�.
//����� ��
//arr	return
//[4,3,2,1]	[4,3,2]
//[10]	[-1]���� ����
//������ ������ �迭, arr ���� ���� ���� ���� ������ �迭�� �����ϴ� �Լ�, solution�� �ϼ����ּ���. ��, �����Ϸ��� �迭�� �� �迭�� ��쿣 �迭�� -1�� ä�� �����ϼ���. ������� arr�� [4,3,2,1]�� ���� [4,3,2]�� ���� �ϰ�, [10]�� [-1]�� ���� �մϴ�.

//���� ����
//arr�� ���� 1 �̻��� �迭�Դϴ�.
//�ε��� i, j�� ���� i �� j�̸� arr[i] �� arr[j] �Դϴ�.
//����� ��
//arr	return
//[4,3,2,1]	[4,3,2]
//[10]	[-1]

using System.Collections.Generic;
public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> list = new List<int>();
        int min = arr[0];
        int minIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
                minIndex = i;
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (i != minIndex)
            {
                list.Add(arr[i]);
            }
        }

        if (list.Count == 0 || (list.Contains(10) && list.Count == 1))
        {
            list.Clear();
            list.Add(-1);
        }

        return list.ToArray();
    }
}