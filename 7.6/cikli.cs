using System;
namespace cikl {
    public class cikl {

      public void first() {
        int emails = 20;
        for(; emails >0; emails--) {
          Console.WriteLine ($"one email deleted, {emails} left");
        }
        Console.WriteLine ("INBOX ZERO ACHIVIED!");
      }

      public void second() {
        string num = Console.ReadLine();
        int sum = 0;
        if (Convert.ToInt32(num) < 100) {
          Console.WriteLine("less than 100");
        } else {
          foreach(int i in (num)) {
            sum += i - '0';
          }
          Console.WriteLine(sum);
        }
      }

      public void third() {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        if (num1 < num2) {
          for(int i = num1; i < num2; i++) {
            if(i % 10 == 3) {
              sum++;
            }
          }
        } else {
          for(int i = num1; i > num2; i--) {
            if(i % 10 == 3) {
              sum++;
            }
          }
        }
        Console.WriteLine(sum);
      }

      public void fourth() {
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++) {
          for(int k = 1; k <= num; k++) {
            Console.Write($"{i}*{k} = {i*k}  ");
          }
          Console.WriteLine();
        }
      }
    }
  }
