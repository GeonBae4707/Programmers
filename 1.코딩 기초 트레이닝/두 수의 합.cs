//���� ����
//0 �̻��� �� ������ ���ڿ� a, b�� �־��� ��, a + b�� ���� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� a�� ���� �� 100,000
//1 �� b�� ���� �� 100,000
//a�� b�� ���ڷθ� �̷���� �ֽ��ϴ�.
//a�� b�� ���� 0�� �ƴ϶�� 0���� �������� �ʽ��ϴ�.
//����� ��
//a	b	result
//"582"	"734"	"1316"
//"18446744073709551615"	"287346502836570928366"	"305793246910280479981"
//"0"	"0"	"0"
//����� �� ����
//����� �� #1

//���� 1���� a, b�� ���� 582, 734�̰� 582 + 734 = 1316�Դϴ�. ���� "1316"�� return �մϴ�.
//����� �� #2

//���� 2���� a, b�� ���� 18446744073709551615, 287346502836570928366�̰� 18446744073709551615 + 287346502836570928366 = 305793246910280479981�Դϴ�. ���� "305793246910280479981"�� return �մϴ�.
//����� �� #3

//���� 3���� a, b�� ���� 0, 0�̰� 0 + 0 = 0�Դϴ�. ���� "0"�� return �մϴ�.

using System;

public class Solution
{
    public string solution(string a, string b)
    {
        string answer = "";
        string max = a.Length > b.Length ? a : b;
        string min = a.Length > b.Length ? b : a;
        int[] arr = new int[max.Length];
        int head = 0;
        int temp = max.Length - min.Length;

        for (int i = 0; i < max.Length; i++)
        {
            if (i < temp)
            {
                arr[i] = int.Parse(max.Substring(i, 1));
            }
            else
            {

                arr[i] = int.Parse(max.Substring(i, 1)) + int.Parse(min.Substring(i - temp, 1));
            }
        }

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] >= 10)
            {
                if (i == 0)
                {
                    head += (arr[i] / 10);
                }
                else
                {
                    arr[i - 1] += (arr[i] / 10);
                }
                arr[i] %= 10;
            }
        }

        if (head != 0)
        {
            answer += head;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }

        return answer;
    }
}