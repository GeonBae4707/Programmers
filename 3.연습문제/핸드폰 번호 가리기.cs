//// https://school.programmers.co.kr/learn/courses/30/lessons/12948

//���� ����
//���α׷��ӽ� ������� �������� ��ȣ�� ���� �������� ���� �� ������ ��ȭ��ȣ�� �Ϻθ� �����ϴ�.
//��ȭ��ȣ�� ���ڿ� phone_number�� �־����� ��, ��ȭ��ȣ�� �� 4�ڸ��� ������ ������ ���ڸ� ���� *���� ���� ���ڿ��� �����ϴ� �Լ�, solution�� �ϼ����ּ���.

//���� ����
//phone_number�� ���� 4 �̻�, 20������ ���ڿ��Դϴ�.
//����� ��
//phone_number	return
//"01033334444"	"*******4444"
//"027778888"	"*****8888"

public class Solution
{
    public string solution(string phone_number)
    {
        string answer = "";
        int n = phone_number.Length - 4;
        for (int i = 0; i < n; i++)
        {
            answer += "*";
        }
        answer += phone_number.Substring(n, 4);
        return answer;
    }
}