
/*
Console.WriteLine("Merhaba nasılsın?\nİyiyim, sen nasılsın?\n");

Console.WriteLine("----------------------------------------------------------------------");

string name = "Osman";
int number = 21;

Console.WriteLine(name + " " + number);

Console.WriteLine("------------------------------------------------------------------------");

Random rnd = new Random();

int number2 = rnd.Next(1, 100);

Console.WriteLine("Sayı: " + number2);

int result = number2 % 3;

Console.WriteLine("3'e bölümünden kalan: " + result);

Console.WriteLine("------------------------------------------------------------------------");

Console.Write("Yaşınızı giriniz:");

int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}

Console.WriteLine("------------------------------------------------------------------------");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

Console.WriteLine("-------------------------------------------------------------------------------");

string metin1 = "Gülse Birsel";
string metin2 = "Demet Evgar";

Console.WriteLine("Yer değiştirme olmadan önce: " + metin1 + ", " + metin2);

string temp = metin1;
metin1 = metin2;
metin2 = temp;

Console.WriteLine("Yer değiştirmeden sonra: " + metin1 + ", " + metin2);

Console.WriteLine("---------------------------------------------------------------------------------------");

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

BenDegerDondurmem();

Console.WriteLine("------------------------------------------------------------------------------------------");

int Toplam(int x, int y)
{
    return x + y;
}

Console.WriteLine(Toplam(5, 7));

Console.WriteLine("-------------------------------------------------------------------------------------------");

Console.WriteLine("true ya da false giriniz:");


string TrueFalse()
{
    bool tf = Convert.ToBoolean(Console.ReadLine());

    string answer1;

    if (tf)
    {
        answer1 = "true girdiniz";
        return answer1;
    }
    else 
    {
        answer1 = "false girdiniz";
        return answer1;
    }
}

string answer = TrueFalse();
Console.WriteLine(answer);

Console.WriteLine("------------------------------------------------------");

void UcYas()
{
    int[] age = new int[0];
    for (int i = 0; i < 3; i++)
    {
        Console.Write("Bir yaş değeri giriniz: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        Array.Resize(ref age, age.Length + 1);

        age[age.Length - 1] = userInput;
    }

    Array.Sort(age);

    int enBuyuk = age[age.Length - 1];

    Console.WriteLine("En yaşlı kişinin yaşı: " + enBuyuk);

}    

UcYas();


Console.WriteLine("-----------------------------------------------------------------------");

int Numbers()
{
    int[] numbers = new int[0];

    bool control = true;

    while (control)
    {
        Console.Write("Bir sayı değeri giriniz: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        Array.Resize(ref numbers, numbers.Length + 1);

        numbers[numbers.Length - 1] = userInput;

        Console.WriteLine("çıkış için q basınız.");
        string? quit = Console.ReadLine();
        if(quit == "q")
        {
            control = false;
        }
    }

    Array.Sort(numbers);

    int sonTerim = numbers[numbers.Length - 1];
    return sonTerim;
}

int sonTerim = Numbers();
Console.WriteLine("Dizideki en büyük eleman: " + sonTerim);

Console.WriteLine("-------------------------------------------------------------------");

void ChangeNames()
{
    Console.Write("İsminizi giriniz: ");
    string name1 = Console.ReadLine();
    Console.Write("Arkadaşınızın ismini giriniz: ");
    string name2 = Console.ReadLine();

    string change = name1;

    name1 = name2;

    name2 = change;

    Console.WriteLine("Artık isminiz: " + name1);
    Console.WriteLine("Arkadaşınızın yeni ismi: " + name2);
}

ChangeNames();


Console.WriteLine("---------------------------------------------------------------------");

bool TekCift()
{
    Console.Write("Bir sayı giriniz: ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput % 2 == 0)
        return true;
    else 
        return false;
}

bool result = TekCift();

Console.WriteLine("Girdiğiniz sayı çiftdir: " + result);


double YolHesap(double time, double speed)
{
    return (double) time * speed;
}


Console.Write("Zamanı giriniz (saat): ");
double time = Convert.ToDouble(Console.ReadLine());
Console.Write("Hızınızı giriniz (km/h): ");
double speed = Convert.ToDouble(Console.ReadLine());

double yol = YolHesap(time, speed);
Console.WriteLine("gidilen mesafe: " + yol + "km");



Console.WriteLine("----------------------------------------------------------------------");

void DaireAlan()
{
    Console.Write("Lütfen dairenin yarıçapını giriniz (cm): ");
    double userInput = Convert.ToDouble(Console.ReadLine());
    double pi = 3.14159;
    double r2 = Math.Pow(userInput, 2);
    double alan = r2 * pi;
    Console.WriteLine("Dairenin alanı " + alan + " cm^2");
}

DaireAlan();

Console.WriteLine("--------------------------------------------------------------------------");

string cumle = "Zaman bir GeRi SayIm";

string buyuk = cumle.ToUpper();
Console.WriteLine(buyuk);
string kucuk = cumle.ToLower();
Console.WriteLine(kucuk);

Console.WriteLine("----------------------------------------------------------------");

string cumle2 = "    Selamlar   ";

string cumle2Trim = cumle2.Trim();
Console.WriteLine(cumle2Trim);
*/