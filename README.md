# Final_Task

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Для решения задачи были созданы слудющие методы:

1. FillArray (заполнение массива заданной длины)
2. PrintArray (вывод требуемого массива в терминал)
3. CountStringSymbols (расчет количества элементов в массиве, длина которых меньше или равна трем)
4. GenerateNewArray (создание массива по заданным параметрам)


Алгоритм решения:

1. Создаем массив из введенных пользователем данных.
2. Расчитываем количество элементов в массиве, длина которых меньше или равна трем.
3. Создаем новый массив длиной равной количеству элементов посчитанных в п2.
4. Заполняем новый массив элементами, длина которых меньше или равна трем.
5. Выводим в консоль исходный и отсортированный массивы.
