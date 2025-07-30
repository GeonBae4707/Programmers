//// https://school.programmers.co.kr/learn/courses/30/lessons/155651

//���� ����
//ȣ���� � ���� �ڴϴ� �ּ����� ���Ǹ��� ����Ͽ� ���� �մԵ��� �������� �մϴ�. �� �� ����� ������ ��� �ð��� �������� 10�а� û�Ҹ� �ϰ� ���� �մԵ��� ����� �� �ֽ��ϴ�.
//���� �ð��� ���ڿ� ���·� ��� 2���� �迭 book_time�� �Ű������� �־��� ��, �ڴϿ��� �ʿ��� �ּ� ������ ���� return �ϴ� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//1 �� book_time�� ���� �� 1,000
//book_time[i] ��["HH:MM", "HH:MM"]�� ���·� �̷���� �迭�Դϴ�
//[��� ���� �ð�, ��� ���� �ð�] �����Դϴ�.
//�ð��� HH:MM ���·� 24�ð� ǥ����� ������, "00:00" ���� "23:59" ������ �־����ϴ�.
//���� �ð��� ������ �Ѿ�� ���� �����ϴ�.
//���� �ð��� �׻� ���� �ð����� �����ϴ�.
//����� ��
//book_time	result
//[["15:00", "17:00"], ["16:40", "18:20"], ["14:20", "15:20"], ["14:10", "19:20"], ["18:20", "21:20"]]	3
//[["09:10", "10:10"], ["10:20", "12:20"]]    1
//[["10:20", "12:30"], ["10:20", "12:30"], ["10:20", "12:30"]]    3
//����� �� ����
//����� �� #1

//example1
//�� ������ �����ϴ�.

//����� �� #2

//ù ��° �մ��� 10�� 10�п� ��� �� 10�а� û���� �� �� ��° �մ��� 10�� 20�п� �Խ��Ͽ� ����� �� �����Ƿ� ���� 1���� �ʿ��մϴ�.

//����� �� #3

//�� �մ� ��� ������ �ð��븦 �����߱� ������ 3���� ���� �ʿ��մϴ�.


using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[,] book_time)
    {
        int answer = 0;

        List<bool[]> listRoom = new List<bool[]>();

        //bool[] room = new bool[60 * 24];

        List<int[]> listTime = new List<int[]>();

        for (int i = 0; i < book_time.GetLength(0); i++)
        {
            int start = int.Parse(book_time[i, 0].Substring(0, 2)) * 60 + int.Parse(book_time[i, 0].Substring(3, 2));
            int end = int.Parse(book_time[i, 1].Substring(0, 2)) * 60 + int.Parse(book_time[i, 1].Substring(3, 2)) + 10;
            if (end > 60 * 24)
            {
                end = 60 * 24; // 24�ð��� �Ѿ�� ���� ����
            }
            listTime.Add(new int[] { start, end });
        }

        // ���� ���� ����
        listTime.Sort((a, b) => a[0].CompareTo(b[0]));

        for (int i = 0; i < listTime.Count; i++)
        {
            bool isRoom = false;
            for (int k = 0; k < listRoom.Count; k++)
            {
                bool[] room = listRoom[k];
                bool isUse = false;
                // ���� ��������� Ȯ��
                for (int t = listTime[i][0]; t < listTime[i][1]; t++)
                {
                    if (room[t])
                    {
                        isUse = true;
                        break;
                    }
                }

                // ���� ������� �ƴϸ�
                if (isUse == false)
                {
                    for (int t = listTime[i][0]; t < listTime[i][1]; t++)
                    {
                        room[t] = true;
                    }
                    isRoom = true;
                    break;
                }
            }

            // ����� ���� ������ �߰�
            if (isRoom == false)
            {
                bool[] room = new bool[60 * 24];
                for (int t = listTime[i][0]; t < listTime[i][1]; t++)
                {
                    room[t] = true;
                }
                listRoom.Add(room);
                answer++;
            }
        }

        return answer;
    }
}