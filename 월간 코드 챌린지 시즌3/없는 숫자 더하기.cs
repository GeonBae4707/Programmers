//// https://school.programmers.co.kr/learn/courses/30/lessons/86051

//���� ����
//0���� 9������ ���� �� �Ϻΰ� ����ִ� ���� �迭 numbers�� �Ű������� �־����ϴ�. numbers���� ã�� �� ���� 0���� 9������ ���ڸ� ��� ã�� ���� ���� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� numbers�� ���� �� 9
//0 �� numbers�� ��� ���� �� 9
//numbers�� ��� ���Ҵ� ���� �ٸ��ϴ�.
//����� ��
//numbers	result
//[1,2,3,4,6,7,8,0]	14
//[5,8,4,0,6,7,9]	6
//����� �� ����
//����� �� #1

//5, 9�� numbers�� �����Ƿ�, 5 + 9 = 14�� return �ؾ� �մϴ�.
//����� �� #2

//1, 2, 3�� numbers�� �����Ƿ�, 1 + 2 + 3 = 6�� return �ؾ� �մϴ�.���� ����
//0���� 9������ ���� �� �Ϻΰ� ����ִ� ���� �迭 numbers�� �Ű������� �־����ϴ�. numbers���� ã�� �� ���� 0���� 9������ ���ڸ� ��� ã�� ���� ���� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� numbers�� ���� �� 9
//0 �� numbers�� ��� ���� �� 9
//numbers�� ��� ���Ҵ� ���� �ٸ��ϴ�.
//����� ��
//numbers	result
//[1,2,3,4,6,7,8,0]	14
//[5,8,4,0,6,7,9]	6
//����� �� ����
//����� �� #1

//5, 9�� numbers�� �����Ƿ�, 5 + 9 = 14�� return �ؾ� �մϴ�.
//����� �� #2

//1, 2, 3�� numbers�� �����Ƿ�, 1 + 2 + 3 = 6�� return �ؾ� �մϴ�.


using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] numbers)
    {
        int answer = 0;
        List<int> list = new List<int>(numbers);

        for (int i = 0; i < 10; i++)
        {
            if (list.Contains(i) == false)
            {
                answer += i;
            }
        }
        return answer;
    }
}
