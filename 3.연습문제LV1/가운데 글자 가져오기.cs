//// https://school.programmers.co.kr/learn/courses/30/lessons/12903

//���� ����
//�ܾ� s�� ��� ���ڸ� ��ȯ�ϴ� �Լ�, solution�� ����� ������. �ܾ��� ���̰� ¦����� ��� �α��ڸ� ��ȯ�ϸ� �˴ϴ�.

//���ѻ���
//s�� ���̰� 1 �̻�, 100������ ��Ʈ���Դϴ�.
//����� ��
//s	return
//"abcde"	"c"
//"qwer"	"we"

public class Solution
{
    public string solution(string s)
    {
        int n = s.Length;
        if (n % 2 == 0)
        {
            return s.Substring(n / 2 - 1, 2);
        }
        else
        {
            return s.Substring(n / 2, 1);
        }
    }
}