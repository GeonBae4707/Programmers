//// https://school.programmers.co.kr/learn/courses/30/lessons/178871

//���� ����
//�ῡ���� �ų� �޸��� ���ְ� �����ϴ�. �ؼ������� �������� �ڱ� �ٷ� ���� ������ �߿��� �� �߿��� ������ �̸��� �θ��ϴ�. ���� ��� 1����� 3����� "mumu", "soe", "poe" �������� ������� �޸��� ���� ��, �ؼ����� "soe"������ �ҷ��ٸ� 2���� "soe" ������ 1���� "mumu" ������ �߿��ߴٴ� ���Դϴ�. �� "soe" ������ 1��, "mumu" ������ 2������ �ٲ�ϴ�.

//�������� �̸��� 1����� ���� ��� ������� ��� ���ڿ� �迭 players�� �ؼ����� �θ� �̸��� ���� ���ڿ� �迭 callings�� �Ű������� �־��� ��, ���ְ� ������ �� �������� �̸��� 1����� ��� ������� �迭�� ��� return �ϴ� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//5 �� players�� ���� �� 50,000
//players[i]�� i��° ������ �̸��� �ǹ��մϴ�.
//players�� ���ҵ��� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//players���� �ߺ��� ���� �� ���� �ʽ��ϴ�.
//3 �� players[i]�� ���� �� 10
//2 �� callings�� ���� �� 1,000,000
//callings�� players�� ���ҵ�θ� �̷���� �ֽ��ϴ�.
//���� ������ 1���� ������ �̸��� �Ҹ��� �ʽ��ϴ�.
//����� ��
//players	callings	result
//["mumu", "soe", "poe", "kai", "mine"]	["kai", "kai", "mine", "mine"]	["mumu", "kai", "mine", "soe", "poe"]
//����� �� ����
//����� �� #1

//4���� "kai" ������ 2�� �߿��Ͽ� 2���� �ǰ� �ռ� 3��, 2���� "poe", "soe" ������ 4��, 3���� �˴ϴ�. 5���� "mine" ������ 2�� �߿��Ͽ� 4��, 3���� "poe", "soe" ������ 5��, 4���� �ǰ� ���ְ� �����ϴ�. 1����� �迭�� ������ ["mumu", "kai", "mine", "soe", "poe"]�� �˴ϴ�.���� ����
//�ῡ���� �ų� �޸��� ���ְ� �����ϴ�. �ؼ������� �������� �ڱ� �ٷ� ���� ������ �߿��� �� �߿��� ������ �̸��� �θ��ϴ�. ���� ��� 1����� 3����� "mumu", "soe", "poe" �������� ������� �޸��� ���� ��, �ؼ����� "soe"������ �ҷ��ٸ� 2���� "soe" ������ 1���� "mumu" ������ �߿��ߴٴ� ���Դϴ�. �� "soe" ������ 1��, "mumu" ������ 2������ �ٲ�ϴ�.

//�������� �̸��� 1����� ���� ��� ������� ��� ���ڿ� �迭 players�� �ؼ����� �θ� �̸��� ���� ���ڿ� �迭 callings�� �Ű������� �־��� ��, ���ְ� ������ �� �������� �̸��� 1����� ��� ������� �迭�� ��� return �ϴ� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//5 �� players�� ���� �� 50,000
//players[i]�� i��° ������ �̸��� �ǹ��մϴ�.
//players�� ���ҵ��� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//players���� �ߺ��� ���� �� ���� �ʽ��ϴ�.
//3 �� players[i]�� ���� �� 10
//2 �� callings�� ���� �� 1,000,000
//callings�� players�� ���ҵ�θ� �̷���� �ֽ��ϴ�.
//���� ������ 1���� ������ �̸��� �Ҹ��� �ʽ��ϴ�.
//����� ��
//players	callings	result
//["mumu", "soe", "poe", "kai", "mine"]	["kai", "kai", "mine", "mine"]	["mumu", "kai", "mine", "soe", "poe"]
//����� �� ����
//����� �� #1

//4���� "kai" ������ 2�� �߿��Ͽ� 2���� �ǰ� �ռ� 3��, 2���� "poe", "soe" ������ 4��, 3���� �˴ϴ�. 5���� "mine" ������ 2�� �߿��Ͽ� 4��, 3���� "poe", "soe" ������ 5��, 4���� �ǰ� ���ְ� �����ϴ�. 1����� �迭�� ������ ["mumu", "kai", "mine", "soe", "poe"]�� �˴ϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] players, string[] callings)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for (int i = 0; i < players.Length; i++)
        {
            dict.Add(players[i], i);
        }

        for (int i = 0; i < callings.Length; i++)
        {
            int rank = dict[callings[i]];

            string temp = players[rank - 1];
            players[rank - 1] = callings[i];
            players[rank] = temp;

            dict[callings[i]] = rank - 1;
            dict[temp] = rank;
        }

        return players;
    }
}