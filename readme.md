следущие этапы решения задачи
1. объявляем переменные - задаём массив и count, count приравниваем к 3м.
2. вызываем методы - их 3.

3. первый метод это GetAmountOfElements. Принимает в качестве аргумента массив строк и возвращает int. Он нужен нам чтобы узнать количество элементов в имеющемся массиве, длина которых меньше или равна 3м. Тк длина массива у нас определяется заранее её значение решил вычислить в отдельном методе. Метод работает так: задаём переменную типа int amount, приравниваем её к 0. Создаём цикл for. Циклом проходимся по массиву. Прописываем в цикле условие, что если длина какого-то элемента меньше или равна 3м, то amount увеличиваем на 1. Возвращаем переменную amount.
4. второй метод это GetElements. Принимает в качестве аргумента массив строк и возвращает новый массив строк. В методе объявляем переменные - новый массив строк, а также int  resultLength, который равен 0 и увеличивается при выполнении условия в цикле. Эта переменная будет служить как индекс элемента в новом массиве. Проходимся по массиву циклом и задаём условие - если находим элемент длиной меньше или равной 3м, то "заносим" его в новый массив. Возвращаем новый массив.
5. третий метод это метод печати массивов. Принимает в качестве аргумета массив строк и ничего не возвращает. 