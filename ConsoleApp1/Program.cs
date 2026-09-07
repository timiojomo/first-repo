static void ChangeValue(ref int x)
{
    x = 20;
}

static void ReferenceNumber()
{
    int num = 10;
    ChangeValue(ref num);
    Console.WriteLine(num);
}

ReferenceNumber();

static void GetValue(out int x)
{
    x = 30;
}

static void OutNumber()
{
    int num;
    GetValue(out num);
    Console.WriteLine(num);
}

OutNumber();