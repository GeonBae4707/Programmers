//// https://school.programmers.co.kr/learn/courses/30/lessons/12901

//���� ����
//2016�� 1�� 1���� �ݿ����Դϴ�. 2016�� a�� b���� ���� �����ϱ��? �� �� a , b�� �Է¹޾� 2016�� a�� b���� ���� �������� �����ϴ� �Լ�, solution�� �ϼ��ϼ���. ������ �̸��� �Ͽ��Ϻ��� ����ϱ��� ���� SUN, MON, TUE, WED, THU, FRI, SAT

//�Դϴ�. ���� ��� a=5, b = 24��� 5�� 24���� ȭ�����̹Ƿ� ���ڿ� "TUE"�� ��ȯ�ϼ���.

//���� ����
//2016���� �����Դϴ�.
//2016�� a�� b���� ������ �ִ� ���Դϴ�. (13�� 26���̳� 2�� 45�ϰ��� ��¥�� �־����� �ʽ��ϴ�)
//����� ��
//a	b	result
//5	24	"TUE"

public class Solution
{
    public string solution(int a, int b)
    {
        int[] month = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] week = new string[] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };

        int days = 0;
        for (int i = 0; i < a - 1; i++)
        {
            days += month[i];
        }
        days += b - 1;

        return week[days % 7];
    }
}