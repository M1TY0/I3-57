Dictionary<string, string> months = new Dictionary<string, string>(){
    {"1","January " },


     {"2","February"},
    {"3" , "March"},
     {"4" , "April"},
      {"5" , "May"},
       {"6" , "June"},
        {"7" , "July"},
         {"8" , "August"},
          {"9" , "September"},
           {"10" , "Octomber"},
            {"11" , "November"},
             {"12" , "Desember"}

};
int[] n = new int[12];
for (int i = 0; i < n.Length; i++)
{
    n[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(n.Average());
Console.WriteLine(months[(indexMax(n).ToString())] + " " + n.Max()) ;
Console.WriteLine(months[(indexMin(n).ToString())] + " " + n.Min());


int indexMin(int[] n)
{
    int i = 0;
    int x = n.Min();
    for (int f = 0; f < n.Length; f++)
    {
        if (n[f] == x)
        {
            i = f;
            break;
        }
    }
    return i;
}
int indexMax (int[] n)
    {
    int i = 0;
    int x = n.Max();
    for (int f = 0; f < n.Length; f++)
    {
        if (n[f] == x)
        {
            i = f;
            break;
        }
    }
    return i;
}
