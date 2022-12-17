/* Итак, возьмём некоторый аргумент 1, опишем некоторый аргумент 2 и 3.
int Max(int arg1, int arg2, int arg3)
После этого опишем тело метода:
{
int result = arg1;
if(arg2>result) result=arg2;
if(arg3>result) result=arg3;
return result;
}
Сначала у нас была подзадача, где мы искали максимум из трёх чисел. Теперь идёт всё то же
самое, только в контексте метода. Определяем внутренний result, где будет храниться
значение max. Далее, если arg2>result, то в result надо положить arg2. То же самое
проделываем с третьей строчкой кода. Теперь требуется, чтобы наш метод возвращал result.
Таким образом, у нас появляется вспомогательный механизм, который ищет максимум из трёх
чисел. */


int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2>result) result=arg2;
if(arg3>result) result=arg3;
return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 3133;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);