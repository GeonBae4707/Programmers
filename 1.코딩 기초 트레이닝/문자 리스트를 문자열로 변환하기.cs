//���� ����
//���ڵ��� ����ִ� �迭 arr�� �־����ϴ�. arr�� ���ҵ��� ������� �̾� ���� ���ڿ��� return �ϴ� solution�Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� arr�� ���� �� 200
//arr�� ���Ҵ� ���� ���ĺ� �ҹ��ڷ� �̷���� ���̰� 1�� ���ڿ��Դϴ�.
//����� ��
//arr	result
//["a","b","c"]	"abc"���� ����
//���ڵ��� ����ִ� �迭 arr�� �־����ϴ�. arr�� ���ҵ��� ������� �̾� ���� ���ڿ��� return �ϴ� solution�Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� arr�� ���� �� 200
//arr�� ���Ҵ� ���� ���ĺ� �ҹ��ڷ� �̷���� ���̰� 1�� ���ڿ��Դϴ�.
//����� ��
//arr	result
//["a","b","c"]	"abc"

using System;

public class Solution
{
    public string solution(string[] arr)
    {
        string answer = "";
        for (int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }
        return answer;
    }
}