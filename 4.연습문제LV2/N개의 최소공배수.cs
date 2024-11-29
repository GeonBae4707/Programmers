//// https://school.programmers.co.kr/learn/courses/30/lessons/12953

//���� ����
//�� ���� �ּҰ����(Least Common Multiple)�� �Էµ� �� ���� ��� �� ������ �Ǵ� ���� ���� ���ڸ� �ǹ��մϴ�. ���� ��� 2�� 7�� �ּҰ������ 14�� �˴ϴ�. ���Ǹ� Ȯ���ؼ�, n���� ���� �ּҰ������ n ���� ������ ��� �� ������ �Ǵ� ���� ���� ���ڰ� �˴ϴ�. n���� ���ڸ� ���� �迭 arr�� �ԷµǾ��� �� �� ������ �ּҰ������ ��ȯ�ϴ� �Լ�, solution�� �ϼ��� �ּ���.

//���� ����
//arr�� ���� 1�̻�, 15������ �迭�Դϴ�.
//arr�� ���Ҵ� 100 ������ �ڿ����Դϴ�.
//����� ��
//arr	result
//[2,6,8,14]	168
//[1,2,3]	6���� ����
//�� ���� �ּҰ����(Least Common Multiple)�� �Էµ� �� ���� ��� �� ������ �Ǵ� ���� ���� ���ڸ� �ǹ��մϴ�. ���� ��� 2�� 7�� �ּҰ������ 14�� �˴ϴ�. ���Ǹ� Ȯ���ؼ�, n���� ���� �ּҰ������ n ���� ������ ��� �� ������ �Ǵ� ���� ���� ���ڰ� �˴ϴ�. n���� ���ڸ� ���� �迭 arr�� �ԷµǾ��� �� �� ������ �ּҰ������ ��ȯ�ϴ� �Լ�, solution�� �ϼ��� �ּ���.

//���� ����
//arr�� ���� 1�̻�, 15������ �迭�Դϴ�.
//arr�� ���Ҵ� 100 ������ �ڿ����Դϴ�.
//����� ��
//arr	result
//[2,6,8,14]	168
//[1,2,3]	6

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] arr)
    {
        int answer = 1;
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            for (int j = 2; j <= arr[i]; j++)
            {
                if (arr[i] % j == 0)
                {
                    if (temp.ContainsKey(j))
                    {
                        temp[j]++;
                    }
                    else
                    {
                        temp.Add(j, 1);
                    }
                    arr[i] /= j;
                    j--;
                }
            }

            foreach (KeyValuePair<int, int> item in temp)
            {
                if (dict.ContainsKey(item.Key))
                {
                    if (dict[item.Key] < item.Value)
                    {
                        dict[item.Key] = item.Value;
                    }
                }
                else
                {
                    dict.Add(item.Key, item.Value);
                }
            }
        }

        foreach (KeyValuePair<int, int> item in dict)
        {
            for (int i = 0; i < item.Value; i++)
            {
                answer *= item.Key;
            }
        }

        return answer;
    }
}