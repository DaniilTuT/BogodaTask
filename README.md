# BogodaTask - Инструкция по развертыванию

## Предварительные требования

1. **.NET SDK**: Убедитесь, что на вашем компьютере установлен .NET SDK (версии 6.0 или выше).
   - [Скачать .NET SDK](https://dotnet.microsoft.com/download/dotnet)
   
2. **PostgreSQL**: Убедитесь, что PostgreSQL установлен и запущен.
   - [Скачать PostgreSQL](https://www.postgresql.org/download/)

3. **IDE (необязательно)**: Убедитесь, что у вас установлена IDE, поддерживающая C#, например, Rider или Visual Studio.

## Шаги по развертыванию

1. **Клонирование репозитория**

   Клонируйте репозиторий проекта на свой компьютер:
   ```bash
   git clone https://github.com/DaniilTuT/BogodaTask
   cd Bogoda
   ```

2. **Настройка базы данных**

   - Запустите PostgreSQL и создайте новую базу данных для приложения:
      ```sql
      CREATE DATABASE your_db;
      ```

3. **Настройка конфигурации приложения**

   Откройте файл `appsettings.json` в проекте и настройте строку подключения к базе данных в разделе `DefaultConnection`. Пример строки подключения:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Database=your_db;Username=your_username;Password=your_password"
   }
   ```

4. **Применение миграций**

   Перейдите в проект **Infrastructure** и выполните миграции для создания необходимых таблиц в базе данных:
   ```bash
   dotnet ef database update --project Persistance --startup-project Api
   ```

   > **Примечание**: Убедитесь, что `Entity Framework Core` установлен. Если необходимо, добавьте его командой:
   > ```bash
   > dotnet tool install --global dotnet-ef
   > ```

5. **Сборка проекта**

   Перейдите в корневую папку и выполните команду для сборки:
   ```bash
   dotnet build
   ```

6. **Запуск приложения**

   Выполните следующую команду, чтобы запустить приложение:
   ```bash
   dotnet run --project Api
   ```

## Тестирование

- **Для тестирования CRUD-операций**: Используйте **Api/TestRequests** или **Swagger**.

## Заключение

Теперь приложение готово к использованию!
