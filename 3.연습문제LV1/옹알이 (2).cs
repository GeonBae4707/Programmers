//// https://school.programmers.co.kr/learn/courses/30/lessons/133499

//���� ����
//�Ӿ��̴� �¾ �� 11���� �� ��ī�� ������ �ֽ��ϴ�. ��ī�� ���� "aya", "ye", "woo", "ma" �� ���� ������ �� ���� ������ �����ؼ� ���� �� �ִ� �����ۿ� ���� ���ϰ� �����ؼ� ���� ������ �ϴ� ���� ������մϴ�. ���ڿ� �迭 babbling�� �Ű������� �־��� ��, �Ӿ����� ��ī�� ������ �� �ִ� �ܾ��� ������ return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� babbling�� ���� �� 100
//1 �� babbling[i]�� ���� �� 30
//���ڿ��� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//����� ��
//babbling	result
//["aya", "yee", "u", "maa"]	1
//["ayaye", "uuu", "yeye", "yemawoo", "ayaayaa"]	2
//����� �� ����
//����� �� #1

//["aya", "yee", "u", "maa"]���� ������ �� �ִ� ���� "aya"���Դϴ�. ���� 1�� return�մϴ�.
//����� �� #2

//["ayaye", "uuu", "yeye", "yemawoo", "ayaayaa"]���� ������ �� �ִ� ���� "aya" + "ye" = "ayaye", "ye" + "ma" + "woo" = "yemawoo"�� 2���Դϴ�. "yeye"�� ���� ������ ���ӵǹǷ� ������ �� �����ϴ�. ���� 2�� return�մϴ�.
//���ǻ���
//�� ������ �ٿ� ���� �� �ִ� ���� �̿ܿ��� � ������ �� �� ���� ������ �����մϴ�. ���� ��� "woowo"�� "woo"�� ������ �� ������ "wo"�� ������ �� ���� ������ �� �� ���� �����Դϴ�.
//�� ���� - 2024�� 2�� 20�� ���� ������ ��Ż�ڰ� �����Ǿ����ϴ�.���� ����
//�Ӿ��̴� �¾ �� 11���� �� ��ī�� ������ �ֽ��ϴ�. ��ī�� ���� "aya", "ye", "woo", "ma" �� ���� ������ �� ���� ������ �����ؼ� ���� �� �ִ� �����ۿ� ���� ���ϰ� �����ؼ� ���� ������ �ϴ� ���� ������մϴ�. ���ڿ� �迭 babbling�� �Ű������� �־��� ��, �Ӿ����� ��ī�� ������ �� �ִ� �ܾ��� ������ return�ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� babbling�� ���� �� 100
//1 �� babbling[i]�� ���� �� 30
//���ڿ��� ���ĺ� �ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//����� ��
//babbling	result
//["aya", "yee", "u", "maa"]	1
//["ayaye", "uuu", "yeye", "yemawoo", "ayaayaa"]	2
//����� �� ����
//����� �� #1

//["aya", "yee", "u", "maa"]���� ������ �� �ִ� ���� "aya"���Դϴ�. ���� 1�� return�մϴ�.
//����� �� #2

//["ayaye", "uuu", "yeye", "yemawoo", "ayaayaa"]���� ������ �� �ִ� ���� "aya" + "ye" = "ayaye", "ye" + "ma" + "woo" = "yemawoo"�� 2���Դϴ�. "yeye"�� ���� ������ ���ӵǹǷ� ������ �� �����ϴ�. ���� 2�� return�մϴ�.
//���ǻ���
//�� ������ �ٿ� ���� �� �ִ� ���� �̿ܿ��� � ������ �� �� ���� ������ �����մϴ�. ���� ��� "woowo"�� "woo"�� ������ �� ������ "wo"�� ������ �� ���� ������ �� �� ���� �����Դϴ�.
//�� ���� - 2024�� 2�� 20�� ���� ������ ��Ż�ڰ� �����Ǿ����ϴ�.

// 1 11 14 17 20

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[] babbling)
    {
        string[] words = { "aya", "ye", "woo", "ma" };
        int answer = 0;
        List<string> list = new List<string>();

        for (int i = 0; i < babbling.GetLength(0); i++)
        {
            list.Clear();

            for (int j = 0; j < babbling[i].Length; j++)
            {
                for (int k = 0; k < words.Length; k++)
                {
                    if (babbling[i].Length - j >= words[k].Length && babbling[i].Substring(j, words[k].Length) == words[k])
                    {
                        babbling[i] = babbling[i].Remove(j, words[k].Length);
                        list.Add(words[k]);
                        k = -1;
                    }
                }
            }

            babbling[i] = babbling[i].Replace(" ", "");

            if (list.Count > 0 && babbling[i] == "")
            {
                bool b = false;
                for (int r = 0; r < list.Count - 1; r++)
                {
                    if (list[r] == list[r + 1])
                    {
                        b = true;
                        break;
                    }
                }
                if (b == false)
                {
                    answer++;
                }
            }
        }

        return answer;
    }
}