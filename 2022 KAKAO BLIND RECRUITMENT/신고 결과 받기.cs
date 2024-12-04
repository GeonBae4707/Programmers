//// https://school.programmers.co.kr/learn/courses/30/lessons/92334

//���� ����
//���Ի�� ������ �Խ��� �ҷ� �̿��ڸ� �Ű��ϰ� ó�� ����� ���Ϸ� �߼��ϴ� �ý����� �����Ϸ� �մϴ�. ������ �����Ϸ��� �ý����� ������ �����ϴ�.

//�� ������ �� ���� �� ���� ������ �Ű��� �� �ֽ��ϴ�.
//�Ű� Ƚ���� ������ �����ϴ�. ���� �ٸ� ������ ����ؼ� �Ű��� �� �ֽ��ϴ�.
//�� ������ ���� �� �Ű��� ���� ������, ������ ������ ���� �Ű� Ƚ���� 1ȸ�� ó���˴ϴ�.
//k�� �̻� �Ű�� ������ �Խ��� �̿��� �����Ǹ�, �ش� ������ �Ű��� ��� �������� ���� ����� ���Ϸ� �߼��մϴ�.
//������ �Ű��� ��� ������ �����Ͽ� �������� �Ѳ����� �Խ��� �̿� ������ ��Ű�鼭 ���� ������ �߼��մϴ�.
//������ ��ü ���� ����� ["muzi", "frodo", "apeach", "neo"]�̰�, k = 2(��, 2�� �̻� �Ű���ϸ� �̿� ����)�� ����� �����Դϴ�.

//���� ID	������ �Ű��� ID	����
//"muzi"	"frodo"	"muzi"�� "frodo"�� �Ű��߽��ϴ�.
//"apeach"	"frodo"	"apeach"�� "frodo"�� �Ű��߽��ϴ�.
//"frodo"	"neo"	"frodo"�� "neo"�� �Ű��߽��ϴ�.
//"muzi"	"neo"	"muzi"�� "neo"�� �Ű��߽��ϴ�.
//"apeach"	"muzi"	"apeach"�� "muzi"�� �Ű��߽��ϴ�.
//�� �������� �Ű���� Ƚ���� ������ �����ϴ�.

//���� ID	�Ű���� Ƚ��
//"muzi"	1
//"frodo"	2
//"apeach"	0
//"neo"	2
//�� ���ÿ����� 2�� �̻� �Ű���� "frodo"�� "neo"�� �Խ��� �̿��� �����˴ϴ�. �̶�, �� �������� �Ű��� ���̵�� ������ ���̵� �����ϸ� ������ �����ϴ�.

//���� ID	������ �Ű��� ID	������ ID
//"muzi"	["frodo", "neo"]	["frodo", "neo"]
//"frodo"	["neo"]	["neo"]
//"apeach"	["muzi", "frodo"]	["frodo"]
//"neo"	����	����
//���� "muzi"�� ó�� ��� ������ 2ȸ, "frodo"�� "apeach"�� ���� ó�� ��� ������ 1ȸ �ް� �˴ϴ�.

//�̿����� ID�� ��� ���ڿ� �迭 id_list, �� �̿��ڰ� �Ű��� �̿����� ID ������ ��� ���ڿ� �迭 report, ���� ������ �Ǵ� �Ű� Ƚ�� k�� �Ű������� �־��� ��, �� �������� ó�� ��� ������ ���� Ƚ���� �迭�� ��� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//2 �� id_list�� ���� �� 1,000
//1 �� id_list�� ���� ���� �� 10
//id_list�� ���Ҵ� �̿����� id�� ��Ÿ���� ���ڿ��̸� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//id_list���� ���� ���̵� �ߺ��ؼ� ������� �ʽ��ϴ�.
//1 �� report�� ���� �� 200,000
//3 �� report�� ���� ���� �� 21
//report�� ���Ҵ� "�̿���id �Ű���id"������ ���ڿ��Դϴ�.
//���� ��� "muzi frodo"�� ��� "muzi"�� "frodo"�� �Ű��ߴٴ� �ǹ��Դϴ�.
//id�� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//�̿���id�� �Ű���id�� ����(�����̽�)�ϳ��� ���еǾ� �ֽ��ϴ�.
//�ڱ� �ڽ��� �Ű��ϴ� ���� �����ϴ�.
//1 �� k �� 200, k�� �ڿ����Դϴ�.
//return �ϴ� �迭�� id_list�� ��� id ������� �� ������ ���� ��� ���� ���� ������ �˴ϴ�.
//����� ��
//id_list	report	k	result
//["muzi", "frodo", "apeach", "neo"]	["muzi frodo","apeach frodo","frodo neo","muzi neo","apeach muzi"]	2	[2,1,1,0]
//["con", "ryan"]	["ryan con", "ryan con", "ryan con", "ryan con"]	3	[0,0]
//����� �� ����
//����� �� #1

