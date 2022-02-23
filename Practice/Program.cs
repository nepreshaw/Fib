using System;

namespace Practice {
    class Program {
        static void Main(string[] args) {

            //int sum = 0;
            //for (int idx = 1; idx < 1000; idx++) {
            //    if(((idx % 3) == 0) || ((idx % 5) == 0)) {
            //        sum += idx;
            //    }
            //}
            //Console.WriteLine(sum);

            int fib1 = 1;
            int fib2 = 1;
            int result = 0;
            int summed = 0;

            while(result < 4000000) {
                if((result % 2) == 0){
                    summed += result;
                }
                result = fib1 + fib2;
                fib2 = fib1;
                fib1 = result;
            }
            Console.WriteLine(result);



        }
    }
}
