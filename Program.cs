public class Program{
    public static void Main(string[] args){
        Write1ThroughN_While(4);
        Console.WriteLine(" ");
        Write1ThroughN_For(7);
        Console.WriteLine(" ");
        WriteNThrough1_While(-1);
        Console.WriteLine(" ");
        WriteNThrough1_For(25);
        Console.WriteLine(" ");
        WriteEvensThrough100();
        Console.WriteLine(" ");
        FindSum(-3);
        FindSumOfEvenNumbers(9);
        FindSumOfOddNumbers(-4);
        OutputRightTriangle(100);
        OutputRightTriangle(-99);
    }
    public static void Write1ThroughN_While(int n){
        int i = 1;
        if(n >= 1){
            while(i <= n){
                Console.Write(i + " ");
                i = i + 1;
            }
        }else{
            OutOfRangeMessage(n);
        }
    }
    public static void Write1ThroughN_For(int n){
        if(n >= 1){
            for (int i = 1; i <= n; i++){
                Console.Write(i + " ");
            }
        }else{
            OutOfRangeMessage(n);
        }
    }
    public static void WriteNThrough1_While(int n){
        if(n >= 1){
            while(n >= 1){
                Console.Write(n + " ");
                    n = n - 1;
            }
        }else{
            OutOfRangeMessage(n);
        }
    }
    public static void WriteNThrough1_For(int n){
        if(n >= 1){
            for(int i = n; i >=1; i--){
                Console.Write(i + " ");

            }
        }else{
            OutOfRangeMessage(n);
        }
    }
    public static void WriteEvensThrough100(){
        
        for(int i = 1; i<=100; i++){
            if(i % 2 == 0){
                Console.Write(i + " ");
            }
        }
    }
    public static void FindSum(int n){
        int sum = 0;
        if(n > 1){
            for(int i = 1; i <= n; i++){
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }else if(n < 1){
            for(int i = -1; i >= n; i--){
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }else{
            Console.WriteLine(0);
        }
    }
    public static void FindSumOfEvenNumbers(int n){
        int sum = 0;
        if(n > 1){
            for(int i = 1; i <= n; i++){
                if(i % 2 == 0){
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }else if(n < 1){
            for(int i = -1; i >= n; i--){
                if(i % 2 == 0){
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }else{
            Console.WriteLine(0);
        }
    }
    public static void FindSumOfOddNumbers(int n){
        int sum = 0;
        if(n > 1){
            for(int i = 1; i <= n; i++){
                if(i % 2 != 0){
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }else if(n < 1){
            for(int i = -1; i >= n; i--){
                if(i % 2 != 0){
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }else{
            Console.WriteLine(0);
        }
    }
    public static void OutputRightTriangle(int _base){
        if(_base > 0){
            int i = 0;
            int n = 0;
            for(i = 1; i <= _base; i++){
                for(n = 1; n <= i; n++){
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }else if(_base < 0){
            int i = 0;
            int n = 0;
            for(i = _base + 1; i <= 1; i++){
                for(n = i + 1; n <= 1; n++){
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }else{
            OutOfRangeMessage(_base);
        }
    }
    public static void OutOfRangeMessage(int n){
        Console.Write(n + " is out of range.");
    }
}

