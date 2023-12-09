
// တခါတည်း class ထဲမှာ parameter တွေ ထည့်ပြီး တည်ဆောက်တာမျိုး ရသွားတာ
// prototype တခုအတွက် မြန်မြန်ဆန်ဆန် တည်ဆောက်လို့ရသွားတာမျိုးပေါ့...
class MyClass
{
    class Person(string firstName, string lastName,string sirName)
    {
        // default constructor တည်ဆောက်မယ်ဆိုရင်တော့ အရင်အတိုင်း မရတော့ဘူး...
        // initializ လုပ်ကို လုပ်ရမယ်.. အောက်ကလိုပေါ့
        // compiler က parameter တခုချင်းစီကို public property အဖြစ် မပြောင်းပေးနိုင်ဘူး..
        // Private တွေအဖြစ်ပဲ ဆက်ရှိနေမယ်...
        // field ဒါမှမဟုတ် property မဟုတ်တဲ့အတွက် သုံးချင်ရင်တော့ assign ပြန်လုပ်ပြီး သုံးနိုင်တယ်
        // field or Property ကိုမှ masking လုပ်လို့ရတယ်... parameter nameနဲ့ နာမည်တူပေါ့..
        // validation လဲ လုပ်နိုင်တယ်...

        public readonly string firstName = firstName; // masking field
        public string LastName { get; set; } = lastName; // property

        readonly string sirName = (sirName == null)
       ? throw new ArgumentNullException("sirName")
       : sirName;  // validation sirName

        public Person():this("gg","wp","Mg")
        {
        }
        public void Print() => Console.WriteLine(firstName + " " + lastName);
    }

    static void Main()
    {
        Person p = new Person("Pho", "Chit","Mg");
        Person p2= new Person();
        
        p.Print();    // Pho Chit
        p2.Print(); // gg wp

        
        p2.LastName = "apk";
        Console.WriteLine(p2.firstName+" "+p2.LastName); // gg apk

        Person p3 = new Person("Htun", "Thein", null);
        p3.Print(); // throw exception for sirName

    }
}

