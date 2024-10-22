//문제 설명
//두 정수 a, b가 주어질 때 다음과 같은 형태의 계산식을 출력하는 코드를 작성해 보세요.

//a + b = c
//제한사항
//1 ≤ a, b ≤ 100
//입출력 예
//입력 #1

//4 5
//출력 #1

//4 + 5 = 9

using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        Console.WriteLine($"{a} + {b} = {a + b}");
    }
}