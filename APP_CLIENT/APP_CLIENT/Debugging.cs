using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace APP_CLIENT
{
    class Debugging
    {
        // сохранение раздела отладка файл
        public void save(string adress, string request_1, string request_2, string request_3, string request_4, string request_5,
            string request_6, string request_7, string request_8, string request_9, string request_10, string request_11,
            string request_12, string request_13, string request_14, bool chek_1, bool chek_2, bool chek_3, bool chek_4,
            bool chek_5, bool chek_6, bool chek_7, bool chek_8, bool chek_9, bool chek_10, bool chek_11, bool chek_12,
            bool chek_13, bool chek_14)
        {
            // записываем в файл
            using (StreamWriter sw = new StreamWriter(@"debbuggings.txt", false, System.Text.Encoding.Default))
            { 
                sw.WriteLine(adress+";"+ request_1+";"+ request_2+";"+ request_3+";"+ request_4+";"+ request_5+";"+ request_6+";"+
                    request_7+";"+ request_8+";"+ request_9+";"+ request_10+";"+ request_11+";"+ request_12+";"+ request_13+";"+
                   request_14+";"+ chek_1+";"+ chek_2+";"+ chek_3+";"+ chek_4+";"+ chek_5+";"+ chek_6+";"+ chek_7+";"+
                   chek_8+";"+ chek_9+";"+ chek_10+";"+ chek_11+";"+ chek_12+";"+ chek_13+";"+ chek_14);
            }
        }

        // чтение из файла данных
         public string[] considers()
         {
            // Получение сведений(сортировка)
             using (FileStream fstream = File.OpenRead(@"debbuggings.txt"))
             {
              // преобразуем строку в байты
               byte[] array = new byte[fstream.Length];
                // считываем данные
               fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
               string textFromFile = System.Text.Encoding.Default.GetString(array);
                // получаем файл в массив
               string[] words = textFromFile.Split(';');

                return words;
             }
         }
    }
}