//������ ���ÿ� �����ϴ�.

//����� �� #2

//"ryan"�� "con"�� 4�� �Ű�������, �־��� ���ǿ� ���� �� ������ ���� ������ ���� �� �Ű��� ���� �Ű� Ƚ�� 1ȸ�� ó���մϴ�. ���� "con"�� 1ȸ �Ű���߽��ϴ�. 3�� �̻� �Ű���� �̿��ڴ� ������, "con"�� "ryan"�� ��� ������ ���� �ʽ��ϴ�. ���� [0, 0]�� return �մϴ�.

//���ѽð� �ȳ�
//��Ȯ�� �׽�Ʈ : 10�ʹ��� ����
//���Ի�� ������ �Խ��� �ҷ� �̿��ڸ� �Ű��ϰ� ó�� ����� ���Ϸ� �߼��ϴ� �ý����� �����Ϸ� �մϴ�. ������ �����Ϸ��� �ý����� ������ �����ϴ�.

//�� ������ �� ���� �� ���� ������ �Ű��� �� �ֽ��ϴ�.
//�Ű� Ƚ���� ������ �����ϴ�. ���� �ٸ� ������ ����ؼ� �Ű��� �� �ֽ��ϴ�.
//�� ������ ���� �� �Ű��� ���� ������, ������ ������ ���� �Ű� Ƚ���� 1ȸ�� ó���˴ϴ�.
//k�� �̻� �Ű�� ������ �Խ��� �̿��� �����Ǹ�, �ش� ������ �Ű��� ��� �������� ���� ����� ���Ϸ� �߼��մϴ�.
//������ �Ű��� ��� ������ �����Ͽ� �������� �Ѳ����� �Խ��� �̿� ������ ��Ű�鼭 ���� ������ �߼��մϴ�.
//������ ��ü ���� ����� ["muzi", "frodo", "apeach", "neo"]�̰�, k = 2(��, 2�� �̻� �Ű���ϸ� �̿� ����)�� ����� �����Դϴ�.

//���� ID	������ �Ű��� ID	����
//"muzi"	"frodo"	"muzi"�� "frodo"�� �Ű��߽��ϴ�.
//"apeach"	"frodo"	"apeach"�� "frodo"�� �Ű��߽��ϴ�.
//"frodo"	"neo"	"frodo"�� "neo"�� �Ű��߽��ϴ�.
//"muzi"	"neo"	"muzi"�� "neo"�� �Ű��߽��ϴ�.
//"apeach"	"muzi"	"apeach"�� "muzi"�� �Ű��߽��ϴ�.
//�� �������� �Ű���� Ƚ���� ������ �����ϴ�.

//���� ID	�Ű���� Ƚ��
//"muzi"	1
//"frodo"	2
//"apeach"	0
//"neo"	2
//�� ���ÿ����� 2�� �̻� �Ű���� "frodo"�� "neo"�� �Խ��� �̿��� �����˴ϴ�. �̶�, �� �������� �Ű��� ���̵�� ������ ���̵� �����ϸ� ������ �����ϴ�.

//���� ID	������ �Ű��� ID	������ ID
//"muzi"	["frodo", "neo"]	["frodo", "neo"]
//"frodo"	["neo"]	["neo"]
//"apeach"	["muzi", "frodo"]	["frodo"]
//"neo"	����	����
//���� "muzi"�� ó�� ��� ������ 2ȸ, "frodo"�� "apeach"�� ���� ó�� ��� ������ 1ȸ �ް� �˴ϴ�.

