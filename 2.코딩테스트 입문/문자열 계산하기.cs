//// https://school.programmers.co.kr/learn/courses/30/lessons/120902

//���� ����
//my_string�� "3 + 5"ó�� ���ڿ��� �� �����Դϴ�. ���ڿ� my_string�� �Ű������� �־��� ��, ������ ����� ���� return �ϴ� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//�����ڴ� +, -�� �����մϴ�.
//���ڿ��� ���۰� ������ ������ �����ϴ�.
//0���� �����ϴ� ���ڴ� �־����� �ʽ��ϴ�.
//�߸��� ������ �־����� �ʽ��ϴ�.
//5 �� my_string�� ���� �� 100
//my_string�� ����� ������� 1 �̻� 100,000 �����Դϴ�.
//my_string�� �߰� ��� ���� -100,000 �̻� 100,000 �����Դϴ�.
//��꿡 ����ϴ� ���ڴ� 1 �̻� 20,000 ������ �ڿ����Դϴ�.
//my_string���� �����ڰ� ��� �ϳ� ���ԵǾ� �ֽ��ϴ�.
//return type �� �������Դϴ�.
//my_string�� ���ڿ� �����ڴ� ���� �ϳ��� ���еǾ� �ֽ��ϴ�.
//����� ��
//my_string	result
//"3 + 4"	7
//����� �� ����
//����� �� #1

//3 + 4 = 7�� return �մϴ�.

using System;

public class Solution
{
    public int solution(string my_string)
    {
        string[] arr = my_string.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int answer = int.Parse(arr[0]);
        for (int i = 1; i < arr.GetLength(0); i += 2)
        {
            if (arr[i] == "+")
            {
                answer += int.Parse(arr[i + 1]);
            }
            else if (arr[i] == "-")
            {
                answer -= int.Parse(arr[i + 1]);
            }
        }
        return answer;
    }
}