using System.Collections.Generic;

namespace FrameworkWhite.Utils.Constans
{
    public struct EnRuDictionary
    {
        public static Dictionary<string, string> Get
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    {"Scientific","Инженерный"},
                    {"Standard","Обычный"},
                    {"View","Вид"},
                    {"Edit","Правка"},
                    {"Help","Справка"},
                    {"Select", "Выделить"},
                    {"Select All", "Выделить все"},
                    {"Cut", "Вырезать"},
                    {"File tab", "Меню приложения"},
                    {"Open", "Открыть"},
                    {"Don't Save", "Не сохранять"},
                    {"Paste", "Вставить"},
                    {"Paste from", "Вставить из"},
                    {"Paste From", "Вставка из"},
                    {"Properties", "Свойства"},
                    {"Image Properties", "Свойства изображения"},
                    {"Centimeters", "сантиметры"},
                    {"cm", "см"},
                    {"OK", "ОК"},
                    {"Resize and Skew", "Изменение размеров и наклона" },
                    {"Resize", "Изменить размер" },
                    {"Maintain aspect ratio", "Сохранить пропорции" }
                };
            }
        }
    }
}
