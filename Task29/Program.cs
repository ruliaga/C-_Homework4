Console.Clear();
Console.WriteLine("Нажмите Enter для вывода массива.");
Console.ReadLine();

int[] array = new int[8];
Random rnd=new Random();


for(int i=0;i<array.Length;i++){

array[i]=rnd.Next(0,10);



Console.Write(array[i]);
if(i<array.Length-1){Console.Write(", ");}
else {Console.Write(" -> ");}

}
Console.Write($"[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}]");

