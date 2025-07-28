//// https://school.programmers.co.kr/learn/courses/30/lessons/42746

//���� ����
//0 �Ǵ� ���� ������ �־����� ��, ������ �̾� �ٿ� ���� �� �ִ� ���� ū ���� �˾Ƴ� �ּ���.

//���� ���, �־��� ������ [6, 10, 2]��� [6102, 6210, 1062, 1026, 2610, 2106]�� ���� �� �ְ�, ���� ���� ū ���� 6210�Դϴ�.

//0 �Ǵ� ���� ������ ��� �迭 numbers�� �Ű������� �־��� ��, ������ ���ġ�Ͽ� ���� �� �ִ� ���� ū ���� ���ڿ��� �ٲپ� return �ϵ��� solution �Լ��� �ۼ����ּ���.

//���� ����
//numbers�� ���̴� 1 �̻� 100,000 �����Դϴ�.
//numbers�� ���Ҵ� 0 �̻� 1,000 �����Դϴ�.
//������ �ʹ� Ŭ �� ������ ���ڿ��� �ٲپ� return �մϴ�.
//����� ��
//numbers	return
//[6, 10, 2]	"6210"
//[3, 30, 34, 5, 9]	"9534330"
//�� ���� - 2021�� 10�� 20�� �׽�Ʈ���̽��� �߰��Ǿ����ϴ�.���� ����
//0 �Ǵ� ���� ������ �־����� ��, ������ �̾� �ٿ� ���� �� �ִ� ���� ū ���� �˾Ƴ� �ּ���.

//���� ���, �־��� ������ [6, 10, 2]��� [6102, 6210, 1062, 1026, 2610, 2106]�� ���� �� �ְ�, ���� ���� ū ���� 6210�Դϴ�.

//0 �Ǵ� ���� ������ ��� �迭 numbers�� �Ű������� �־��� ��, ������ ���ġ�Ͽ� ���� �� �ִ� ���� ū ���� ���ڿ��� �ٲپ� return �ϵ��� solution �Լ��� �ۼ����ּ���.

//���� ����
//numbers�� ���̴� 1 �̻� 100,000 �����Դϴ�.
//numbers�� ���Ҵ� 0 �̻� 1,000 �����Դϴ�.
//������ �ʹ� Ŭ �� ������ ���ڿ��� �ٲپ� return �մϴ�.
//����� ��
//numbers	return
//[6, 10, 2]	"6210"
//[3, 30, 34, 5, 9]	"9534330"
//�� ���� - 2021�� 10�� 20�� �׽�Ʈ���̽��� �߰��Ǿ����ϴ�.

using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string solution(int[] numbers)
    {
        string answer = "";
        //List<string> list = new List<string>();
        List<List<string>> listNumber = new List<List<string>>();
        for (int i = 0; i < 10; i++)
        {
            listNumber.Add(new List<string>());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            string strNum = numbers[i].ToString();
            listNumber[int.Parse(strNum.Substring(0, 1))].Add(strNum);
        }

        for (int i = 0; i < listNumber.Count; i++)
        {
            listNumber[i].Sort((a, b) =>
            {
                if (a == b)
                {
                    return 0;
                }
                string ab = a + b;
                string ba = b + a;
                return ba.CompareTo(ab);
            });
        }

        // StringBuilder �� ����
        StringBuilder sb = new StringBuilder();
        for (int i = 9; i >= 0; i--)
        {
            if (listNumber[i].Count > 0)
            {
                for (int j = 0; j < listNumber[i].Count; j++)
                {
                    sb.Append(listNumber[i][j]);
                }
            }
        }

        if (sb.ToString().Substring(0, 1) == "0") // ���ڸ��� 0�̸� ��� 0
        {
            return "0";
        }

        return sb.ToString();
    }
}