//// https://school.programmers.co.kr/learn/courses/30/lessons/159994

//���� ����
//�ڴϴ� ���� �ܾ ���� ī�� ��ġ �� ���� ������ �޾ҽ��ϴ�. �ڴϴ� ������ ���� ��Ģ���� ī�忡 ���� �ܾ���� ����� ���ϴ� ������ �ܾ� �迭�� ���� �� �ִ��� �˰� �ͽ��ϴ�.

//���ϴ� ī�� ��ġ���� ī�带 ������� �� �徿 ����մϴ�.
//�� �� ����� ī��� �ٽ� ����� �� �����ϴ�.
//ī�带 ������� �ʰ� ���� ī��� �Ѿ �� �����ϴ�.
//������ �־��� ī�� ��ġ�� �ܾ� ������ �ٲ� �� �����ϴ�.
//���� ��� ù ��° ī�� ��ġ�� ������� ["i", "drink", "water"], �� ��° ī�� ��ġ�� ������� ["want", "to"]�� �������� �� ["i", "want", "to", "drink", "water"] ������ �ܾ� �迭�� ������� �Ѵٸ� ù ��° ī�� ��ġ���� "i"�� ����� �� �� ��° ī�� ��ġ���� "want"�� "to"�� ����ϰ� ù ��° ī�并ġ�� "drink"�� "water"�� ���ʴ�� ����ϸ� ���ϴ� ������ �ܾ� �迭�� ���� �� �ֽ��ϴ�.

//���ڿ��� �̷���� �迭 cards1, cards2�� ���ϴ� �ܾ� �迭 goal�� �Ű������� �־��� ��, cards1�� cards2�� ���� �ܾ��� goal�� ���� �ִٸ� "Yes"��, ���� �� ���ٸ� "No"�� return�ϴ� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� cards1�� ����, cards2�� ���� �� 10
//1 �� cards1[i]�� ����, cards2[i]�� ���� �� 10
//cards1�� cards2���� ���� �ٸ� �ܾ �����մϴ�.
//2 �� goal�� ���� �� cards1�� ���� + cards2�� ����
//1 �� goal[i]�� ���� �� 10
//goal�� ���Ҵ� cards1�� cards2�� ���ҵ�θ� �̷���� �ֽ��ϴ�.
//cards1, cards2, goal�� ���ڿ����� ��� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//����� ��
//cards1	cards2	goal	result
//["i", "drink", "water"]	["want", "to"]	["i", "want", "to", "drink", "water"]	"Yes"
//["i", "water", "drink"]	["want", "to"]	["i", "want", "to", "drink", "water"]	"No"
//����� �� ����
//����� �� #1

//������ �����ϴ�.

//����� �� #2

//cards1���� "i"�� ����ϰ� cards2���� "want"�� "to"�� ����Ͽ� "i want to"������ ���� �� ������ "water"�� "drink"���� ���� ���Ǿ�� �ϱ� ������ �ش� ������ �ϼ���ų �� �����ϴ�. ���� "No"�� ��ȯ�մϴ�.���� ����
//�ڴϴ� ���� �ܾ ���� ī�� ��ġ �� ���� ������ �޾ҽ��ϴ�. �ڴϴ� ������ ���� ��Ģ���� ī�忡 ���� �ܾ���� ����� ���ϴ� ������ �ܾ� �迭�� ���� �� �ִ��� �˰� �ͽ��ϴ�.

//���ϴ� ī�� ��ġ���� ī�带 ������� �� �徿 ����մϴ�.
//�� �� ����� ī��� �ٽ� ����� �� �����ϴ�.
//ī�带 ������� �ʰ� ���� ī��� �Ѿ �� �����ϴ�.
//������ �־��� ī�� ��ġ�� �ܾ� ������ �ٲ� �� �����ϴ�.
//���� ��� ù ��° ī�� ��ġ�� ������� ["i", "drink", "water"], �� ��° ī�� ��ġ�� ������� ["want", "to"]�� �������� �� ["i", "want", "to", "drink", "water"] ������ �ܾ� �迭�� ������� �Ѵٸ� ù ��° ī�� ��ġ���� "i"�� ����� �� �� ��° ī�� ��ġ���� "want"�� "to"�� ����ϰ� ù ��° ī�并ġ�� "drink"�� "water"�� ���ʴ�� ����ϸ� ���ϴ� ������ �ܾ� �迭�� ���� �� �ֽ��ϴ�.

//���ڿ��� �̷���� �迭 cards1, cards2�� ���ϴ� �ܾ� �迭 goal�� �Ű������� �־��� ��, cards1�� cards2�� ���� �ܾ��� goal�� ���� �ִٸ� "Yes"��, ���� �� ���ٸ� "No"�� return�ϴ� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� cards1�� ����, cards2�� ���� �� 10
//1 �� cards1[i]�� ����, cards2[i]�� ���� �� 10
//cards1�� cards2���� ���� �ٸ� �ܾ �����մϴ�.
//2 �� goal�� ���� �� cards1�� ���� + cards2�� ����
//1 �� goal[i]�� ���� �� 10
//goal�� ���Ҵ� cards1�� cards2�� ���ҵ�θ� �̷���� �ֽ��ϴ�.
//cards1, cards2, goal�� ���ڿ����� ��� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//����� ��
//cards1	cards2	goal	result
//["i", "drink", "water"]	["want", "to"]	["i", "want", "to", "drink", "water"]	"Yes"
//["i", "water", "drink"]	["want", "to"]	["i", "want", "to", "drink", "water"]	"No"
//����� �� ����
//����� �� #1

//������ �����ϴ�.

//����� �� #2

//cards1���� "i"�� ����ϰ� cards2���� "want"�� "to"�� ����Ͽ� "i want to"������ ���� �� ������ "water"�� "drink"���� ���� ���Ǿ�� �ϱ� ������ �ش� ������ �ϼ���ų �� �����ϴ�. ���� "No"�� ��ȯ�մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        List<string> listgoal = new List<string>(goal);
        List<string> listcards1 = new List<string>(cards1);
        List<string> listcards2 = new List<string>(cards2);

        while (listgoal.Count > 0)
        {
            if (listcards1.Count > 0 && listgoal[0] == listcards1[0])
            {
                listgoal.RemoveAt(0);
                listcards1.RemoveAt(0);
            }
            else if (listcards2.Count > 0 && listgoal[0] == listcards2[0])
            {
                listgoal.RemoveAt(0);
                listcards2.RemoveAt(0);
            }
            else
            {
                return "No";
            }
        }
        return "Yes";
    }
}