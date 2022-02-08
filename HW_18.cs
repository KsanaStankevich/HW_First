// Проверить истинность утверждения  ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x = false;
bool y = true;

bool X = (!(x || y) == !x && !y);
bool Y = (!(x || x) == !x && !x);
bool Z = (!(y || y) == !y && !y);
bool M = (!(y || x) == !y && !x);

if (X && Y && Z && M)
{
    Console.WriteLine("Утверждение истина");
}
else Console.WriteLine("Утверждение ложно");