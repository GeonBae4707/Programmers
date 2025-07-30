//// https://school.programmers.co.kr/learn/courses/30/lessons/152996

//���� ����
//��� ���� �����Ϳ��� �üҰ� �ϳ� ��ġ�Ǿ� �ֽ��ϴ�. �� �üҴ� �߽����κ��� 2(m), 3(m), 4(m) �Ÿ��� ������ �¼��� �ϳ��� �ֽ��ϴ�.
//�� �üҸ� �� ���� ���� ���� ź�ٰ� �� ��, �üҰ� ������ ���¿��� ������ ���� �üҿ� �ɸ��� ��ũ�� ũ�Ⱑ ���� ���Ǿ� ������ ������ �̷� �� �ִٸ� �� �� ����� �ü� ¦���̶�� �մϴ�. ��, ž���� ����� ���Կ� �ü� ��� �¼� ���� �Ÿ��� ���� ���� �� ���ٸ� �ü� ¦���̶�� �� �� �ֽ��ϴ�.
//������� ������ ��� weights�� �־��� ��, �ü� ¦���� �� �� �����ϴ��� ���Ͽ� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���� ����
//2 �� weights�� ���� �� 100,000
//100 �� weights[i] �� 1,000
//������ ������ N(����)���� �־����ϴ�.
//�����Դ� ��� �����Դϴ�.
//����� ��
//weights	result
//[100,180,360,100,270]	4
//����� �� ����
//{100, 100} �� ���� ���� �Ÿ��� ���ֺ��� ������ ������ �̷�ϴ�.
//{180, 360} �� ���� 4(m), 2(m) �Ÿ��� ���ֺ��� ������ ������ �̷�ϴ�.
//{180, 270} �� ���� 3(m), 2(m) �Ÿ��� ���ֺ��� ������ ������ �̷�ϴ�.
//{270, 360} �� ���� 4(m), 3(m) �Ÿ��� ���ֺ��� ������ ������ �̷�ϴ�.���� ����
//��� ���� �����Ϳ��� �üҰ� �ϳ� ��ġ�Ǿ� �ֽ��ϴ�. �� �üҴ� �߽����κ��� 2(m), 3(m), 4(m) �Ÿ��� ������ �¼��� �ϳ��� �ֽ��ϴ�.
//�� �üҸ� �� ���� ���� ���� ź�ٰ� �� ��, �üҰ� ������ ���¿��� ������ ���� �üҿ� �ɸ��� ��ũ�� ũ�Ⱑ ���� ���Ǿ� ������ ������ �̷� �� �ִٸ� �� �� ����� �ü� ¦���̶�� �մϴ�. ��, ž���� ����� ���Կ� �ü� ��� �¼� ���� �Ÿ��� ���� ���� �� ���ٸ� �ü� ¦���̶�� �� �� �ֽ��ϴ�.
//������� ������ ��� weights�� �־��� ��, �ü� ¦���� �� �� �����ϴ��� ���Ͽ� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���� ����
//2 �� weights�� ���� �� 100,000
//100 �� weights[i] �� 1,000
//������ ������ N(����)���� �־����ϴ�.
//�����Դ� ��� �����Դϴ�.
//����� ��
//weights	result
//[100,180,360,100,270]	4
//����� �� ����
//{100, 100} �� ���� ���� �Ÿ��� ���ֺ��� ������ ������ �̷�ϴ�.
//{180, 360} �� ���� 4(m), 2(m) �Ÿ��� ���ֺ��� ������ ������ �̷�ϴ�.
//{180, 270} �� ���� 3(m), 2(m) �Ÿ��� ���ֺ��� ������ ������ �̷�ϴ�.
//{270, 360} �� ���� 4(m), 3(m) �Ÿ��� ���ֺ��� ������ ������ �̷�ϴ�.



using System;

public class Solution
{
    public long solution(int[] weights)
    {
        long answer = 0;

        int[] arrayDistance = new int[4001];
        int[] arrayCount = new int[1001];

        for (int i = 0; i < weights.Length; i++)
        {
            answer += arrayDistance[weights[i] * 2];
            answer += arrayDistance[weights[i] * 3];
            answer += arrayDistance[weights[i] * 4];

            if (arrayCount[weights[i]] > 0)     // �������Դ� 3�� �߰��Ǵ� 2���� ����
            {
                answer -= arrayCount[weights[i]] * 2;
            }

            arrayCount[weights[i]]++;   // ���� ī��Ʈ
            arrayDistance[weights[i] * 2]++;   // �Ÿ� ī��Ʈ
            arrayDistance[weights[i] * 3]++;
            arrayDistance[weights[i] * 4]++;
        }

        return answer;
    }
}




//using System;

//public class Solution
//{
//    public long solution(int[] weights)
//    {
//        long answer = 0;

//        int[] weight2 = new int[weights.Length];
//        int[] weight3 = new int[weights.Length];
//        int[] weight4 = new int[weights.Length];

//        for (int i = 0; i < weights.Length; i++)
//        {
//            weight2[i] = weights[i] * 2;
//            weight3[i] = weights[i] * 3;
//            weight4[i] = weights[i] * 4;
//        }

//        for (int i = 0; i < weights.Length; i++)
//        {
//            for (int j = i + 1; j < weights.Length; j++)
//            {
//                if (weights[i] == weights[j] ||
//                    weight2[i] == weight3[j] || weight2[i] == weight4[j] ||
//                    weight3[i] == weight2[j] || weight3[i] == weight4[j] ||
//                    weight4[i] == weight2[j] || weight4[i] == weight3[j])
//                {
//                    answer++;
//                    continue;
//                }
//            }
//        }

//        return answer;
//    }
//}