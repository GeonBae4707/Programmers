//���� ����
//���� ������ ö���� �Ƹ޸�ī��� ī�� ���׸� �Ǹ��ϴ� ī�信�� �������� Ŀ�Ǹ� ����� �մϴ�. �Ƹ޸�ī��� ī�� ������ ������ ������ �Ͱ� �߰ſ� �� ������� ���� 4500, 5000���Դϴ�. �� �������� ���� �޴��� ����޶�� �Ͽ���, �� �߿��� �޴��� ���� ������ ���� ������ ������ �����ϰ� "�ƹ��ų�"�� ���� ������ ���� ������ �Ƹ޸�ī��� �����ϱ�� �Ͽ����ϴ�.

//�� ������ ���� �޴��� ���ڿ� �迭 order�� �־��� ��, ī�信�� �����ϰ� �� �ݾ��� return �ϴ� solution �Լ��� �ۼ����ּ���. order�� ���Ҵ� �Ʒ��� �͵鸸 ������, ������ �ǹ̴� ������ �����ϴ�.

//order�� ����	�ǹ�
//"iceamericano", "americanoice"	������ �Ƹ޸�ī��
//"hotamericano", "americanohot"	������ �Ƹ޸�ī��
//"icecafelatte", "cafelatteice"	������ ī�� ����
//"hotcafelatte", "cafelattehot"	������ ī�� ����
//"americano"	�Ƹ޸�ī��
//"cafelatte"	ī�� ����
//"anything"	�ƹ��ų�
//���ѻ���
//1 �� order�� ���� �� 1,000
//����� ��
//order	result
//["cafelatte", "americanoice", "hotcafelatte", "anything"]	19000
//["americanoice", "americano", "iceamericano"]	13500
//����� �� ����
//����� �� #1

//���� 1���� �Է��� ǥ�� ��Ÿ���� ������ �����ϴ�.
//|order[i]|������ ���� ����|���� �ֹ� ����|

//|---|---|---|

//|"cafelatte"|ī�� ����|������ ī�� ����|

//|"americanoice"|������ �Ƹ޸�ī��|������ �Ƹ޸�ī��|

//|"hotcafelatte"|������ ī�� ����|������ ī�� ����|

//|"anything"|�ƹ��ų�|������ �Ƹ޸�ī��|

//ö���� ������ �Ƹ޸�ī�� 2��, ������ ī�� ���� 1��, ������ ī�� ���� 1���� �ֹ��ϰ� �ǹǷ� ���� �ݾ��� 4500 &times; 2 + 5000 &times; 2 = 19000���Դϴ�. ���� 19000�� return �մϴ�.
//����� �� #2

//���� 2���� �Է¿����� ��� ���Ḧ ������ �Ƹ޸�ī��� ��Ű�� �˴ϴ�. ���� ���� �ݾ��� 4500 �� 3 = 13500���̰� 13500�� return �մϴ�.���� ����
//���� ������ ö���� �Ƹ޸�ī��� ī�� ���׸� �Ǹ��ϴ� ī�信�� �������� Ŀ�Ǹ� ����� �մϴ�. �Ƹ޸�ī��� ī�� ������ ������ ������ �Ͱ� �߰ſ� �� ������� ���� 4500, 5000���Դϴ�.
//�� �������� ���� �޴��� ����޶�� �Ͽ���, �� �߿��� �޴��� ���� ������ ���� ������ ������ �����ϰ� "�ƹ��ų�"�� ���� ������ ���� ������ �Ƹ޸�ī��� �����ϱ�� �Ͽ����ϴ�.

//�� ������ ���� �޴��� ���ڿ� �迭 order�� �־��� ��, ī�信�� �����ϰ� �� �ݾ��� return �ϴ� solution �Լ��� �ۼ����ּ���. order�� ���Ҵ� �Ʒ��� �͵鸸 ������, ������ �ǹ̴� ������ �����ϴ�.

//order�� ����	�ǹ�
//"iceamericano", "americanoice"	������ �Ƹ޸�ī��
//"hotamericano", "americanohot"	������ �Ƹ޸�ī��
//"icecafelatte", "cafelatteice"	������ ī�� ����
//"hotcafelatte", "cafelattehot"	������ ī�� ����
//"americano"	�Ƹ޸�ī��
//"cafelatte"	ī�� ����
//"anything"	�ƹ��ų�
//���ѻ���
//1 �� order�� ���� �� 1,000
//����� ��
//order	result
//["cafelatte", "americanoice", "hotcafelatte", "anything"]	19000
//["americanoice", "americano", "iceamericano"]	13500
//����� �� ����
//����� �� #1

//���� 1���� �Է��� ǥ�� ��Ÿ���� ������ �����ϴ�.
//|order[i]|������ ���� ����|���� �ֹ� ����|

//|---|---|---|

//|"cafelatte"|ī�� ����|������ ī�� ����|

//|"americanoice"|������ �Ƹ޸�ī��|������ �Ƹ޸�ī��|

//|"hotcafelatte"|������ ī�� ����|������ ī�� ����|

//|"anything"|�ƹ��ų�|������ �Ƹ޸�ī��|

//ö���� ������ �Ƹ޸�ī�� 2��, ������ ī�� ���� 1��, ������ ī�� ���� 1���� �ֹ��ϰ� �ǹǷ� ���� �ݾ��� 4500 &times; 2 + 5000 &times; 2 = 19000���Դϴ�. ���� 19000�� return �մϴ�.
//����� �� #2

//���� 2���� �Է¿����� ��� ���Ḧ ������ �Ƹ޸�ī��� ��Ű�� �˴ϴ�. ���� ���� �ݾ��� 4500 �� 3 = 13500���̰� 13500�� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[] order)
    {
        List<string> americano = new List<string> { "iceamericano", "americanoice", "hotamericano", "americanohot", "americano", "anything" };
        List<string> cafelatte = new List<string> { "icecafelatte", "cafelatteice", "hotcafelatte", "cafelattehot", "cafelatte" };
        int answer = 0;

        for (int i = 0; i < order.Length; i++)
        {
            if (americano.Contains(order[i]))
            {
                answer += 4500;
            }
            else if (cafelatte.Contains(order[i]))
            {
                answer += 5000;
            }
        }

        return answer;
    }
}