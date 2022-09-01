using MercedesDealership.Interfaces;
using MercedesDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercedesDealership.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { name = "EQE",
                              shortDesc = "Комфорт и безопасность",
                              longDesc = "Новый EQE сочетает свой динамичный облик с роскошным интерьером, соблюдая баланс между техническими инновациями и современной эстетикой.", 
                              img = "https://motor.ru/thumb/1500x0/filters:quality(75):no_upscale()/imgs/2022/03/15/12/5301366/f6dcb342632625e354d6c0370c7d803abc82b0f3.jpg", 
                              price = 45000, 
                              isFavorite = false, 
                              availeble = true, 
                              Category = _categoryCars.AllCategories.First() },
                    new Car { name = "EQS",
                              shortDesc = "Скоростной, спортивный Mercedes",
                              longDesc = "Mercedes EQS – начало новой технологичной эры. Он создан на принципиально обновленной платформе электромобилей",
                              img = "https://mercedesblog.com/wp-content/uploads/2020/01/Mercedes-EQS-2.jpg",
                              price = 45000,
                              isFavorite = false,
                              availeble = true,
                              Category = _categoryCars.AllCategories.First() },
                     new Car { name = "E-Класс Седан",
                              shortDesc = "Чемпион инноваций",
                              longDesc = "С легкостью преодолевает любые трудности Откройте для себя превосходные качества седана E-Класса. Динамичного, элегантного и роскошного как никогда.",
                              img = "https://editorial.pxcrush.net/carsales/general/editorial/2020-mercedes-benz-e-class_014.jpg?width=1024&height=683",
                              price = 45000,
                              isFavorite = true,
                              availeble = true,
                              Category = _categoryCars.AllCategories.Last() },
                     new Car { name = "S-Класс Седан",
                              shortDesc = "Современная эстетика и ощущение простора",
                              longDesc = "Главное в новом седане S-Класса – уникальный комфорт и технологии безопасности, на которые вы всегда можете рассчитывать и как водитель, и как пассажир.",
                              img = "https://cdn.motor1.com/images/mgl/gL004/s1/2021-mercedes-benz-s-class-exterior.jpg ",
                              price = 45000,
                              isFavorite = true,
                              availeble = true,
                              Category = _categoryCars.AllCategories.Last() },
                     new Car { name = "GLE Купе",
                              shortDesc = "Красота снаружи. Удобство внутри",
                              longDesc = "Новый GLE купе создан для того, чтобы покорить любую аудиторию с первой секунды. Эффектным спортивным дизайном. Революционной передней панелью. И активной ходовой частью, устанавливающей стандарты в своем классе.",
                              img = "https://www.mercedes-benz.ru/passengercars/mercedes-benz-cars/models/gle/coupe-c167/mercedes-amg/equipment/_jcr_content/swipeableteaserbox/par/swipeableteaser/asset.MQ6.12.20201012112429.jpeg",
                              price = 45000,
                              isFavorite = true,
                              availeble = true,
                              Category = _categoryCars.AllCategories.Last() },
                     new Car { name = "G-Класс AMG Внедорожник",
                              shortDesc = "Нет дорог? Есть G-Класс",
                              longDesc = "Характерный дизайн, технологическое совершенство и невероятная мощь стали той основой, которая и сегодня, 40 лет спустя, определяет внутреннюю сущность всех последующих поколений G-Класса.",
                              img = "https://casauto.com/Files/Products/127382_1.jpg",
                              price = 45000,
                              isFavorite = true,
                              availeble = true,
                              Category = _categoryCars.AllCategories.Last() },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
