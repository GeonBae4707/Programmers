//// https://school.programmers.co.kr/learn/courses/30/lessons/12949

//���� ����
//2���� ��� arr1�� arr2�� �Է¹޾�, arr1�� arr2�� ���� ����� ��ȯ�ϴ� �Լ�, solution�� �ϼ����ּ���.

//���� ����
//��� arr1, arr2�� ��� ���� ���̴� 2 �̻� 100 �����Դϴ�.
//��� arr1, arr2�� ���Ҵ� -10 �̻� 20 ������ �ڿ����Դϴ�.
//���� �� �ִ� �迭�� �־����ϴ�.
//����� ��
//arr1	arr2	return
//[[1, 4], [3, 2], [4, 1]]	[[3, 3], [3, 3]]	[[15, 15], [15, 15], [15, 15]]
//[[2, 3, 2], [4, 2, 4], [3, 1, 4]]	[[5, 4, 3], [2, 4, 1], [3, 1, 1]]	[[22, 22, 11], [36, 28, 18], [29, 20, 14]]

using System;

public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

        return answer;
    }
}

{ 1,4 }
{ 3,2}
{ 3,3 }

{ 3,3}
{ 3,3 }