//// https://school.programmers.co.kr/learn/courses/30/lessons/120850

//���� ����
//���ڿ� my_string�� �Ű������� �־��� ��, my_string �ȿ� �ִ� ���ڸ� ��� �������� ������ ����Ʈ�� return �ϵ��� solution �Լ��� �ۼ��غ�����.

//���ѻ���
//1 �� my_string�� ���� �� 100
//my_string���� ���ڰ� �� �� �̻� ���ԵǾ� �ֽ��ϴ�.
//my_string�� ���� �ҹ��� �Ǵ� 0���� 9������ ���ڷ� �̷���� �ֽ��ϴ�. - - -
//����� ��
//my_string	result
//"hi12392"	[1, 2, 2, 3, 9]
//"p2o4i8gj2"	[2, 2, 4, 8]
//"abcde0"	[0]
//����� �� ����
//����� �� #1

//"hi12392"�� �ִ� ���� 1, 2, 3, 9, 2�� �������� ������ [1, 2, 2, 3, 9]�� return �մϴ�.
//����� �� #2

//"p2o4i8gj2"�� �ִ� ���� 2, 4, 8, 2�� �������� ������ [2, 2, 4, 8]�� return �մϴ�.
//����� �� #3

//"abcde0"�� �ִ� ���� 0�� �������� ������ [0]�� return �մϴ�.���� ����
//���ڿ� my_string�� �Ű������� �־��� ��, my_string �ȿ� �ִ� ���ڸ� ��� �������� ������ ����Ʈ�� return �ϵ��� solution �Լ��� �ۼ��غ�����.

//���ѻ���
//1 �� my_string�� ���� �� 100
//my_string���� ���ڰ� �� �� �̻� ���ԵǾ� �ֽ��ϴ�.
//my_string�� ���� �ҹ��� �Ǵ� 0���� 9������ ���ڷ� �̷���� �ֽ��ϴ�. - - -
//����� ��
//my_string	result
//"hi12392"	[1, 2, 2, 3, 9]
//"p2o4i8gj2"	[2, 2, 4, 8]
//"abcde0"	[0]
//����� �� ����
//����� �� #1

//"hi12392"�� �ִ� ���� 1, 2, 3, 9, 2�� �������� ������ [1, 2, 2, 3, 9]�� return �մϴ�.
//����� �� #2

//"p2o4i8gj2"�� �ִ� ���� 2, 4, 8, 2�� �������� ������ [2, 2, 4, 8]�� return �մϴ�.
//����� �� #3

//"abcde0"�� �ִ� ���� 0�� �������� ������ [0]�� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string my_string)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < my_string.Length; i++)
        {
            if (my_string[i] >= '0' && my_string[i] <= '9')
            {
                list.Add(int.Parse(my_string[i].ToString()));
            }
        }

        list.Sort();

        return list.ToArray();
    }
}