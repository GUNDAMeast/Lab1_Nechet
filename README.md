# Лабораторная работа №1 по дисциплине "Язык программирования C#", Вариант - нечётные задания, ПГНИУ ИТ-15-2022 Стрельников Максим

Для написания кода использовалась среда разработки Microsoft Visual Studio.

## Формулировка задания №1.1
Дана сигнатура метода: public double Fraction (double x);
Необходимо реализовать метод таким образом, чтобы он возвращал только дробную часть числа x.

### Решение
Из вещественного числа x вычитается число x переведённое в целое. Если вещественное число было отрицательным, то минус у дробной части уничтожается.

<img width="400" height="100" alt="image" src="https://github.com/user-attachments/assets/6a357220-6443-46eb-bd08-9006ab353a35" />

<img width="400" height="100" alt="image" src="https://github.com/user-attachments/assets/148d6dc6-9c9f-46a4-8acf-74c02fb4f6b3" />

<img width="400" height="350" alt="image" src="https://github.com/user-attachments/assets/2532b8bc-d63f-4ebf-b4c5-19b666a8434d" />

## Формулировка задания №1.3
Дана сигнатура метода: public int CharToNum (char x);
Метод принимает символ х, который представляет собой одно из чисел “0 1 2 3 4 5 6 7 8 9”. 
Необходимо реализовать метод таким образом, чтобы он преобразовывал символ в соответствующее число.
Подсказка: код символа ‘0’ — это число 48.

### Решение
Из введённого числового символа, переведённого в целое число, вычитается код числового символа '0'.

<img width="400" height="300" alt="image" src="https://github.com/user-attachments/assets/6329f4a3-4ca6-4587-874d-16dc57e761f7" />

## Формулировка задания №1.5
Дана сигнатура метода: public bool Is2Digits (int x);
Необходимо реализовать метод таким образом, чтобы он принимал число x и возвращал true, если оно двузначное.

### Решение
Если число находится в промежутке между 9 и 100 или -100 и -9, то число считается двузначным. Иначе оно не двузначное.

<img width="480" height="200" alt="image" src="https://github.com/user-attachments/assets/fbfd1970-612a-4267-8f99-04ffcf2243b8" />

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/f42da1dc-c833-4651-89fd-7d5b16956f19" />

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/d4e8ccc2-4371-43ff-82cb-8418305d546e" />

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/541831c7-ba4d-4c6b-b53c-2ac4f562efdd" />

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/d90bc87e-e0a1-46b4-be2e-6ee150b215dd" />

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/1cd05a64-cf90-4d55-bc3c-701cbe77478d" />

## Формулировка задания №1.7
Дана сигнатура метода: public bool IsInRange (int a, int b, int num);
Метод принимает левую и правую границу (a и b) некоторого числового диапазона.
Необходимо реализовать метод таким образом, чтобы он возвращал true, если num входит в указанный диапазон (включая границы). Отношение a и b заранее неизвестно (неясно кто из них больше, а кто меньше).

### Решение
Выбирается максимум и минимум из чисел a и b. Если число num находится включительно между минимумом и максимумом, то оно входит в заданный промежуток. Иначе оно не входит в него.

<img width="200" height="250" alt="image" src="https://github.com/user-attachments/assets/993d5b74-74eb-4d91-a6d4-dcdc3afe848e" />

<img width="200" height="250" alt="image" src="https://github.com/user-attachments/assets/0f83023a-d030-4b21-a445-8790e2fc14ba" />

<img width="200" height="250" alt="image" src="https://github.com/user-attachments/assets/9c5cca01-3641-4bd1-a149-1f614c5bd817" />

<img width="200" height="250" alt="image" src="https://github.com/user-attachments/assets/0afaf3fa-d5a0-4cbd-819a-6bf6c93b48eb" />

<img width="200" height="250" alt="image" src="https://github.com/user-attachments/assets/7da1defa-9c2d-4e2e-8f29-ec33b646c71f" />

<img width="200" height="250" alt="image" src="https://github.com/user-attachments/assets/7fad49da-9824-4791-8310-d548f532e675" />

## Формулировка задания №1.9

Дана сигнатура метода: public bool IsEqual (int a, int b, int c);
Необходимо реализовать метод таким образом, чтобы он возвращал true, если все три полученных методом числа равны.

