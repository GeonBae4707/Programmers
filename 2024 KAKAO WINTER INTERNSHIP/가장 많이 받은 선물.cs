////// https://school.programmers.co.kr/learn/courses/30/lessons/258712

//선물을 직접 전하기 힘들 때 카카오톡 선물하기 기능을 이용해 축하 선물을 보낼 수 있습니다. 당신의 친구들이 이번 달까지 선물을 주고받은 기록을 바탕으로 다음 달에 누가 선물을 많이 받을지 예측하려고 합니다.

//두 사람이 선물을 주고받은 기록이 있다면, 이번 달까지 두 사람 사이에 더 많은 선물을 준 사람이 다음 달에 선물을 하나 받습니다.
//예를 들어 A가 B에게 선물을 5번 줬고, B가 A에게 선물을 3번 줬다면 다음 달엔 A가 B에게 선물을 하나 받습니다.
//두 사람이 선물을 주고받은 기록이 하나도 없거나 주고받은 수가 같다면, 선물 지수가 더 큰 사람이 선물 지수가 더 작은 사람에게 선물을 하나 받습니다.
//선물 지수는 이번 달까지 자신이 친구들에게 준 선물의 수에서 받은 선물의 수를 뺀 값입니다.
//예를 들어 A가 친구들에게 준 선물이 3개고 받은 선물이 10개라면 A의 선물 지수는 -7입니다. B가 친구들에게 준 선물이 3개고 받은 선물이 2개라면 B의 선물 지수는 1입니다. 만약 A와 B가 선물을 주고받은 적이 없거나 정확히 같은 수로 선물을 주고받았다면, 다음 달엔 B가 A에게 선물을 하나 받습니다.
//만약 두 사람의 선물 지수도 같다면 다음 달에 선물을 주고받지 않습니다.
//위에서 설명한 규칙대로 다음 달에 선물을 주고받을 때, 당신은 선물을 가장 많이 받을 친구가 받을 선물의 수를 알고 싶습니다.

//친구들의 이름을 담은 1차원 문자열 배열 friends 이번 달까지 친구들이 주고받은 선물 기록을 담은 1차원 문자열 배열 gifts가 매개변수로 주어집니다. 이때, 다음달에 가장 많은 선물을 받는 친구가 받을 선물의 수를 return 하도록 solution 함수를 완성해 주세요.

//제한사항
//2 ≤ friends의 길이 = 친구들의 수 ≤ 50
//friends의 원소는 친구의 이름을 의미하는 알파벳 소문자로 이루어진 길이가 10 이하인 문자열입니다.
//이름이 같은 친구는 없습니다.
//1 ≤ gifts의 길이 ≤ 10,000
//gifts의 원소는 "A B"형태의 문자열입니다. A는 선물을 준 친구의 이름을 B는 선물을 받은 친구의 이름을 의미하며 공백 하나로 구분됩니다.
//A와 B는 friends의 원소이며 A와 B가 같은 이름인 경우는 존재하지 않습니다.
//입출력 예
//friends	gifts	result
//["muzi", "ryan", "frodo", "neo"]	["muzi frodo", "muzi frodo", "ryan muzi", "ryan muzi", "ryan muzi", "frodo muzi", "frodo ryan", "neo muzi"]	2
//["joy", "brad", "alessandro", "conan", "david"]	["alessandro brad", "alessandro joy", "alessandro conan", "david alessandro", "alessandro david"]	4
//["a", "b", "c"]	["a b", "b a", "c a", "a c", "a c", "c a"]	0
//입출력 예 설명
//입출력 예 #1

//주고받은 선물과 선물 지수를 표로 나타내면 다음과 같습니다.

//↓준 사람 \ 받은 사람→	muzi	ryan	frodo	neo
//muzi	-	0	2	0
//ryan	3	-	0	0
//frodo	1	1	-	0
//neo	1	0	0	-
//이름	준 선물	받은 선물	선물 지수
//muzi	2	5	-3
//ryan	3	1	2
//frodo	2	2	0
//neo	1	0	1
//muzi는 선물을 더 많이 줬던 frodo에게서 선물을 하나 받습니다.
//ryan은 선물을 더 많이 줬던 muzi에게서 선물을 하나 받고, 선물을 주고받지 않았던 neo보다 선물 지수가 커 선물을 하나 받습니다.
//frodo는 선물을 더 많이 줬던 ryan에게 선물을 하나 받습니다.
//neo는 선물을 더 많이 줬던 muzi에게서 선물을 하나 받고, 선물을 주고받지 않았던 frodo보다 선물 지수가 커 선물을 하나 받습니다.

//다음달에 가장 선물을 많이 받는 사람은 ryan과 neo이고 2개의 선물을 받습니다. 따라서 2를 return 해야 합니다.

