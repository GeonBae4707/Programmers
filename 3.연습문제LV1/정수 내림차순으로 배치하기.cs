//// https://school.programmers.co.kr/learn/courses/30/lessons/12933

//���� ����
//�Լ� solution�� ���� n�� �Ű������� �Է¹޽��ϴ�. n�� �� �ڸ����� ū�ͺ��� ���� ������ ������ ���ο� ������ �������ּ���. ������� n�� 118372�� 873211�� �����ϸ� �˴ϴ�.

//���� ����
//n�� 1�̻� 8000000000 ������ �ڿ����Դϴ�.
//����� ��
//n	return
//118372	873211

using System.Collections.Generic;
public class Solution
{
    public long solution(long n)
    {
        string answer = "";
        string str = n.ToString();
        List<int> list = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(0);
        }
        for (int i = 0; i < str.Length; i++)
        {
            list[int.Parse(str[i].ToString())]++;
        }
        for (int i = 9; i >= 0; i--)
        {
            for (int j = 0; j < list[i]; j++)
            {
                answer += i.ToString();
            }
        }
        return long.Parse(answer);
    }
}