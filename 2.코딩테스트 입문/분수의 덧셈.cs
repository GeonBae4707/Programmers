//�� ����
//ù ��° �м��� ���ڿ� �и� ���ϴ� numer1, denom1, �� ��° �м��� ���ڿ� �и� ���ϴ� numer2, denom2�� �Ű������� �־����ϴ�. �� �м��� ���� ���� ��� �м��� ��Ÿ���� �� ���ڿ� �и� ������� ���� �迭�� return �ϵ��� solution �Լ��� �ϼ��غ�����.

//���ѻ���
//0 <numer1, denom1, numer2, denom2 < 1,000
//����� ��
//numer1	denom1	numer2	denom2	result
//1	2	3	4	[5, 4]
//9	2	1	3	[29, 6]
//����� �� ����
//����� �� #1

//1 / 2 + 3 / 4 = 5 / 4�Դϴ�. ���� [5, 4]�� return �մϴ�.
//����� �� #2

//9 / 2 + 1 / 3 = 29 / 6�Դϴ�. ���� [29, 6]�� return �մϴ�.�� ����
//ù ��° �м��� ���ڿ� �и� ���ϴ� numer1, denom1, �� ��° �м��� ���ڿ� �и� ���ϴ� numer2, denom2�� �Ű������� �־����ϴ�. �� �м��� ���� ���� ��� �м��� ��Ÿ���� �� ���ڿ� �и� ������� ���� �迭�� return �ϵ��� solution �Լ��� �ϼ��غ�����.

//���ѻ���
//0 <numer1, denom1, numer2, denom2 < 1,000
//����� ��
//numer1	denom1	numer2	denom2	result
//1	2	3	4	[5, 4]
//9	2	1	3	[29, 6]
//����� �� ����
//����� �� #1

//1 / 2 + 3 / 4 = 5 / 4�Դϴ�. ���� [5, 4]�� return �մϴ�.
//����� �� #2

//9 / 2 + 1 / 3 = 29 / 6�Դϴ�. ���� [29, 6]�� return �մϴ�.


using System;

public class Solution
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {

        int n = numer1 * denom2 + numer2 * denom1;
        int d = denom1 * denom2;
        int x = 0;

        while (d != 0)
        {
            int temp = d;
            d = n % d;
            n = temp;
        }
        x = n;

        n = (numer1 * denom2 + numer2 * denom1) / x;
        d = (denom1 * denom2) / x;

        int[] answer = new int[] { n, d };
        return answer;
    }
}