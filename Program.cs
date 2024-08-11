using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Diagnostics.Metrics;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Album[] albums = new Album[3];
            albums[0] = new Album("Turn Blue", "The Black Keys", 2014, new TimeOnly(0, 45), "WB");
            albums[1] = new Album("Westworld", "Ramin Djawadi", 2016, new TimeOnly(1, 49), "WB");
            albums[2] = new Album("The rise and Fall of Ziggy Sturdus and the Spiders from Mars", "David Bowie", 1972, new TimeOnly(0, 38), "WB");

            albums[0].Add(new Song("Fever", new TimeOnly(0, 3, 13), "Indy"), new Song("Bullet in the brain", new TimeOnly(0, 3, 13), "Indy"));
            albums[1].Add(new Song("Dr. Ford", new TimeOnly(0, 5, 30), "SoundTrack"), new Song("Bicameral Mind", new TimeOnly(0, 4, 26), "SoundTrack"));
            albums[2].Add(new Song("Moonage Daydream", new TimeOnly(0, 4, 40), "Rock"));
            AlbumManager.Save(AlbumManager.Serialize(albums), @"C:\Users\Brill\Desktop\Четотам 2.json");
            ////Album album = new Album("Turn Blue", "The Black Keys", 2014, new TimeOnly(0, 45), "WB");
            ////album.Add(new Song("Fever", new TimeOnly(0, 3, 13), "Indy"), new Song("Bullet in the brain", new TimeOnly(0, 3, 13), "Indy"));
            ////AlbumManager.Save(AlbumManager.Serialize(album), @"C:\Users\Brill\Desktop\Четотам.json");
            ////Album album1 = AlbumManager.Deserialize(AlbumManager.Load(@"C:\Users\Brill\Desktop\Четотам .json"));
            ////foreach (var songs in album1.Songs)
            ////{
            ////    Console.WriteLine(songs.ToString());
            ////}
            Album[] albums2 = AlbumManager.DeserializeAlboms(AlbumManager.Load(@"C:\Users\Brill\Desktop\Четотам 2.json"));
            foreach (Album album in albums2)
            {
                Console.WriteLine(album.Name);
                foreach (var song in album.Songs)
                {
                    Console.WriteLine(song);
                }
            }

            //string json = "{\"Songs\":[{\"Name\":\"Fever\",\"Duration\":\"00:03:13\",\"Style\":\"Indy\"},{\"Name\":\"Bullet in the brain\",\"Duration\":\"00:03:13\",\"Style\":\"Indy\"}],\"Name\":\"Turn Blue\",\"AuthorName\":\"The Black Keys\",\"Year\":2014,\"Studio\":\"WB\",\"Duration\":\"00:06:26\"}{\"Songs\":[{\"Name\":\"Dr. Ford\",\"Duration\":\"00:05:30\",\"Style\":\"SoundTrack\"},{\"Name\":\"Bicameral Mind\",\"Duration\":\"00:04:26\",\"Style\":\"SoundTrack\"}],\"Name\":\"Westworld\",\"AuthorName\":\"Ramin Djawadi\",\"Year\":2016,\"Studio\":\"WB\",\"Duration\":\"00:09:56\"}{\"Songs\":[{\"Name\":\"Moonage Daydream\",\"Duration\":\"00:04:40\",\"Style\":\"Rock\"}],\"Name\":\"The rise and Fall of Ziggy Sturdus and the Spiders from Mars\",\"AuthorName\":\"David Bowie\",\"Year\":1972,\"Studio\":\"WB\",\"Duration\":\"00:04:40\"}";


        }
    }
}
//Задание 2:
//Создайте программу для работы с информацией о музыкальном альбоме. Нужно хранить такую информацию об альбоме:
//1. Название альбома
//2. Название исполнителя
//3. Год выпуска
//4. Длительность
//5. Студия выпуска

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