### Решение
Проверяется два равенства: a равно c и b равно c. Если оба оказываются истинными, значит, числа a,b и c имеют одно и то же значение

<img width="350" height="300" alt="image" src="https://github.com/user-attachments/assets/2e924101-5815-4c93-8bef-120628c81570" />

<img width="250" height="250" alt="image" src="https://github.com/user-attachments/assets/caef4ce8-5037-4978-9bf9-cd646835ffea" />

## Формулировка задания №2.1
Дана сигнатура метода: public int Abs (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал модуль числа х (если оно было положительным, то таким и остаётся, если оно было отрицательным – то необходимо вернуть его без знака минус).

### Решение
Если было введено положительное число, то оно так и возвращается. Если же было введено отрицательное - оно умножается на -1 и возвращается уже положительным.

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/f2a8897a-4bc0-43e7-941a-26fe7c2fdc39" />

<img width="250" height="150" alt="image" src="https://github.com/user-attachments/assets/c89f2eb9-45f6-4da0-ab2d-cde519c1c65a" />

## Формулировка задания №2.3
Дана сигнатура метода: public bool Is35 (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал true, если число x делится нацело на 3 или 5. При этом если оно делится и на 3, и на 5, то вернуть надо false.

### Решение
Если число кратно 3 или 5 возвращаем True. Если оно не кратно или кратно одновременно - возвращаем False.

<img width="250" height="125" alt="image" src="https://github.com/user-attachments/assets/152a7dac-1149-472b-b5a9-851a0b70d152" />

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/9b67ede1-e304-432e-9465-bfd8e5168eef" />

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/5acd53f0-275d-47f4-b8b1-6b719ab737b5" />

<img width="250" height="150" alt="image" src="https://github.com/user-attachments/assets/db5109d1-009a-4d65-9e1a-9181dc0ddc2d" />

## Формулировка задания №2.5
Дана сигнатура метода: public int Max3 (int x, int y, int z);
Необходимо реализовать метод таким образом, чтобы он возвращал максимальное из трёх полученных методом чисел. Подсказка: идеальное решение включает всего две инструкции if и не содержит вложенных if.

### Решение
Выбираем большее число из первого и второго, далее выбираем большее число из третьего и большего между первым и вторым.

<img width="300" height="300" alt="image" src="https://github.com/user-attachments/assets/52584e29-bf56-4946-bc79-0e1e1f8b27a0" />

<img width="300" height="250" alt="image" src="https://github.com/user-attachments/assets/5b2179b1-34b9-40ef-b7c7-462fac1cb983" />

<img width="300" height="250" alt="image" src="https://github.com/user-attachments/assets/23bfd450-09bf-4244-b38b-ac915eee1021" />

## Формулировка задания №2.7
Дана сигнатура метода: public int Sum2 (int x, int y);
Необходимо реализовать метод таким образом, чтобы он возвращал сумму чисел x и y. Однако если сумма попадает в диапазон от 10 до 19, то надо вернуть число 20.

### Решение
Складываем два числа. Если сумма попадает в диапазон от 10 до 19, то всегда возвращается 20.

<img width="250" height="150" alt="image" src="https://github.com/user-attachments/assets/2a7248f0-55ad-4ef1-b67b-a9c104364989" />

<img width="250" height="150" alt="image" src="https://github.com/user-attachments/assets/98df2cb3-0b1b-456f-a9c4-415bbe7aa9ae" />

## Формулировка задания №2.9
Дана сигнатура метода: public string Day (int x);
Метод принимает число x, обозначающее день недели.
Необходимо реализовать метод таким образом, чтобы он возвращал строку, которая будет обозначать текущий день недели, где 1 - это понедельник, а 7 - воскресенье. Если число не от 1 до 7 то верните текст “Это не день недели”. Вместо if в данной задаче используйте switch.

### Решение
Соотносим число, введённое пользователем, с днём недели.

<img width="350" height="150" alt="image" src="https://github.com/user-attachments/assets/b9267965-6b98-4dfe-92f4-cc53a84e2751" />

<img width="350" height="100" alt="image" src="https://github.com/user-attachments/assets/33819ff8-aca0-48cc-bb09-bfdced3e07c6" />

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/680d1932-b91a-4b77-b501-ad2bb4166843" />

## Формулировка задания №3.1
Дана сигнатура метода: public string ListNums (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал строку, в которой будут записаны все числа от 0 до x (включительно)

### Решение
С помощью цикла for выводим числа через пробел от 0 до числа, введённого пользователем, включительно.

<img width="300" height="100" alt="image" src="https://github.com/user-attachments/assets/c7f17d0c-a3ff-48df-ae1e-ecaca0a2dfdf" />

<img width="550" height="100" alt="image" src="https://github.com/user-attachments/assets/8517a4f9-fff8-4aa8-82f7-b45394641425" />

## Формулировка задания №3.3
Дана сигнатура метода: public string Chet (int x); 
Необходимо реализовать метод таким образом, чтобы он возвращал строку, в которой будут записаны все четные числа от 0 до x (включительно). Подсказка: для обеспечения качества кода: инструкцию if использовать не следует.

### Решение
С помощью цикла for выводим числа через пробел с шагом 2 от 0 до числа, введённого пользователем, включительно.

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/94a5bb26-b45c-4b38-a665-802faff0ef2c" />

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/d1a26bf1-b4d1-4493-8721-db3b0bc145f1" />

## Формулировка задания №3.5
Дана сигнатура метода: public int NumLen (long x); 
Необходимо реализовать метод таким образом, чтобы он возвращал количество знаков(цифр) в числе x.

### Решение
Проверяем какое число ввёл пользователь: однозначное, двузначное, трёхзначное и так далее.

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/7be1ba6d-5d1d-4ad2-81d4-938aa9b39ecc" />

<img width="250" height="100" alt="image" src="https://github.com/user-attachments/assets/2bb19f16-523b-416d-825e-0962b943b3ae" />

<img width="250" height="125" alt="image" src="https://github.com/user-attachments/assets/402a07ea-8030-45da-a13d-9458bfa46da2" />

## Формулировка задания №3.7
Дана сигнатура метода: public void Square (int x); 
Необходимо реализовать метод таким образом, чтобы он выводил на экран квадрат из символов * размером х, у которого х символов в ряд и х символов в высоту.  

### Решение
Выводим квадрат из * соответствующего размера если число, введённое пользователем, оказалось положительным.

<img width="425" height="200" alt="image" src="https://github.com/user-attachments/assets/a46b6082-04f4-4f2f-9edb-dd8ef74febc2" />

<img width="650" height="200" alt="image" src="https://github.com/user-attachments/assets/cb2acd92-f02f-47c6-8ebf-84c41722c223" />

## Формулировка задания №3.9
Дана сигнатура метода: public void RightTriangle (int x); 
Необходимо реализовать метод таким образом, чтобы он выводил на экран треугольник из символов * у которого х символов в высоту, а количество символов в ряду совпадает с номером строки, при этом треугольник выровнен по правому краю. Подсказка: перед символами ‘*’ следует выводить необходимое количество пробелов.

### Решение
Выводим треугольник по правому краю из * соответствующего размера если число, введённое пользователем, оказалось положительным.

<img width="650" height="400" alt="image" src="https://github.com/user-attachments/assets/f653ec1c-5f1f-4bab-89e7-469ccc5b0d2f" />

## Формулировка задания №4.1
Дана сигнатура метода: public int FindFirst (int[] arr, int x); 
Необходимо реализовать метод таким образом, чтобы он возвращал индекс первого вхождения числа x в массив arr. Если число не входит в массив – возвращается -1.

### Решение

## Формулировка задания №4.3
Дана сигнатура метода: public int MaxAbs (int[] arr); 
Необходимо реализовать метод таким образом, чтобы он возвращал наибольшее по модулю (то есть без учета знака) значение массива arr.

### Решение

## Формулировка задания №4.5
Дана сигнатура метода: public int[] Add (int[] arr, int[] ins, int pos); 
Необходимо реализовать метод таким образом, чтобы он возвращал новый массив, который будет содержать все элементы массива arr, однако в позицию pos будут вставлены значения массива ins.

### Решение

## Формулировка задания №4.7
Дана сигнатура метода: public int[] ReverseBack (int[] arr); 
Необходимо реализовать метод таким образом, чтобы он возвращал новый массив, в котором значения массива arr записаны задом наперед.

### Решение

## Формулировка задания №4.9
Дана сигнатура метода: public int[] FindAll (int[] arr, int x); 
Необходимо реализовать метод таким образом, чтобы он возвращал новый массив, в котором записаны индексы всех вхождений числа x в массив arr.

### Решение
