using System;

class HelloWorld
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Introduceti un numar de la 1 la 17 pentru a selecta o problema");
        int n = -1;
        while (!(n >= 1 && n <= 17))
        {
            try {n = Convert.ToInt32(Console.ReadLine());}
            catch
            {
                Console.WriteLine("Introduceti un *numar* de la 1 la 17 pentru a selecta o problema");
                continue;
            }
        }

        switch(n)
        {
            case 1: P1(); break;
            case 2: P2(); break;
            case 3: P3(); break;
            case 4: P4(); break;
            case 5: P5(); break;
            case 6: P6(); break;
            case 7: P7(); break;
            case 8: P8(); break;
            case 9: P9(); break;
            case 10: P10(); break;
            case 11: P11(); break;
            case 12: P12(); break;
            case 13: P13(); break;
            case 14: P14(); break;
            case 15: P15(); break;
            case 16: P16(); break;
            case 17: P17(); break;
        }
    }

    public static void P1() {
        Console.WriteLine("Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");
        String[] tokens = Console.ReadLine().Split(' ');

        int oddNumbers = 0;
        for (int i = 0; i < tokens.Length; i++)
        {
            int n = Convert.ToInt32(tokens[i]);
            if (n % 2 == 0) oddNumbers++;
        }
        
        Console.WriteLine("Numere pare: " + oddNumbers);
    }
    public static void P2() {
        Console.WriteLine("Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.");
        String[] tokens = Console.ReadLine().Split(' ');

        int negativeCount = 0;
        int zeroCount = 0;
        int positiveCount = 0;

        for (int i = 0; i < tokens.Length; i++)
        {
            int n = Convert.ToInt32(tokens[i]);
            if (n == 0) zeroCount++;
            else if (n < 0) negativeCount++;
            else positiveCount++;
        }

        Console.WriteLine("Numere negative:" + negativeCount
                            + "\nNumere egale cu 0: " +zeroCount
                            + "\nNumere pozitive: " + positiveCount);
    }
    public static void P3() { 
        Console.WriteLine("Calculati suma si produsul numerelor de la 1 la n.");
        long n = Convert.ToInt64(Console.ReadLine());

        long product = 1;
        for (int i = 1; i <= n; i++) product *= i;
        
        Console.WriteLine("Suma: " + ((n * (n + 1)) / 2) + 
                          "\nProdus: " + product);
    }
    public static void P4() {
        Console.WriteLine("Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. " +
                          "Se considera ca primul element din secventa este pe pozitia zero. " +
                          "Daca numarul nu se afla in secventa raspunsul va fi -1.");
        String[] tokens = Console.ReadLine().Split(' ');
     
        //a va fi ultimul numar din secventa
        int a = Convert.ToInt32(tokens[tokens.Length - 1]);
        int i = 0;
        while (i != tokens.Length - 2 && a != Convert.ToInt32(tokens[i]))
        {
            if (Convert.ToInt32(tokens[tokens.Length - 2]) != a)
                Console.WriteLine("-1");
            i++;
        }
    }
    public static void P5() { 
        Console.WriteLine("Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. " +
                          "Se considera ca primul element din secventa este pe pozitia 0.");
        String[] tokens = Console.ReadLine().Split(' ');

        int counter = 0;
        for (int i = 0; i < tokens.Length; i++)
            counter = (Convert.ToInt32(tokens[i]) == i) ? counter += 1 : counter += 0;
        
        Console.WriteLine(counter);
    }
    public static void P6() {
        Console.WriteLine("Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
        String[] tokens = Console.ReadLine().Split(' ');

        bool increasing = true;
        for (int i = 1; i < tokens.Length; i++) 
            if (Convert.ToInt32(tokens[i - 1]) > Convert.ToInt32(tokens[i]))
                increasing = false;

        if (increasing) Console.WriteLine("Elementele sunt in ordine crescatoare");
        else Console.WriteLine("Elementele *nu sunt* in ordine crescatoare");
    }
    public static void P7() {
        Console.WriteLine("Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.");
        String[] tokens = Console.ReadLine().Split(' ');

        int min = Convert.ToInt32(tokens[0]);
        int max = Convert.ToInt32(tokens[0]);

        for (int i = 0; i < tokens.Length; i++)
        {
            if (Convert.ToInt32(tokens[i]) > max) max = Convert.ToInt32(tokens[i]);
            if (Convert.ToInt32(tokens[i]) < min) min = Convert.ToInt32(tokens[i]);
        }

        Console.WriteLine("Minim: " + min + "\nMaxim: " + max);
    }
    public static void P8() {
        Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se " +
                          "construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n + ": " + fib(n));
        
        static int fib(int n)
        {
            if (n == 1) return n;
            else if (n == 0) return 0;
            else return fib(n - 1) + fib(n - 2);
        }
    }


    public static void P9() {
        Console.WriteLine("Sa se determine daca o secventa de n numere este monotona.Secventa monotona = secventa " +
                          "monoton crescatoare sau monoton descrescatoare.");
        String[] tokens = Console.ReadLine().Split(' ');

        bool increasing = true;
        bool decreasing = true;

        for (int i = 1; i < tokens.Length; i++)
            if (Convert.ToInt32(tokens[i - 1]) > Convert.ToInt32(tokens[i]))
                increasing = false;
            else if (Convert.ToInt32(tokens[i - 1]) < Convert.ToInt32(tokens[i]))
                decreasing = false;

        if (increasing && decreasing) Console.WriteLine("Necunoscut");
        else if (increasing) Console.WriteLine("Secventa crescatoare");
        else if (decreasing) Console.WriteLine("Secventa descrescatoare");
        else Console.WriteLine("Necunoscut");


    }
    public static void P10() {
        Console.WriteLine("Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
        String[] tokens = Console.ReadLine().Split(' ');

        int max = 1;
        int counter = 1;
        for (int i = 1; i < tokens.Length; i++)
        {
            if (Convert.ToInt32(tokens[i - 1]) == Convert.ToInt32(tokens[i]))
                counter++;
            else
                counter = 1;
            if (counter > max) max = counter;
        }

        Console.WriteLine("Numar maxim de nr consecutiv egale: " + max);
    }
    public static void P11() {
        Console.WriteLine("Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.");
        String[] tokens = Console.ReadLine().Split(' ');

        double sum = 0;
        foreach (String number in tokens) sum += 1.0 / Convert.ToDouble(number);

        Console.WriteLine(sum);
    }
    public static void P12() {
        Console.WriteLine("Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. " +
                          "Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. " +
                          "De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.");
        String[] tokens = Console.ReadLine().Split(' ');
        String a = "";
        foreach (String t in tokens) a += t;
        String[] b = a.Split('0');

        //tabloul b va avea valori formate din numere ("1234") si spatii libere ("")
        int counter = 0;
        foreach (String t in b) if (!t.Equals("")) counter++;

        Console.WriteLine("Numar de secvente: " + counter);
    }
    public static void P13() {
        
        Console.WriteLine("O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau " +
                          "poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o " +
                          "pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine " +
                          "ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
        
        String[] tokens = Console.ReadLine().Split(' ');

        int[] numbers = new int[tokens.Length];
        for(int i = 0; i < tokens.Length; i++) numbers[i] = Convert.ToInt32(tokens[i]);

        bool increasing = true;
        //o secventa poate fi crescatoare doar daca primul element != ultimul element
        if (numbers[0] == numbers[numbers.Length - 1]) increasing = false;
        else
        {
            for (int i = 1; i < numbers.Length - 1; i++)
                if (numbers[i - 1] > numbers[i]) increasing = false;
        }

        if (increasing) Console.WriteLine("Secventa crescatoare rotita");
        else Console.WriteLine("Nu este");
    }

    public static void P14()
    {
        Console.WriteLine("O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata " +
                          "intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere " +
                          "este o secventa monotona rotita. ");
        
        String[] tokens = Console.ReadLine().Split(' ');

        int[] numbers = new int[tokens.Length];
        for(int i = 0; i < tokens.Length; i++) numbers[i] = Convert.ToInt32(tokens[i]);

        bool increasing = true;
        bool decreasing = true;
        
        if (numbers[0] == numbers[numbers.Length - 1]) increasing = false;
        else
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i - 1] > numbers[i]) increasing = false;
                if (numbers[i - 1] < numbers[i]) decreasing = false;
            }
                
        }

        if (increasing) Console.WriteLine("Secventa crescatoare rotita");
        else if (decreasing) Console.WriteLine("Secventa descrescatoare rotita");
        else Console.WriteLine("Nu este");
    }

    public static void P15()
    {
        Console.WriteLine("O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton " +
                          "descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. " +
                          "Sa se determine daca este bitonica.");

        String[] tokens = Console.ReadLine().Split(' ');
        int[] numbers = new int[tokens.Length];
        for (int i = 0; i < tokens.Length; i++) numbers[i] = Convert.ToInt32(tokens[i]);

        //aflam la ce pozitie e cel mai mare numar din secventa
        int middleElementPosition = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
            if (numbers[i] >= numbers[middleElementPosition])
                middleElementPosition = i;
        
        //verificam daca prima jumatate de secventa e crescatoare
        bool isIncreasing = true;
        for (int i = 1; i <  middleElementPosition; i++)
            if (numbers[i - 1] > numbers[i])
                isIncreasing = false;
                
        //verificam daca a doua jumatate de secventa e descrescatoare
        bool isDecreasing = true;
        for (int i = middleElementPosition; i <  numbers.Length - 1; i++)
            if (numbers[i + 1] > numbers[i])
                isDecreasing = false;
        
        if (isIncreasing && isDecreasing) Console.WriteLine("Secventa bitonica");
        else Console.WriteLine("Nu este o seventa bitonica");
    }

    public static void P16()
    {
        Console.WriteLine("O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o " +
                          "secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o " +
                          "secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.");
        String[] tokens = Console.ReadLine().Split(' ');
        int[] v = new int[tokens.Length];
        for (int i = 0; i < tokens.Length; i++) v[i] = Convert.ToInt32(tokens[i]);
        

        bool secventaBitonica = false;
        for (int i = 0; i < v.Length; i++)
        {
            //cod de la exercitiul 15
            int middleElementPosition = 0;
            for (int j = 0; j < v.Length - 1; j++)
                if (v[j] >= v[middleElementPosition])
                    middleElementPosition = j;
            bool isIncreasing = true;
            for (int j = 1; j <  middleElementPosition; j++)
                if (v[j - 1] > v[j])
                    isIncreasing = false;
            bool isDecreasing = true;
            for (int j = middleElementPosition; j <  v.Length - 1; j++)
                if (v[j + 1] > v[j])
                    isDecreasing = false;

            if (isDecreasing && isIncreasing) secventaBitonica = true;
            
            //rotim secventa
            int aux = v[v.Length - 1];
            for (int j = v.Length - 1; j > 0; j--) v[j] = v[j - 1];
            v[0] = aux;
        }

        if (secventaBitonica) Console.WriteLine("Secventa bitonica rotita");
        else Console.WriteLine("Nu este");
    }

    public static void P17()
    {
        Console.WriteLine("Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. " +
                          "Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, " +
                          "determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta " +
                          "si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. ");
        String[] tokens = Console.ReadLine().Split(' ');
        
        Stack<String> stack = new Stack<String>();
        int stackMaxSize = 0;
        for (int i = 0; i < tokens.Length; i++)
        {
            if (stack.Count != 0 && tokens[i].Equals("1") && stack.Peek().Equals("0")) stack.Pop();
            else stack.Push(tokens[i]);

            if (stack.Count > stackMaxSize) stackMaxSize = stack.Count;
        }
        
        if (stack.Count == 0) Console.WriteLine("Secventa corecta! Nivel maxim incubare: " + stackMaxSize);
        else Console.WriteLine("Secventa incorecta.");

    }


}
