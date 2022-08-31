Console.Clear();
Console.WriteLine("Нажмите Enter для вывода массива.");
Console.ReadLine();

int[] array = new int[8];
Random rnd=new Random();

Console.Write("[");
int max=0;

for(int i=0;i<array.Length;i++){

array[i]=rnd.Next(-10,10);


Console.Write(array[i]);

if(max<array[i]){max=array[i];}


if(i<array.Length-1){Console.Write(", ");}
else {Console.Write("] -> ");}

}
Console.Write(max);