//입출력 예 #2

//주고받은 선물과 선물 지수를 표로 나타내면 다음과 같습니다.

//↓준 사람 \ 받은 사람→	joy	brad	alessandro	conan	david
//joy	-	0	0	0	0
//brad	0	-	0	0	0
//alessandro	1	1	-	1	1
//conan	0	0	0	-	0
//david	0	0	1	0	-
//이름	준 선물	받은 선물	선물 지수
//joy	0	1	-1
//brad	0	1	-1
//alessandro	4	1	3
//conan	0	1	-1
//david	1	1	0
//alessandro가 선물을 더 많이 줬던 joy, brad, conan에게서 선물을 3개 받습니다. 선물을 하나씩 주고받은 david보다 선물 지수가 커 선물을 하나 받습니다.
//david는 선물을 주고받지 않았던 joy, brad, conan보다 선물 지수가 커 다음 달에 선물을 3개 받습니다.
//joy, brad, conan은 선물을 받지 못합니다.

//다음달에 가장 선물을 많이 받는 사람은 alessandro이고 4개의 선물을 받습니다. 따라서 4를 return 해야 합니다.

//입출력 예 #3

//a와 b, a와 c, b와 c 사이에 서로 선물을 주고받은 수도 같고 세 사람의 선물 지수도 0으로 같아 다음 달엔 아무도 선물을 받지 못합니다. 따라서 0을 return 해야 합니다.선물을 직접 전하기 힘들 때 카카오톡 선물하기 기능을 이용해 축하 선물을 보낼 수 있습니다. 당신의 친구들이 이번 달까지 선물을 주고받은 기록을 바탕으로 다음 달에 누가 선물을 많이 받을지 예측하려고 합니다.

//두 사람이 선물을 주고받은 기록이 있다면, 이번 달까지 두 사람 사이에 더 많은 선물을 준 사람이 다음 달에 선물을 하나 받습니다.
//예를 들어 A가 B에게 선물을 5번 줬고, B가 A에게 선물을 3번 줬다면 다음 달엔 A가 B에게 선물을 하나 받습니다.
//두 사람이 선물을 주고받은 기록이 하나도 없거나 주고받은 수가 같다면, 선물 지수가 더 큰 사람이 선물 지수가 더 작은 사람에게 선물을 하나 받습니다.
//선물 지수는 이번 달까지 자신이 친구들에게 준 선물의 수에서 받은 선물의 수를 뺀 값입니다.
//예를 들어 A가 친구들에게 준 선물이 3개고 받은 선물이 10개라면 A의 선물 지수는 -7입니다. B가 친구들에게 준 선물이 3개고 받은 선물이 2개라면 B의 선물 지수는 1입니다. 만약 A와 B가 선물을 주고받은 적이 없거나 정확히 같은 수로 선물을 주고받았다면, 다음 달엔 B가 A에게 선물을 하나 받습니다.
//만약 두 사람의 선물 지수도 같다면 다음 달에 선물을 주고받지 않습니다.
//위에서 설명한 규칙대로 다음 달에 선물을 주고받을 때, 당신은 선물을 가장 많이 받을 친구가 받을 선물의 수를 알고 싶습니다.

//친구들의 이름을 담은 1차원 문자열 배열 friends 이번 달까지 친구들이 주고받은 선물 기록을 담은 1차원 문자열 배열 gifts가 매개변수로 주어집니다. 이때, 다음달에 가장 많은 선물을 받는 친구가 받을 선물의 수를 return 하도록 solution 함수를 완성해 주세요.

//제한사항
//2 ≤ friends의 길이 = 친구들의 수 ≤ 50
//friends의 원소는 친구의 이름을 의미하는 알파벳 소문자로 이루어진 길이가 10 이하인 문자열입니다.
//이름이 같은 친구는 없습니다.
//1 ≤ gifts의 길이 ≤ 10,000
//gifts의 원소는 "A B"형태의 문자열입니다. A는 선물을 준 친구의 이름을 B는 선물을 받은 친구의 이름을 의미하며 공백 하나로 구분됩니다.
//A와 B는 friends의 원소이며 A와 B가 같은 이름인 경우는 존재하지 않습니다.
//입출력 예
//friends	gifts	result
//["muzi", "ryan", "frodo", "neo"]	["muzi frodo", "muzi frodo", "ryan muzi", "ryan muzi", "ryan muzi", "frodo muzi", "frodo ryan", "neo muzi"]	2
//["joy", "brad", "alessandro", "conan", "david"]	["alessandro brad", "alessandro joy", "alessandro conan", "david alessandro", "alessandro david"]	4
//["a", "b", "c"]	["a b", "b a", "c a", "a c", "a c", "c a"]	0
//입출력 예 설명
//입출력 예 #1

