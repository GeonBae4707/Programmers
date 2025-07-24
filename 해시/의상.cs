//// https://school.programmers.co.kr/learn/courses/30/lessons/42578

//���� ����
//�ڴϴ� ���� �ٸ� ���� �����Ͽ� �Դ°��� �����մϴ�.

//���� ��� �ڴϰ� ���� ���� �Ʒ��� ����, ���� �ڴϰ� ���׶� �Ȱ�, �� ��Ʈ, �Ķ��� Ƽ������ �Ծ��ٸ� �������� û������ �߰��� �԰ų� ���׶� �Ȱ� ��� ���� ���۶󽺸� �����ϰų� �ؾ��մϴ�.

//����	�̸�
//��	���׶� �Ȱ�, ���� ���۶�
//����	�Ķ��� Ƽ����
//����	û����
//�ѿ�	�� ��Ʈ
//�ڴϴ� �� �������� �ִ� 1���� �ǻ� ������ �� �ֽ��ϴ�. ���� ��� �� ������ ��� ���׶� �Ȱ�� ���� ���۶󽺸� ���ÿ� ������ ���� �����ϴ�.
//������ �ǻ��� �Ϻΰ� ��ġ����, �ٸ� �ǻ��� ��ġ�� �ʰų�, Ȥ�� �ǻ��� �߰��� �� ������ ��쿡�� ���� �ٸ� ������� ���� ������ ������ ����մϴ�.
//�ڴϴ� �Ϸ翡 �ּ� �� ���� �ǻ��� �Խ��ϴ�.
//�ڴϰ� ���� �ǻ���� ��� 2���� �迭 clothes�� �־��� �� ���� �ٸ� ���� ������ ���� return �ϵ��� solution �Լ��� �ۼ����ּ���.

//���ѻ���
//clothes�� �� ���� [�ǻ��� �̸�, �ǻ��� ����] �� �̷���� �ֽ��ϴ�.
//�ڴϰ� ���� �ǻ��� ���� 1�� �̻� 30�� �����Դϴ�.
//���� �̸��� ���� �ǻ��� �������� �ʽ��ϴ�.
//clothes�� ��� ���Ҵ� ���ڿ��� �̷���� �ֽ��ϴ�.
//��� ���ڿ��� ���̴� 1 �̻� 20 ������ �ڿ����̰� ���ĺ� �ҹ��� �Ǵ� '_' �θ� �̷���� �ֽ��ϴ�.
//����� ��
//clothes	return
//[["yellow_hat", "headgear"], ["blue_sunglasses", "eyewear"], ["green_turban", "headgear"]]	5
//[["crow_mask", "face"], ["blue_sunglasses", "face"], ["smoky_makeup", "face"]]  3
//����� �� ����
//���� #1
//headgear�� �ش��ϴ� �ǻ��� yellow_hat, green_turban�̰� eyewear�� �ش��ϴ� �ǻ��� blue_sunglasses�̹Ƿ� �Ʒ��� ���� 5���� ������ �����մϴ�.

//1. yellow_hat
//2. blue_sunglasses
//3. green_turban
//4. yellow_hat + blue_sunglasses
//5. green_turban + blue_sunglasses
//���� #2
//face�� �ش��ϴ� �ǻ��� crow_mask, blue_sunglasses, smoky_makeup�̹Ƿ� �Ʒ��� ���� 3���� ������ �����մϴ�.

//1. crow_mask
//2. blue_sunglasses
//3. smoky_makeup
//�� ���� - 2023�� 4�� 21�� ���� ������ ������Ǿ����ϴ�.


using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[,] clothes)
    {
        int answer = 0;

        // �ǻ� �������� ������ ���� ���� ��ųʸ�
        Dictionary<string, int> dictClothes = new Dictionary<string, int>();
        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            string type = clothes[i, 1];
            if (dictClothes.ContainsKey(type))
            {
                dictClothes[type]++;
            }
            else
            {
                dictClothes[type] = 1;
            }
        }

        // ���� ���
        int combinations = 1;
        foreach (var count in dictClothes.Values)
        {
            // �� ������ �ǻ��� �������� ���� ���� �����Ƿ� +1
            combinations *= (count + 1);
        }

        // �ּ� �� ���� �ǻ��� �����ؾ� �ϹǷ� 1�� ����
        answer = combinations - 1;

        return answer;
    }
}