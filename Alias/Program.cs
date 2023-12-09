
// using ကို သုံးပြီး Type ဆောက်တဲ့ သဘောမျိုး
// ဘယ်နေရာမှာ သုံးလို့ ကောင်းမလဲ မပြောတတ်သေးပေမယ့် လောလောဆယ်တော့ အလုပ်ပိုတယ်လို့ ထင်နေတယ်

using NumberList = double[];
using Point = (int X, int Y);  

NumberList numbers = { 2.5, 3.5 };

Point p = (3, 4);
Console.WriteLine(p);

// ီဒီ code က ပြောစရာ ရှိတယ်... record ကို ကြေငြာပြီးမှ Type ကို သုံးမယ်ဆို မရဘူး...
// ပြောချင်တာက record Method ကို alias ခေါ်ထားတဲ့ အောက်မှာပဲထား... ယောင်လို့တောင် အပေါ်ကို move မလုပ်နဲ့

Point2 p2 = new(3, 4);
Console.WriteLine(p2);
record Point2(int X, int Y);