//주고받은 선물과 선물 지수를 표로 나타내면 다음과 같습니다.

//↓준 사람 \ 받은 사람→	muzi	ryan	frodo	neo
//muzi	-	0	2	0
//ryan	3	-	0	0
//frodo	1	1	-	0
//neo	1	0	0	-
//이름	준 선물	받은 선물	선물 지수
//muzi	2	5	-3
//ryan	3	1	2
//frodo	2	2	0
//neo	1	0	1
//muzi는 선물을 더 많이 줬던 frodo에게서 선물을 하나 받습니다.
//ryan은 선물을 더 많이 줬던 muzi에게서 선물을 하나 받고, 선물을 주고받지 않았던 neo보다 선물 지수가 커 선물을 하나 받습니다.
//frodo는 선물을 더 많이 줬던 ryan에게 선물을 하나 받습니다.
//neo는 선물을 더 많이 줬던 muzi에게서 선물을 하나 받고, 선물을 주고받지 않았던 frodo보다 선물 지수가 커 선물을 하나 받습니다.

//다음달에 가장 선물을 많이 받는 사람은 ryan과 neo이고 2개의 선물을 받습니다. 따라서 2를 return 해야 합니다.

//입출력 예 #2

//주고받은 선물과 선물 지수를 표로 나타내면 다음과 같습니다.

//↓준 사람 \ 받은 사람→	joy	brad	alessandro	conan	david
//joy	-	0	0	0	0
//brad	0	-	0	0	0
//alessandro	1	1	-	1	1
//conan	0	0	0	-	0
//david	0	0	1	0	-
//이름	준 선물	받은 선물	선물 지수
//joy	0	1	-1
//brad	0	1	-1
//alessandro	4	1	3
//conan	0	1	-1
//david	1	1	0
//alessandro가 선물을 더 많이 줬던 joy, brad, conan에게서 선물을 3개 받습니다. 선물을 하나씩 주고받은 david보다 선물 지수가 커 선물을 하나 받습니다.
//david는 선물을 주고받지 않았던 joy, brad, conan보다 선물 지수가 커 다음 달에 선물을 3개 받습니다.
//joy, brad, conan은 선물을 받지 못합니다.

//다음달에 가장 선물을 많이 받는 사람은 alessandro이고 4개의 선물을 받습니다. 따라서 4를 return 해야 합니다.

//입출력 예 #3

//a와 b, a와 c, b와 c 사이에 서로 선물을 주고받은 수도 같고 세 사람의 선물 지수도 0으로 같아 다음 달엔 아무도 선물을 받지 못합니다. 따라서 0을 return 해야 합니다.


using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[] friends, string[] gifts)
    {
        Dictionary<string, Dictionary<string, int>> dictGift = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<string, int> dictPoint = new Dictionary<string, int>();
        Dictionary<string, int> dictCount = new Dictionary<string, int>();

        // 선물정보를 저장할 위치를 초기화
        for (int i = 0; i < friends.Length; i++)
        {
            dictGift.Add(friends[i], new Dictionary<string, int>());
            for (int j = 0; j < friends.Length; j++)
            {
                dictGift[friends[i]].Add(friends[j], 0);
            }

            dictPoint.Add(friends[i], 0);
            dictCount.Add(friends[i], 0);
        }

        // 선물 기록을 처리
        for (int i = 0; i < gifts.GetLength(0); i++)
        {
            string[] gift = gifts[i].Split(' ');

            if (dictGift[gift[0]].ContainsKey(gift[1]))
            {
                dictGift[gift[0]][gift[1]]++;
            }

            dictPoint[gift[0]]++;
            dictPoint[gift[1]]--;
        }

        for (int i = 0; i < friends.Length; i++)
        {
            for (int j = i + 1; j < friends.Length; j++)
            {
                if (dictGift[friends[i]][friends[j]] > dictGift[friends[j]][friends[i]])
                {
                    dictCount[friends[i]]++;
                }
                else if (dictGift[friends[i]][friends[j]] < dictGift[friends[j]][friends[i]])
                {
                    dictCount[friends[j]]++;
                }
                else
                {
                    if (dictPoint[friends[i]] < dictPoint[friends[j]])
                    {
                        dictCount[friends[j]]++;
                    }
                    else if (dictPoint[friends[i]] > dictPoint[friends[j]])
                    {
                        dictCount[friends[i]]++;
                    }
                }
            }
        }

        int maxCount = 0;
        for (int i = 0; i < friends.Length; i++)
        {
            if (dictCount[friends[i]] > maxCount)
            {
                maxCount = dictCount[friends[i]];
            }
        }

        return maxCount;
    }
}