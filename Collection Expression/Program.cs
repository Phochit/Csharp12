
// အရင်ကတော့ ကျနော်တို့ ဒီလို ရေးခဲ့တယ်... ခု ဒီအစား
char[] vowels1 = { 'a', 'e', 'i', 'o', 'u' };

// ဒီလိုမျိုး collection ကို သုံးလို့ ရပြီ
char[] vowels2 = ['a', 'e', 'i', 'o', 'u'];


// အဓိက ကောင်းကျိုး ၂ ခု ရှိတယ်... ပထမ တခုက အခြား collection type တွေမှာပါ သုံးလို့ ရနေတာ...
// List တို့ ျSet တို့ မှာအပြင် low-level ဖြစ်တဲ့ span မှာပါ သုံးလို့ ရသွားတာ...
List<char> list = ['a', 'e', 'i', 'o', 'u'];
HashSet<char> set = ['a', 'e', 'i', 'o', 'u'];
ReadOnlySpan<char> span = ['a', 'e', 'i', 'o', 'u'];

Console.WriteLine("\nList\n-------");
foreach (var c in list)
{
    Console.WriteLine(c);
}
Console.WriteLine("\nHashSet\n---------");
foreach (var c in set)
{
    Console.WriteLine(c);
}
Console.WriteLine("\nSpan\n-------");
foreach (var c in span)
{
    Console.WriteLine(c);
}



// ဒုတိယ အချက်က Method တွေမှာ အောက်ကလို type ကို ထည့်ပေးစရာ မလိုတော့ဘူး.. omit လုပ်လို့ရသွားပြီ...
// compiler က အဲ့ဒါကို infer လုပ်နိုင်တယ်...
Console.WriteLine("\nMethod\n---------");
Foo(['a', 'e', 'i', 'o', 'u']);

void Foo(char[] letters) => Console.WriteLine(letters);

// spread operator နဲ့လဲ တွဲသုံးလို့ရသေးတယ်
Console.WriteLine("\nSpread\n---------");
int[] odd = [1, 3, 5];
int[] even = [2, 4, 6];
int[] both = [.. odd, .. even, 7, 8];
foreach(var c in both)
{
    Console.WriteLine($"{c}");
}




