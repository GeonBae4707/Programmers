//// https://school.programmers.co.kr/learn/courses/30/lessons/12937

//���� ����
//���� num�� ¦���� ��� "Even"�� ��ȯ�ϰ� Ȧ���� ��� "Odd"�� ��ȯ�ϴ� �Լ�, solution�� �ϼ����ּ���.

//���� ����
//num�� int ������ �����Դϴ�.
//0�� ¦���Դϴ�.
//����� ��
//num	return
//3	"Odd"
//4	"Even"

public class Solution
{
    public string solution(int num)
    {
        return num % 2 == 0 ? "Even" : "Odd";
    }
}