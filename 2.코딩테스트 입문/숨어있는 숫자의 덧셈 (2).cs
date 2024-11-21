//// https://school.programmers.co.kr/learn/courses/30/lessons/120864

//���� ����
//���ڿ� my_string�� �Ű������� �־����ϴ�. my_string�� �ҹ���, �빮��, �ڿ����θ� �����Ǿ��ֽ��ϴ�. my_string���� �ڿ������� ���� return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� my_string�� ���� �� 1,000
//1 �� my_string ���� �ڿ��� �� 1000
//���ӵ� ���� �ϳ��� ���ڷ� �����մϴ�.
//000123�� ���� 0�� �����ϴ� ���� �����ϴ�.
//���ڿ��� �ڿ����� ���� ��� 0�� return ���ּ���.
//����� ��
//my_string	result
//"aAb1B2cC34oOp"	37
//"1a2b3c4d123Z"	133
//����� �� ����
//����� �� #1

//"aAb1B2cC34oOp"���� �ڿ����� 1, 2, 34 �Դϴ�. ���� 1 + 2 + 34 = 37 �� return�մϴ�.
//����� �� #2

//"1a2b3c4d123Z"���� �ڿ����� 1, 2, 3, 4, 123 �Դϴ�. ���� 1 + 2 + 3 + 4 + 123 = 133 �� return�մϴ�.

using System;

public class Solution
{
    public int solution(string my_string)
    {
        int answer = 0;
        string temp = "";
        for (int i = 0; i < my_string.Length; i++)
        {
            if (my_string[i] >= '0' && my_string[i] <= '9')
            {
                temp += my_string[i];
            }
            else
            {
                answer = Add(answer, temp);
                temp = "";
            }
        }

        answer = Add(answer, temp);

        return answer;
    }

    public int Add(int _a, string _str)
    {
        if (_str == "")
        {
            return _a;
        }
        return _a + int.Parse(_str);
    }
}