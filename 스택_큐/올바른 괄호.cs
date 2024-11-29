//// https://school.programmers.co.kr/learn/courses/30/lessons/12909

//���� ����
//��ȣ�� �ٸ��� ¦�������ٴ� ���� '(' ���ڷ� �������� �ݵ�� ¦��� ')' ���ڷ� ������ �Ѵٴ� ���Դϴ�. ���� ���

//"()()" �Ǵ� "(())()" �� �ùٸ� ��ȣ�Դϴ�.
//")()(" �Ǵ� "(()(" �� �ùٸ��� ���� ��ȣ�Դϴ�.
//'(' �Ǵ� ')' �θ� �̷���� ���ڿ� s�� �־����� ��, ���ڿ� s�� �ùٸ� ��ȣ�̸� true�� return �ϰ�, �ùٸ��� ���� ��ȣ�̸� false�� return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//���ѻ���
//���ڿ� s�� ���� : 100,000 ������ �ڿ���
//���ڿ� s�� '(' �Ǵ� ')' �θ� �̷���� �ֽ��ϴ�.
//����� ��
//s	answer
//"()()"	true
//"(())()"	true
//")()("	false
//"(()("	false
//����� �� ����
//����� �� #1,2,3,4
//������ ���ÿ� �����ϴ�.

using System;

public class Solution
{
    public bool solution(string s)
    {
        int n = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                n++;
            }
            else
            {
                n--;
            }

            if (n < 0)
            {
                return false;
            }
        }

        return n == 0 ? true : false;
    }
}