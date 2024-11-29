//// https://school.programmers.co.kr/learn/courses/30/lessons/12950

//���� ����
//����� ������ ��� ���� ũ�Ⱑ ���� �� ����� ���� ��, ���� ���� ���� ���� ���� ����� �˴ϴ�. 2���� ��� arr1�� arr2�� �Է¹޾�, ��� ������ ����� ��ȯ�ϴ� �Լ�, solution�� �ϼ����ּ���.

//���� ����
//��� arr1, arr2�� ��� ���� ���̴� 500�� ���� �ʽ��ϴ�.
//����� ��
//arr1	arr2	return
//[[1, 2],[2, 3]]	[[3, 4],[5, 6]]	[[4, 6],[7, 9]]
//[[1],[2]]	[[3],[4]]	[[4],[6]]

public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                answer[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        return answer;
    }
}