//�̿����� ID�� ��� ���ڿ� �迭 id_list, �� �̿��ڰ� �Ű��� �̿����� ID ������ ��� ���ڿ� �迭 report, ���� ������ �Ǵ� �Ű� Ƚ�� k�� �Ű������� �־��� ��, �� �������� ó�� ��� ������ ���� Ƚ���� �迭�� ��� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//2 �� id_list�� ���� �� 1,000
//1 �� id_list�� ���� ���� �� 10
//id_list�� ���Ҵ� �̿����� id�� ��Ÿ���� ���ڿ��̸� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//id_list���� ���� ���̵� �ߺ��ؼ� ������� �ʽ��ϴ�.
//1 �� report�� ���� �� 200,000
//3 �� report�� ���� ���� �� 21
//report�� ���Ҵ� "�̿���id �Ű���id"������ ���ڿ��Դϴ�.
//���� ��� "muzi frodo"�� ��� "muzi"�� "frodo"�� �Ű��ߴٴ� �ǹ��Դϴ�.
//id�� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//�̿���id�� �Ű���id�� ����(�����̽�)�ϳ��� ���еǾ� �ֽ��ϴ�.
//�ڱ� �ڽ��� �Ű��ϴ� ���� �����ϴ�.
//1 �� k �� 200, k�� �ڿ����Դϴ�.
//return �ϴ� �迭�� id_list�� ��� id ������� �� ������ ���� ��� ���� ���� ������ �˴ϴ�.
//����� ��
//id_list	report	k	result
//["muzi", "frodo", "apeach", "neo"]	["muzi frodo","apeach frodo","frodo neo","muzi neo","apeach muzi"]	2	[2,1,1,0]
//["con", "ryan"]	["ryan con", "ryan con", "ryan con", "ryan con"]	3	[0,0]
//����� �� ����
//����� �� #1

//������ ���ÿ� �����ϴ�.

//����� �� #2

//"ryan"�� "con"�� 4�� �Ű�������, �־��� ���ǿ� ���� �� ������ ���� ������ ���� �� �Ű��� ���� �Ű� Ƚ�� 1ȸ�� ó���մϴ�. ���� "con"�� 1ȸ �Ű���߽��ϴ�. 3�� �̻� �Ű���� �̿��ڴ� ������, "con"�� "ryan"�� ��� ������ ���� �ʽ��ϴ�. ���� [0, 0]�� return �մϴ�.

//���ѽð� �ȳ�
//��Ȯ�� �׽�Ʈ : 10��


using System;
using System.Collections.Generic;

public class Solution
{
    public class User
    {
        public int ID = 0;
        public int nReportCount = 0;
        public List<string> reportList = new List<string>();
        public int nBanCount = 0;

        public User(int _ID)
        {
            ID = _ID;
        }
    }

    public int[] solution(string[] id_list, string[] report, int k)
    {
        int[] answer = new int[id_list.GetLength(0)];
        Dictionary<string, User> dict = new Dictionary<string, User>();

        for (int i = 0; i < id_list.GetLength(0); i++)
        {
            dict.Add(id_list[i], new User(i));
        }

        for (int i = 0; i < report.GetLength(0); i++)
        {
            string[] split = report[i].Split(' ');
            if (dict[split[1]].reportList.Contains(split[0]))
            {
                continue;
            }
            dict[split[1]].reportList.Add(split[0]);
            dict[split[1]].nReportCount++;
        }

        List<string> listBan = new List<string>();
        foreach (KeyValuePair<string, User> pair in dict)
        {
            if (pair.Value.nReportCount >= k)
            {
                listBan.Add(pair.Key);
            }
        }

        for (int i = 0; i < id_list.GetLength(0); i++)
        {
            if (listBan.Contains(id_list[i]))
            {
                for( int j = 0; j < dict[id_list[i]].reportList.Count; j++)
                {
                    dict[dict[id_list[i]].reportList[j]].nBanCount++;
                }
            }
        }

        foreach(KeyValuePair<string, User> pair in dict)
        {
            answer[pair.Value.ID] = pair.Value.nBanCount;
        }

        return answer;
    }
}