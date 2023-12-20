
// ှStruct က .NET 7 မှာမှ ခုလို ရေးလို့ရနိုင်တာပါ...
// ှဒီ မတိုင်ခင်တုန်းထိ Struct ထဲမှာ Constructor တခု ဖန်တီးမယ်ဆိုရင် Parameter မပါလို့ မရပါဘူး...
// ပြီးတော့ Member အားလုံးကိုလည်း Implementation လုပ်ပေးရပါတယ်...

var l = new LOL();
Console.WriteLine(l.X + "," + l.Y);

struct LOL
{
    public int X, Y;

    public LOL() // No need to assign Members and allow parameterless constructor
    {

    }
}
