﻿namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Album[] albums = new Album[3];
            //albums[0] = new Album("Turn Blue", "The Black Keys", 2014, new TimeOnly(0, 45), "WB");
            //albums[1] = new Album("Westworld", "Ramin Djawadi", 2016, new TimeOnly(1, 49), "WB");
            //albums[2] = new Album("The rise and Fall of Ziggy Sturdus and the Spiders from Mars", "David Bowie", 1972, new TimeOnly(0, 38), "WB");


            //Album album = new Album("Turn Blue", "The Black Keys", 2014, new TimeOnly(0, 45), "WB");
            //album.Add(new Song("Fever", new TimeOnly(0, 3, 13), "Indy"), new Song("Bullet in the brain", new TimeOnly(0, 3, 13), "Indy"));
            //AlbumManager.Save(AlbumManager.Serialize(album), @"C:\Users\Brill\Desktop\Четотам.json");
            Album album1 = AlbumManager.Deserialize(AlbumManager.Load(@"C:\Users\Brill\Desktop\Четотам.json"));

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
