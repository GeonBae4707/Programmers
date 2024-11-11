//���� ����
//���ڿ� binomial�� �Ű������� �־����ϴ�. binomial�� "a op b" ������ ���׽��̰� a�� b�� ���� �ƴ� ����, op�� '+', '-', '*' �� �ϳ��Դϴ�. �־��� ���� ����� ������ return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//0 �� a, b �� 40,000
//0�� �����ϰ� a, b�� 0���� �������� �ʽ��ϴ�.
//����� ��
//binomial	result
//"43 + 12"	55
//"0 - 7777"	-7777
//"40000 * 40000"	1600000000
//����� �� ����
//����� �� #1

//���� 1���� binomial�� "43 + 12"�� �� ���� ����� ����� 43 + 12 = 55�� return �մϴ�.
//����� �� #2

//���� 2���� binomial�� "0 - 7777"�� �� ���� ����� ����� 0 - 7777 = -7777�� return �մϴ�.
//����� �� #3

//���� 3���� binomial�� "40000 * 40000"���� �� ���� ����� ����� 40000 �� 40000 = 1600000000�� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string binomial)
    {
        char[] op = { '+', '-', '*' };
        bool bProcess = true;
        int nStart = 0;

        List<int> listNumber = new List<int>();
        List<char> listOp = new List<char>();

        while (bProcess)
        {
            int nOpIndex = binomial.IndexOfAny(op, nStart);
            if (nOpIndex == -1)
            {
                bProcess = false;
                listNumber.Add(int.Parse(binomial.Substring(nStart, binomial.Length - nStart)));
            }
            else
            {
                listNumber.Add(int.Parse(binomial.Substring(nStart, nOpIndex - nStart)));
                listOp.Add(binomial[nOpIndex]);
                nStart = nOpIndex + 1;
            }
        }

        if (listNumber.Count == 0)
        {
            return 0;
        }

        int answer = listNumber[0];
        for (int i = 0; i < listOp.Count; i++)
        {
            if (listOp[i] == '+')
            {
                answer += listNumber[i + 1];
            }
            else if (listOp[i] == '-')
            {
                answer -= listNumber[i + 1];
            }
            else if (listOp[i] == '*')
            {
                answer *= listNumber[i + 1];
            }
        }
        return answer;
    }
}