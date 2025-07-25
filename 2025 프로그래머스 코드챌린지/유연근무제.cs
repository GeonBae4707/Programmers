//문제 설명
//프로그래머스 사이트를 운영하는 그렙에서는 재택근무와 함께 출근 희망 시각을 자유롭게 정하는 유연근무제를 시행하고 있습니다. 제도 정착을 위해 오늘부터 일주일 동안 각자 설정한 출근 희망 시각에 늦지 않고 출근한 직원들에게 상품을 주는 이벤트를 진행하려고 합니다.

//직원들은 일주일동안 자신이 설정한 출근 희망 시각 + 10분까지 어플로 출근해야 합니다. 예를 들어 출근 희망 시각이 9시 58분인 직원은 10시 8분까지 출근해야 합니다. 단, 토요일, 일요일의 출근 시각은 이벤트에 영향을 끼치지 않습니다. 직원들은 매일 한 번씩만 어플로 출근하고, 모든 시각은 시에 100을 곱하고 분을 더한 정수로 표현됩니다. 예를 들어 10시 13분은 1013이 되고 9시 58분은 958이 됩니다.

//당신은 직원들이 설정한 출근 희망 시각과 실제로 출근한 기록을 바탕으로 상품을 받을 직원이 몇 명인지 알고 싶습니다.

//직원 n명이 설정한 출근 희망 시각을 담은 1차원 정수 배열 schedules, 직원들이 일주일 동안 출근한 시각을 담은 2차원 정수 배열 timelogs, 이벤트를 시작한 요일을 의미하는 정수 startday가 매개변수로 주어집니다. 이때 상품을 받을 직원의 수를 return 하도록 solution 함수를 완성해주세요.

//제한사항
//1 ≤ schedules의 길이 = n ≤ 1,000
//schedules[i]는 i + 1번째 직원이 설정한 출근 희망 시각을 의미합니다.
//700 ≤ schedules[i] ≤ 1100
//1 ≤ timelogs의 길이 = n ≤ 1,000
//timelogs[i]의 길이 = 7
//timelogs[i][j]는 i + 1번째 직원이 이벤트 j + 1일차에 출근한 시각을 의미합니다.
//600 ≤ timelogs[i][j] ≤ 2359
//1 ≤ startday ≤ 7
//1은 월요일, 2는 화요일, 3은 수요일, 4는 목요일, 5는 금요일, 6은 토요일, 7은 일요일에 이벤트를 시작했음을 의미합니다.
//출근 희망 시각과 실제로 출근한 시각을 100으로 나눈 나머지는 59 이하입니다.
//테스트 케이스 구성 안내
//아래는 테스트 케이스 구성을 나타냅니다. 각 그룹 내의 테스트 케이스를 모두 통과하면 해당 그룹에 할당된 점수를 획득할 수 있습니다.

//그룹	총점	추가 제한 사항
//#1	10%	n = 1. 이벤트 시작일이 월요일이고, 출근 희망 시각이 정각으로 된 입력만 주어집니다.
//#2	10%	이벤트 시작일이 월요일이고, 출근 희망 시각이 정각으로 된 입력만 주어집니다.
//#3	15%	출근 희망 시각이 정각으로 된 입력만 주어집니다.
//#4	15%	이벤트 시작일이 월요일인 입력만 주어집니다.
//#5	50%	제한사항 외 추가조건이 없습니다.
//입출력 예
//schedules	timelogs	startday	result
//[700, 800, 1100]	[[710, 2359, 1050, 700, 650, 631, 659], [800, 801, 805, 800, 759, 810, 809], [1105, 1001, 1002, 600, 1059, 1001, 1100]]	5	3
//[730, 855, 700, 720]	[[710, 700, 650, 735, 700, 931, 912], [908, 901, 805, 815, 800, 831, 835], [705, 701, 702, 705, 710, 710, 711], [707, 731, 859, 913, 934, 931, 905]]	1	2
//입출력 예 설명
//입출력 예 #1

