//������ ���ڿ��� �־����� �� ���� "a", "b", "c"�� �����ڷ� ����� ���ڿ��� �������� �մϴ�.

//���� ��� �־��� ���ڿ��� "baconlettucetomato"��� ������ ���ڿ� ����� ["onlettu", "etom", "to"] �� �˴ϴ�.

//���ڿ� myStr�� �־����� �� �� ���ÿ� ���� "a", "b", "c"�� ����� ������ ���ڿ��� ������� ������ �迭�� return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//��, �� ������ ���̿� �ٸ� ���ڰ� ���� ��쿡�� �ƹ��͵� �������� ������, return�� �迭�� �� �迭�̶�� ["EMPTY"]�� return �մϴ�.

//���ѻ���
//1 �� myStr�� ���� �� 1,000,000
//myStr�� ���ĺ� �ҹ��ڷ� �̷���� ���ڿ� �Դϴ�.
//����� ��
//myStr	result
//"baconlettucetomato"	["onlettu", "etom", "to"]
//"abcd"	["d"]
//"cabab"	["EMPTY"]
//����� �� ����
//����� �� #1

//���� ������ ���ÿ� �����ϴ�.
//����� �� #2

//"c" �������� "a", "b", "c" �̿��� ���ڰ� �����ϴ�.
//"c" ���Ŀ� ���ڿ� "d"�� �����Ƿ� "d"�� �����մϴ�.
//���� ["d"]�� return �մϴ�.
//����� �� #3

//"a", "b", "c" �̿��� ���ڰ� �������� �ʽ��ϴ�. ���� ������ ���ڿ��� �����ϴ�.
//���� ["EMPTY"]�� return �մϴ�.
//�� ���� - 2024�� 9�� 9�� �׽�Ʈ���̽��� �߰� �Ǿ����ϴ�. ������ ������ �ڵ尡 ������� ���� ���� �ֽ��ϴ�.

using System;

public class Solution
{
    public string[] solution(string myStr)
    {
        string[] answer = myStr.Split(new char[] { 'a', 'b', 'c' }, StringSplitOptions.RemoveEmptyEntries);
        if (answer == null || answer.Length == 0)
        {
            return new string[] { "EMPTY" };
        }
        return answer;
    }
}