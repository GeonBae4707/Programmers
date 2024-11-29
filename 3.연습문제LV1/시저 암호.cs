//// https://school.programmers.co.kr/learn/courses/30/lessons/12926

//���� ����
//� ������ �� ���ĺ��� ������ �Ÿ���ŭ �о �ٸ� ���ĺ����� �ٲٴ� ��ȣȭ ����� ���� ��ȣ��� �մϴ�. ���� ��� "AB"�� 1��ŭ �и� "BC"�� �ǰ�, 3��ŭ �и� "DE"�� �˴ϴ�. "z"�� 1��ŭ �и� "a"�� �˴ϴ�. ���ڿ� s�� �Ÿ� n�� �Է¹޾� s�� n��ŭ �� ��ȣ���� ����� �Լ�, solution�� �ϼ��� ������.

//���� ����
//������ �ƹ��� �о �����Դϴ�.
//s�� ���ĺ� �ҹ���, �빮��, �������θ� �̷���� �ֽ��ϴ�.
//s�� ���̴� 8000�����Դϴ�.
//n�� 1 �̻�, 25������ �ڿ����Դϴ�.
//����� ��
//s	n	result
//"AB"	1	"BC"
//"z"	1	"a"
//"a B z"	4	"e F d"

public class Solution
{
    public string solution(string s, int n)
    {
        string answer = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                answer += ' ';
                continue;
            }

            if (s[i] >= 'a' && s[i] <= 'z')
            {
                char c = (char)(s[i] + n);
                if (c > 'z')
                {
                    c = (char)(c - 26);
                }
                answer += c;
            }

            if (s[i] >= 'A' && s[i] <= 'Z')
            {
                char c = (char)(s[i] + n);
                if (c > 'Z')
                {
                    c = (char)(c - 26);
                }
                answer += c;
            }
        }

        return answer;
    }
}