//이벤트를 시작한 날은 금요일입니다. 직원 3명의 일주일 간 출근 시각을 나타내면 다음과 같습니다.

//출근 희망 시각	출근 인정 시각
//7:00	7:10
//8:00	8:10
//11:00	11:10
//금	토	일	월	화	수	목
//7:10	23:59	10:50	7:00	6:50	6:31	6:59
//8:00	8:01	8:05	8:00	7:59	8:10	8:09
//11:05	10:01	10:02	6:00	10:59	10:01	11:00
//모든 직원이 평일에 늦지 않고 출근했습니다. 따라서 상품을 받을 직원은 3명입니다.

//입출력 예 #2

//이벤트를 시작한 날은 월요일입니다. 직원 4명의 일주일 간 출근 시각을 나타내면 다음과 같습니다. 취소선으로 표시된 시각이 출근이 필요한 평일에 지각한 날입니다.

//출근 희망 시각	출근 인정 시각
//7:30	7:40
//8:55	9:05
//7:00	7:10
//7:20	7:30
//월	화	수	목	금	토	일
//7:10	7:00	6:50	7:35	7:00	9:31	9:12
//9:08	9:01	8:05	8:15	8:00	8:31	8:35
//7:05	7:01	7:02	7:05	7:10	7:10	7:11
//7:07	7:31	8:59	9:13	9:34	9:31	9:05
//첫 번째, 세 번째 직원이 평일에 늦지 않고 출근했습니다. 따라서 상품을 받을 직원은 2명입니다.문제 설명
//프로그래머스 사이트를 운영하는 그렙에서는 재택근무와 함께 출근 희망 시각을 자유롭게 정하는 유연근무제를 시행하고 있습니다. 제도 정착을 위해 오늘부터 일주일 동안 각자 설정한 출근 희망 시각에 늦지 않고 출근한 직원들에게 상품을 주는 이벤트를 진행하려고 합니다.

//직원들은 일주일동안 자신이 설정한 출근 희망 시각 + 10분까지 어플로 출근해야 합니다. 예를 들어 출근 희망 시각이 9시 58분인 직원은 10시 8분까지 출근해야 합니다. 단, 토요일, 일요일의 출근 시각은 이벤트에 영향을 끼치지 않습니다. 직원들은 매일 한 번씩만 어플로 출근하고, 모든 시각은 시에 100을 곱하고 분을 더한 정수로 표현됩니다. 예를 들어 10시 13분은 1013이 되고 9시 58분은 958이 됩니다.

//당신은 직원들이 설정한 출근 희망 시각과 실제로 출근한 기록을 바탕으로 상품을 받을 직원이 몇 명인지 알고 싶습니다.

//직원 n명이 설정한 출근 희망 시각을 담은 1차원 정수 배열 schedules, 직원들이 일주일 동안 출근한 시각을 담은 2차원 정수 배열 timelogs, 이벤트를 시작한 요일을 의미하는 정수 startday가 매개변수로 주어집니다. 이때 상품을 받을 직원의 수를 return 하도록 solution 함수를 완성해주세요.

//제한사항
//1 ≤ schedules의 길이 = n ≤ 1,000
//schedules[i]는 i + 1번째 직원이 설정한 출근 희망 시각을 의미합니다.
//700 ≤ schedules[i] ≤ 1100
//1 ≤ timelogs의 길이 = n ≤ 1,000
//timelogs[i]의 길이 = 7
//timelogs[i][j]는 i + 1번째 직원이 이벤트 j + 1일차에 출근한 시각을 의미합니다.
//600 ≤ timelogs[i][j] ≤ 2359
//1 ≤ startday ≤ 7
//1은 월요일, 2는 화요일, 3은 수요일, 4는 목요일, 5는 금요일, 6은 토요일, 7은 일요일에 이벤트를 시작했음을 의미합니다.
//출근 희망 시각과 실제로 출근한 시각을 100으로 나눈 나머지는 59 이하입니다.
//테스트 케이스 구성 안내
//아래는 테스트 케이스 구성을 나타냅니다. 각 그룹 내의 테스트 케이스를 모두 통과하면 해당 그룹에 할당된 점수를 획득할 수 있습니다.

