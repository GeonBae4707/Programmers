//���� ����
//���ڿ� myString�� pat�� �־����ϴ�. myString�� �κ� ���ڿ��� pat�� ������ ���� �� �κ� ���ڿ��� ã�Ƽ� return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//���ѻ���
//5 �� myString �� 20
//1 �� pat �� 5
//pat�� �ݵ�� myString�� �κ� ���ڿ��� �־����ϴ�.
//myString�� pat�� �����ϴ� ���ĺ��� �빮�ڿ� �ҹ��ڸ� �����մϴ�.
//����� ��
//myString	pat	result
//"AbCdEFG"	"dE"	"AbCdE"
//"AAAAaaaa"	"a"	"AAAAaaaa"
//����� �� ����
//����� �� #1

//"AbCdEFG"���� "dE"�� �� �� �����ϸ� ó������ �ش� ��ġ���� �߶󳻸� "AbCdE"�� �˴ϴ�.
//���� �� ���ڿ��� "dE"�� ������ ���� �� ���ڿ��̸�, "AbCdE"�� return �մϴ�.
//����� �� #2

//"AAAAaaaa"���� "a"�� �� �� �� �����ϸ� �� �� ���� �������� �ִ� ��ġ���� �߶󳻸� "AAAAaaaa"�� �˴ϴ�.
//���� �� ���ڿ��� "a"�� ������ ���� �� ���ڿ��̸�, "AAAAaaaa"�� return �մϴ�.


using System;

public class Solution
{
    public string solution(string myString, string pat)
    {
        return myString.Substring(0, myString.LastIndexOf(pat) + pat.Length);
    }
}