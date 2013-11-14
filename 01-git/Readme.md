Курс по Git
====


Ссылки
---

1. [Сам Git](http://git-scm.com/)
2. [Игра Learn Git Branching](http://pcottle.github.io/learnGitBranching/)
3. [Git Book](http://git-scm.com/book)


Установка
---

1. Скачать клиент для Windows: http://git-scm.com/downloads
1. В процессе уставноки сделать следущие настройки:
  * Выбрать "Git Bash Here" — это добавит в контекстное меню проводника пункт "Git Bash Here".
  * Выбрать пункт Run git from the windows command prompt
  * Выбрать пункт Checkout as is, commit as is
1. Задать свои имя и email [как это написано тут](https://help.github.com/articles/set-up-git).
Они будут использоватьсядля указания авторства ваших коммитов.
1. Сгенерировать ssh-ключ. Он нужен, чтобы не вводить логин-пароль каждый раз при связи с удаленными репозиториями.
  * Открыть cmd (через Win+R) и выполнить "C:\Program Files (x86)\Git\bin\ssh-keygen.exe"
  * Будет предложено ввести имя файла и какие-то фразы. 
        Не вводить никаких pass-фраз и использовать имя файла по умолчанию
  * Файлы `id_rsa` и `id_rsa.pub` (которые появились в текущем каталоге) сложить в C:\Users\%USERNAME%\.ssh 
(%USERNAME% - пользователь, под которым вы в текущий момент работаете). 
Каталог .ssh лучше создать командой `mkdir .ssh` в консоли или в фаре.
  * Зарегистрироваться на https://github.com и в настройках аккаунта указать ssh-ключ (id_rsa.pub)


