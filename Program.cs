
/*
//1.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
int n = Convert.ToInt32(Console.ReadLine().Trim());
List<int> new_list = new();

for (int i = 0; i <n; i++)
    {
        int valuee_entered = Convert.ToInt32(Console.ReadLine().Trim());
        new_list.Add(valuee_entered);
    }

foreach (var item in new_list)
{
    if(item%2==0)
    Console.Write(item+" ");
}
*/



/*
//2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
Console.WriteLine("Enter number 'n': ");
int n = Convert.ToInt32(Console.ReadLine().Trim());
Console.WriteLine("Enter number 'm': ");
int m = Convert.ToInt32(Console.ReadLine().Trim());

List<int> user_input_list = new();
if(n<0 || m<0){
    Console.WriteLine("Error: Both numbers must be positive! Try gain.");
}
else {
    for (int i = 0; i < n; i++){
    int valuee_entered = Convert.ToInt32(Console.ReadLine().Trim());
    if(valuee_entered == m || valuee_entered % m == 0){
        user_input_list.Add(valuee_entered);
    }
    }
}

foreach (var item in user_input_list)
{
    Console.Write(item+" ");
}
*/




/*
//3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
//Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Console.WriteLine("Enter number 'n': ");
int n = Convert.ToInt32(Console.ReadLine().Trim());

List<string> user_string_list = new List<string>();

if (n<=0)
{
    Console.WriteLine("ERROR: Number must be positive!");
}
else {
    Console.WriteLine($"{n}" + " adet kelime giriniz:");


    for (int i = 0; i < n; i++)
    {
        string entered_string = Console.ReadLine();

        user_string_list.Add(entered_string);

    }
}

Console.WriteLine("Reverse order of entered strings: ");
user_string_list.Reverse();

foreach (var item in user_string_list)
{
    Console.Write($"{item} ");
}
*/




//4.Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
//Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.Write("Enter sentence: ");
string sentence = Console.ReadLine();

string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries); //' ' -> boşluga göre ayırma yapar
int numWords = words.Length;

int numLetters = 0;
foreach (string word in words)
{
    numLetters += word.Length;
}

Console.WriteLine($"Total Word: {numWords}");
Console.WriteLine($"Total letter: {numLetters}");