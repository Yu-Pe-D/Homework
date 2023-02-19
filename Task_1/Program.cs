      Console.WriteLine ("Введите номер дня недели...");
      int dayofweek = int.Parse (Console.ReadLine());
      if (dayofweek == 6 ) Console.WriteLine ("Ответ: Суббота."); 
      if (dayofweek == 7) Console.WriteLine ("Ответ: Воскресение.");
      else if (dayofweek <= 5) Console.WriteLine ("Ответ: Будний день.");
      else if (dayofweek > 7) Console.WriteLine ("Ошибка: В неделе всего 7 дней!");

