## Описание алгоритма решения:
###  Объявляется два массива: изначальный с данными и второй, но пустой (такой же длины).
### После объявляется метод, в котором цикл, соразмерный длине массива. Внутри цикла - проверка условия элемента по индексу на заданное условие (колличество символов больше\равно трём). Если условие выполняется, то элемент заносится в [count] элемент пустого массива. 
### Переменная *count* для правильной очередности элементов во втором массиве.
### После занесения подходящего элемента из первого массива во второй, переменная *count* увеличивается на единицу и возвращается к циклу *for*, где *i* так же увеличивается на единицу. 
### Таким образом массив проверяется до конца и переносит все подходящие элементы из первого во второй массив.
### В конце - используются функции для проверки первого и вывода второго массива в консоль.