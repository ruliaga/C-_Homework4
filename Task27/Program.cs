Console.Clear();
Console.WriteLine("Введите число:");
string number=Convert.ToString(Console.ReadLine());

int sum=0;

for(int i=0;i<number.Length;i++){

    sum=sum+Convert.ToInt32(number[i].ToString());
}
Console.WriteLine($"{number} -> {sum}");
