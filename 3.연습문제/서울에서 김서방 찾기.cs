//// https://school.programmers.co.kr/learn/courses/30/lessons/12919

//���� ����
//String�� �迭 seoul�� element�� "Kim"�� ��ġ x�� ã��, "�輭���� x�� �ִ�"�� String�� ��ȯ�ϴ� �Լ�, solution�� �ϼ��ϼ���. seoul�� "Kim"�� ���� �� ���� ��Ÿ���� �߸��� ���� �ԷµǴ� ���� �����ϴ�.

//���� ����
//seoul�� ���� 1 �̻�, 1000 ������ �迭�Դϴ�.
//seoul�� ���Ҵ� ���� 1 �̻�, 20 ������ ���ڿ��Դϴ�.
//"Kim"�� �ݵ�� seoul �ȿ� ���ԵǾ� �ֽ��ϴ�.
//����� ��
//seoul	return
//["Jane", "Kim"]	"�輭���� 1�� �ִ�"���� ����
//String�� �迭 seoul�� element�� "Kim"�� ��ġ x�� ã��, "�輭���� x�� �ִ�"�� String�� ��ȯ�ϴ� �Լ�, solution�� �ϼ��ϼ���. seoul�� "Kim"�� ���� �� ���� ��Ÿ���� �߸��� ���� �ԷµǴ� ���� �����ϴ�.

//���� ����
//seoul�� ���� 1 �̻�, 1000 ������ �迭�Դϴ�.
//seoul�� ���Ҵ� ���� 1 �̻�, 20 ������ ���ڿ��Դϴ�.
//"Kim"�� �ݵ�� seoul �ȿ� ���ԵǾ� �ֽ��ϴ�.
//����� ��
//seoul	return
//["Jane", "Kim"]	"�輭���� 1�� �ִ�"

public class Solution
{
    public string solution(string[] seoul)
    {
        string answer = "";

        for (int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i] == "Kim")
            {
                answer = "�輭���� " + i + "�� �ִ�";
            }
        }

        return answer;
    }
}