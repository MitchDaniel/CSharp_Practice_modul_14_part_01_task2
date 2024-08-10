using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Task2
{
    internal static class AlbumManager
    {
        public static string Serialize(Album album)
        {
            if(album is null) throw new ArgumentNullException(nameof(album));

            return JsonSerializer.Serialize(album);
        }

        public static Album[] DeserializeAlboms(string json)
        {
            if (json is null) throw new ArgumentNullException(nameof(json));
            return JsonSerializer.Deserialize<Album[]>(json) ?? throw new JsonException();
        }

        public static string Serialize(params Album[] albums)
        {
            if(albums is null) throw new ArgumentNullException(nameof(albums));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Album album in albums)
            {
                stringBuilder.Append(JsonSerializer.Serialize(album));
            }
            return stringBuilder.ToString();
        }

        public static void Save(string json, string path)
        {
            if (json is null) throw new ArgumentNullException();
            if (path is null) throw new ArgumentNullException();
            if(!File.Exists(path)) throw new FileNotFoundException();
            byte[] bytes = Encoding.UTF8.GetBytes(json);
            using FileStream fileStream = File.OpenWrite(path);
            fileStream.Write(bytes, 0, bytes.Length);
        }

        public static string Load(string path)
        {
            if (path is null) throw new ArgumentNullException();
            if (!File.Exists(path)) throw new FileNotFoundException();
            byte[] bytes = File.ReadAllBytes(path);
            return Encoding.UTF8.GetString(bytes) ?? throw new JsonException();
        }


    }
}
//У программы должна быть такая функциональность:
//1. Ввод информации об альбоме
//2. Вывод информации об альбоме
//3. Сериализация альбома
//4. Сохранение сериализованного альбома в файл
//5. Загрузка сериализованного альбома из файла. После загрузки нужно произвести десериализацию альбома.
//Выбор конкретного формата сериализации необходимо сделать вам. Обращаем ваше внимание, что выбор должен быть обоснованным.
//Добавьте к предыдущему заданию список песен на альбом. Нужно хранить такую информацию о каждой песне:
//1. Название песни
//2. Длительность песни
//3. Стиль песни
//Измените функциональность из предыдущего задания таким образом, чтобы она учитывала список песен.

//Добавьте к предыдущему заданию возможность создания массива альбомов.
//Измените функциональность из второго задания таким образом, чтобы она учитывала массив альбомов.