//그룹	총점	추가 제한 사항
//#1	10%	n = 1. 이벤트 시작일이 월요일이고, 출근 희망 시각이 정각으로 된 입력만 주어집니다.
//#2	10%	이벤트 시작일이 월요일이고, 출근 희망 시각이 정각으로 된 입력만 주어집니다.
//#3	15%	출근 희망 시각이 정각으로 된 입력만 주어집니다.
//#4	15%	이벤트 시작일이 월요일인 입력만 주어집니다.
//#5	50%	제한사항 외 추가조건이 없습니다.
//입출력 예
//schedules	timelogs	startday	result
//[700, 800, 1100]	[[710, 2359, 1050, 700, 650, 631, 659], [800, 801, 805, 800, 759, 810, 809], [1105, 1001, 1002, 600, 1059, 1001, 1100]]	5	3
//[730, 855, 700, 720]	[[710, 700, 650, 735, 700, 931, 912], [908, 901, 805, 815, 800, 831, 835], [705, 701, 702, 705, 710, 710, 711], [707, 731, 859, 913, 934, 931, 905]]	1	2
//입출력 예 설명
//입출력 예 #1

//이벤트를 시작한 날은 금요일입니다. 직원 3명의 일주일 간 출근 시각을 나타내면 다음과 같습니다.

//출근 희망 시각	출근 인정 시각
//7:00	7:10
//8:00	8:10
//11:00	11:10
//금	토	일	월	화	수	목
//7:10	23:59	10:50	7:00	6:50	6:31	6:59
//8:00	8:01	8:05	8:00	7:59	8:10	8:09
//11:05	10:01	10:02	6:00	10:59	10:01	11:00
//모든 직원이 평일에 늦지 않고 출근했습니다. 따라서 상품을 받을 직원은 3명입니다.

//입출력 예 #2

//이벤트를 시작한 날은 월요일입니다. 직원 4명의 일주일 간 출근 시각을 나타내면 다음과 같습니다. 취소선으로 표시된 시각이 출근이 필요한 평일에 지각한 날입니다.

//출근 희망 시각	출근 인정 시각
//7:30	7:40
//8:55	9:05
//7:00	7:10
//7:20	7:30
//월	화	수	목	금	토	일
//7:10	7:00	6:50	7:35	7:00	9:31	9:12
//9:08	9:01	8:05	8:15	8:00	8:31	8:35
//7:05	7:01	7:02	7:05	7:10	7:10	7:11
//7:07	7:31	8:59	9:13	9:34	9:31	9:05
//첫 번째, 세 번째 직원이 평일에 늦지 않고 출근했습니다. 따라서 상품을 받을 직원은 2명입니다.


using System;

public class Solution
{
    public int solution(int[] schedules, int[,] timelogs, int startday)
    {
        int answer = 0;
        int nSaturday = 6;
        int nSunday = 7;

        // 직원수만큼 반복
        for (int i = 0; i < schedules.Length; i++)
        {
            // 출근기록
            for (int x = 0; x < timelogs.GetLength(1); x++)
            {
                // 주말은 필요 없음
                int nHoliday = x + startday;
                if (nHoliday > nSunday)
                {
                    nHoliday -= 7;
                }
                if (nHoliday != nSaturday && nHoliday != nSunday)
                {
                    int nEndTime = schedules[i] + 10;

                    // 분이 60이 넘으면 시간 증가
                    if (nEndTime % 100 >= 60)
                    {
                        nEndTime += 40;
                    }

                    // 한번이라도 지각이면 패스
                    if (timelogs[i, x] > nEndTime)
                    {
                        break;
                    }
                }

                // 마지막검사까지 지각 안함
                if (x == 6)
                {
                    answer++;
                }
            }
        }

        return answer;
    }
}