//// https://school.programmers.co.kr/learn/courses/30/lessons/12944

//���� ����
//������ ��� �ִ� �迭 arr�� ��հ��� return�ϴ� �Լ�, solution�� �ϼ��غ�����.

//���ѻ���
//arr�� ���� 1 �̻�, 100 ������ �迭�Դϴ�.
//arr�� ���Ҵ� -10,000 �̻� 10,000 ������ �����Դϴ�.
//����� ��
//arr	return
//[1,2,3,4]	2.5
//[5,5]	5���� ����
//������ ��� �ִ� �迭 arr�� ��հ��� return�ϴ� �Լ�, solution�� �ϼ��غ�����.

//���ѻ���
//arr�� ���� 1 �̻�, 100 ������ �迭�Դϴ�.
//arr�� ���Ҵ� -10,000 �̻� 10,000 ������ �����Դϴ�.
//����� ��
//arr	return
//[1,2,3,4]	2.5
//[5,5]	5

public class Solution
{
    public double solution(int[] arr)
    {
        double answer = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }
        return answer / arr.Length;
    }
}